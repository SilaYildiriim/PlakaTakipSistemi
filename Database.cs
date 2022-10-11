using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using IronOcr;
using System.Diagnostics;


namespace PlakaTakipSistemi
{
    internal class Database
    {
        /*con - Oluşturulan tablolara bağlanır.
         cmd - sql sorgularını tutar ve ilgili yere göderir, okur.
         dr -  okunan sql sorgusunu tutar, böylelikle tablodan dönen değerleri parametrelerimize atabiliriz.
        */
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PlakaTakipVt.mdf;Integrated Security=True");
        static SqlCommand cmd;
        static SqlDataReader dr;

        public static bool PlakaEkle(Bitmap plaka, string islem)
        {
            return PlakaEkle(GetText(plaka),  islem);

        }
        public static bool PlakaEkle(string plaka,string islem)
        {
            if (String.IsNullOrEmpty(plaka))
                return false;
            else if(!String.IsNullOrEmpty(plaka))
            {
                if (plaka.Length == 0)
                    return false;
            }
            else
            {
        
            string girisID = String.Empty;
            con.Open();
            cmd = new SqlCommand("SELECT TOP 1 Id FROM GirisCikis WHERE Islem='Giriş' AND Plaka=@plaka AND GirisCikisId='-' ORDER BY Tarih DESC", con);
            cmd.Parameters.AddWithValue("@plaka", plaka);
            dr = cmd.ExecuteReader();
            if (dr.Read())

                girisID = dr[0].ToString();
            
            else
                girisID = Constant.Hypen;
            

            dr.Close();
            cmd = new SqlCommand("INSERT INTO GirisCikis VALUES(@plaka,@islem,GETDATE(),@notlar,@kapi,@girisID)", con);
            cmd.Parameters.AddWithValue("@plaka", plaka);
            cmd.Parameters.AddWithValue("@kapi", null);
            cmd.Parameters.AddWithValue("@islem", islem);
            cmd.Parameters.AddWithValue("@notlar", null);
            cmd.Parameters.AddWithValue("@girisID", girisID);
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
            
            }
            return true;
        }

        /// <summary>
        /// "GirisCikis" tablosundaki kayıtları getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Kayit GirisCikisVerisi(string id)
        {
            //Notları vs sil
            string girisId = "";
            Kayit kayit = new Kayit();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM GirisCikis WHERE Id=" + id, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kayit.Plaka = dr[1].ToString();
                if (dr[2].ToString() == "Giriş")
                {
                    kayit.GirisTarih = dr[3].ToString();
                    kayit.GirisKapi = dr[5].ToString();
                    kayit.GirisNotlar = dr[4].ToString();
                }
                else
                {
                    girisId = dr[6].ToString();
                    kayit.CikisTarih = dr[3].ToString();
                    kayit.CikisKapi = dr[5].ToString();
                    kayit.CikisNotlar = dr[4].ToString();
                }
            }
            dr.Close();
            if (!String.IsNullOrEmpty(girisId))
            {
                cmd = new SqlCommand("SELECT * FROM GirisCikis WHERE Id=" + girisId, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    kayit.GirisTarih = dr[3].ToString();
                    kayit.GirisKapi = dr[5].ToString();
                    kayit.GirisNotlar = dr[4].ToString();
                }
            }
            con.Close();
            return kayit;
        }

        /// <summary>
        /// Parametre olarak aldığı sorguyu çalıştırır ve yine parametre olarak aldığı gridin içine doldurur.
        /// </summary>
        /// <param name="sorgu"></param>
        /// <param name="dgv"></param>
        public static void TabloGoster(string sorgu, DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            con.Close();
        }

        /// <summary>
        /// Tablodan id' si verilen kaydı siler.
        /// </summary>
        /// <param name="id"></param>
        public static bool KayitSil(int id)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM GirisCikis Where Id=" + id, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

            }
            con.Close();
            return true;
        }

        /// <summary>
        /// Girilen resimdeki plakayı okuyup text olarak döner.
        /// </summary>
        /// <param name="resimKaynagi"></param>
        /// <returns></returns>
        public static string GetText(Bitmap resimKaynagi)
        {
            try
            {

                /*
                 * IronOcr resimlerden ve PDF belgelerinden Türkçe dahil 126 dilde metin okumasını sağlayan bir C# yazılım bileşenidir.
                 */
                IronOcr.Installation.LicenseKey = PlakaTakipSistemi.Constant.IronOcrLicence;


                IronTesseract IronOcr1 = new IronTesseract();

                var Ocr = new IronTesseract(); 
                using (var Input = new OcrInput(resimKaynagi))
                {
                    var ocrResult = Ocr.Read(Input);
                    return Regex.Match(ocrResult.Text, "[0-9]{2}([ ]+)?[A-Z]{1,4}([ ]+)?[0-9]{0,4}").Value;
                    // Regex("(0[1-9]|[1-7][0-9]|8[01])(([A-Z])(\\d{4,5})|([A-Z]{2})(\\d{3,4})|([A-Z]{3})(\\d{2}))");
                    // orijinal : "[0-9]{2}([ ]+)?[A-Z]{1,4}([ ]+)?[0-9]{0,}"

                }


                /*
                 * Resmi okuduktan sonra eşleşen kuralara göre bir değer döner. (Regex.Match kısmı) kuralları ->
                 * "[0-9]{2}" : 0-9 aralığında değer almalı ve 2 kere tekrar etmeli ,
                 * "[A-Z]{1,4}" : A-Z arasında değer almalı ve 1-4  kere tekrar etmeli,
                 * "[0-9]{0,}" :0-9 aralığında değer almalı ve 0-sonsuz arası tekrar edebilir.
                 * "[ ]+" : herhangi bir karakter
                 */
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

    }
}
