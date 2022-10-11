using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using PlakaTakipSistemi;

namespace PlakaTakipSistemi
{
    public partial class YeniKayit : Form
    {
        Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        /// <summary>
        /// Kayıt ekranını oluşturur.
        /// </summary>
        public YeniKayit()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        /// <summary>
        /// Resim seçilecek ekranı açar, seçilen resmi ekranda gösterir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) => StartListening();
    

        #region İstemci tarafından alınan resmi işleyerek veritabanına kaydeder.
        /// <summary>
        /// İstemci tarafından alınan resmi işleyerek veritabanına kaydeder.
        /// </summary>
        private void processImageAndSave(Bitmap image)
        {
            string plate = Database.GetText(image);
            if (!String.IsNullOrEmpty(plate))
            {
                bool result = Database.PlakaEkle(plate, "Giriş");
                if (!result)
                    infoMessage.Text = plate + PlakaTakipSistemi.Constant.ErrorMessages.PlateCantLoadDB;

                else
                    infoMessage.Text = plate + PlakaTakipSistemi.Constant.InfoMessages.AccessSuccessfully;


            }
            else
                infoMessage.Text = PlakaTakipSistemi.Constant.ErrorMessages.PlateCantFind;

        }

        #endregion

        #region Ekranı kapatan aksiyon
        /// <summary>
        /// Ekranı kapatır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            listener.Close();
            MessageBox.Show("Sistem kapatıldı..", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion


        #region Socket kısmı
        public ManualResetEvent allDone = new ManualResetEvent(false);

        public void StartListening()
        {

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[1];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(5); //Dinleme işlemi yapılırken en fazla 5 işlem kuyrukta durabilir.

                //Olayın durumunu 'Sinyal yok' olarak ayarlar ve iş parçacıklarının engellenmesine neden olur.
                allDone.Reset();
                infoMessage.Text = "Bağlantı bekleniyor...";

                //Gelen bağlantı girişimini kabul etmek için zaman uyumsuz bir işlem başlatır.
                listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);


                allDone.WaitOne(); //Sinyal alana kadar mevcuttaki iş parçacığını bekletir.
            }
            catch (Exception e)
            {
                //Değiştir. sb' ye at
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            allDone.Set(); //Bekleyen iş & işlerin ilerlemesine izin verir ve sinyal durumunu aktife çeker.
            Socket listener = (Socket)ar.AsyncState;
            //Zaman uyumsuz olarak gelen bir bağlantı girişimini kabul eder ve uzak konak iletişimlerini işlemek için yeni Socket bir oluşturur.
            Socket handler = listener.EndAccept(ar);

            StateObject state = new StateObject();
            state.workSocket = handler;
            //Bağlı Socket'den zaman uyumsuz olarak veri almaya başlar.
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
        }

        public void ReadCallback(IAsyncResult ar)
        {

            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            //Bekleyen zaman uyumsuz okumayı sonlandırır.
            int bytesRead = handler.EndReceive(ar);

            //Datayı gelmişse işlenir.
            if (bytesRead > 0)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                totalSize.Text = bytesRead.ToString();

                //Byte formunda alınan resmi dönüştürür.
                Bitmap newBitmap = GetImageFromByteArray(state.buffer);
              
                //Image newImage = byteArrayToImage(state.buffer);

                //Resmi form ekranında gösterir ve veritabanına kaydeder.
                pbPlaka.Image = newBitmap;

                processImageAndSave(newBitmap);

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                totalTime.Text = ts.ToString();

                //Bağlı Socket'den zaman uyumsuz olarak veri almaya başlar.
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);

            }
        }

        /// <summary>
        /// Method that uses the ImageConverter object in .Net Framework to convert a byte array, 
        /// presumably containing a JPEG or PNG file image, into a Bitmap object, which can also be 
        /// used as an Image object.
        /// </summary>
        /// <param name="byteArray">byte array containing JPEG or PNG file image or similar</param>
        /// <returns>Bitmap object if it works, else exception is thrown</returns>
        public Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            ImageConverter _imageConverter = new ImageConverter();
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }
        #endregion

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }

}
