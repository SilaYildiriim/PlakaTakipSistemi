using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakaTakipSistemi
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //Program burdan başlıyor.Form1'i açar (Ana Ekran) 
        }
    }
    // Projedeki ana dosyalara (Form1, Kapilar, YeniKayit)  Çift tıklanırsa ekran tasarımları açılır.
}
