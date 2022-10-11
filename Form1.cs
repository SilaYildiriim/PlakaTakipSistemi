using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakaTakipSistemi
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Ekrandanki alanları oluşturur / çizer. (Visual studionun otomatik yazdığı kod bloğu).
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///Uygulamadan çıkış yapar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Plaka kayıt ekranına açar.- "Sistemi Başlat" butonu aksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //burdan listeyi çağır
            new YeniKayit().ShowDialog();
            Database.TabloGoster("SELECT Id,Plaka,Islem,Tarih,Kapi,Notlar FROM GirisCikis ORDER BY " + cbSirala.SelectedItem.ToString(), dgPlaka);

        }

        /// <summary>
        /// "GirisCikis" tablosunda olan kayıtları getirir. (Sırala combobox'unda seçilen değere göre sıralar)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cbSirala.SelectedIndex = 0;

            Database.TabloGoster("SELECT Id,Plaka,Islem,Tarih,Kapi,Notlar FROM GirisCikis ORDER BY " + cbSirala.SelectedItem.ToString(), dgPlaka);
        }

        /// <summary>
        /// Sırala combobox'unda seçilen değer değişirse yeni değere göre tekrar sıralama yapar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Database.TabloGoster("SELECT Id,Plaka,Islem,Tarih,Kapi,Notlar FROM GirisCikis WHERE Plaka LIKE '%"
                + searchTextBox.Text + "%' ORDER BY " + cbSirala.SelectedItem.ToString(), dgPlaka);
        }

        /// <summary>
        /// Tablodan aldığı değerlere göre "Kayıt Detayları" kısmındaki alanları doldurur. (Plaka, Giriş Tarihi, Giriş Kapısı vb.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPlaka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPlaka.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string id = dgPlaka.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Kayit kayit = Database.GirisCikisVerisi(id);
                    if (!String.IsNullOrEmpty(kayit.Plaka))
                    {
                        lbGirisTarihi.Text = kayit.GirisTarih;
                        lbPlaka.Text = kayit.Plaka;
                    }
                    else
                        MessageBox.Show(Constant.ErrorMessages.InromationCantTake);
                   
                }
            }
            catch (TimeoutException ex)
            {
                if (Database.con.State == ConnectionState.Open)
                    Database.con.Close();

                MessageBox.Show(Constant.ErrorMessages.ConnectionError , ex.ToString());
            }
        }

        /// <summary>
        /// "GirisCikis" tablosunda olan kayıtları getirir. - Yenile butonu aksiyonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Database.TabloGoster("SELECT Id,Plaka,Islem,Tarih,Kapi,Notlar FROM GirisCikis ORDER BY " + cbSirala.SelectedItem.ToString(), dgPlaka);
        }

        /// <summary>
        /// Seçilen kaydı siler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                bool allRecordsIsDeleted = true;
                Kayit kayit = new Kayit();
                if (dgPlaka != null && dgPlaka.RowCount > 0)
                {
                    var selectedRecordCount = dgPlaka.SelectedRows.Count;

                    if (selectedRecordCount > 1)
                    {
                        DialogResult dialogResult = MessageBox.Show(Constant.QuestionMessage.AreYouSureToDeleteMultipleRecords, Constant.MessageType.Warning.ToString(),
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow row in dgPlaka.SelectedRows)
                            {
                                Int32 recordId = (Int32)row.Cells[0].Value;
                                allRecordsIsDeleted = Database.KayitSil(recordId);

                                if (!allRecordsIsDeleted)
                                    stringBuilder.AppendLine(recordId + Constant.ErrorMessages.CantDeletedSelectedID);
                            }
                            if (stringBuilder.Length > 0)
                                MessageBox.Show(stringBuilder.ToString(), Constant.MessageType.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                            {
                                MessageBox.Show(Constant.InfoMessages.MultipleRecordsDeleteSuccessfully, Constant.MessageType.Information.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Database.TabloGoster("SELECT Id,Plaka,Islem,Tarih,Kapi,Notlar FROM GirisCikis WHERE Plaka LIKE '%"
                                + searchTextBox.Text + "%' ORDER BY " + cbSirala.SelectedItem.ToString(), dgPlaka);
                                lbPlaka.Text = null;
                                lbGirisTarihi.Text = null;
                            }

                        }
                        else
                        return;
                    }
                    else if (selectedRecordCount == 1)
                    {
                        foreach (DataGridViewRow row in dgPlaka.SelectedRows)
                        {
                            Int32 recordId = (Int32)row.Cells[0].Value;
                            bool response = Database.KayitSil(recordId);

                            if (response)
                            {
                                MessageBox.Show(Constant.InfoMessages.DeleteSuccessfully, Constant.MessageType.Information.ToString()
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Database.TabloGoster("SELECT Id,Plaka,Islem,Tarih,Kapi,Notlar FROM GirisCikis WHERE Plaka LIKE '%"
                                + searchTextBox.Text + "%' ORDER BY " + cbSirala.SelectedItem.ToString(), dgPlaka);

                                lbPlaka.Text = null;
                                lbGirisTarihi.Text = null;
                            }
                            else
                            {
                                MessageBox.Show(Constant.ErrorMessages.CantDeleteCarRecord, Constant.MessageType.Error.ToString(),
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show(Constant.WarningMessage.PleaseChooseRecord, Constant.MessageType.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (Database.con.State == ConnectionState.Open)
                        Database.con.Close();
                }
                else
                {
                    MessageBox.Show(Constant.WarningMessage.PleaseChooseRecord, Constant.MessageType.Warning.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Constant.ErrorMessages.UnexpectedError, Constant.MessageType.DBError.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
