using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakaTakipSistemi
{
    internal class Kayit
    {
        string plaka;
        string girisKapi;
        string cikisKapi;
        string girisNotlar;
        string cikisNotlar;
        string girisTarih;
        string cikisTarih;
        public Kayit() { plaka = ""; }
        public Kayit(string plaka, string girisKapi, string cikisKapi, string girisNotlar, string cikisNotlar, string girisTarih, string cikisTarih)
        {
            this.Plaka = plaka;
            this.GirisKapi = girisKapi;
            this.CikisKapi = cikisKapi;
            this.GirisNotlar = girisNotlar;
            this.CikisNotlar = cikisNotlar;
            this.GirisTarih = girisTarih;
            this.CikisTarih = cikisTarih;
        }

        public string Plaka { get => plaka; set => plaka = value; }
        public string GirisKapi { get => girisKapi; set => girisKapi = value; }
        public string CikisKapi { get => cikisKapi; set => cikisKapi = value; }
        public string GirisNotlar { get => girisNotlar; set => girisNotlar = value; }
        public string CikisNotlar { get => cikisNotlar; set => cikisNotlar = value; }
        public string GirisTarih { get => girisTarih; set => girisTarih = value; }
        public string CikisTarih { get => cikisTarih; set => cikisTarih = value; }
    }
}
