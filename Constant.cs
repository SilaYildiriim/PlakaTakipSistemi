using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakaTakipSistemi
{
    /// <summary>
    /// Sabit metinlerin ve uyarı mesajlarının tutulduğu kısımdır.
    /// </summary>
    internal class Constant
    {

        /// <summary>
        /// The iron ocr licence
        /// </summary>
        public const string IronOcrLicence = "IRONOCR.EMINYASIRCORUT.6211-3E119EF8E9-B3MKHF6XZWTHL-XQQ22JXECSRA-CBTATG7TN4XT-OYHVUVJCLRHU-MEPNHNKI7DAX-KLJXXS-T5VT6VXEFJWGUA-DEPLOYMENT.TRIAL-EMGHLP.TRIAL.EXPIRES.26.JUL.2022";

        /// <summary>
        /// The image formats
        /// </summary>
        public const string ImageFormats = "Resim Dosyalar|*.png;*.jpg;*.jpeg;*.bmp";

        /// <summary>
        /// The hypen
        /// </summary>
        public const string Hypen = "-";

        /// <summary>
        /// The three dots
        /// </summary>
        public const string ThreeDots = "...";

        /// <summary>
        /// Hata & Uyarı mesajlarının tutulduğu kısımdır.
        /// </summary>
        public class ErrorMessages
        {
            /// <summary>
            /// The plate cant load database
            /// </summary>
            public const string PlateCantLoadDB = "plakalı araç sisteme kaydedilemedi.";

            /// <summary>
            /// The plate cant find
            /// </summary>
            public const string PlateCantFind = "Aracın plakası bulunamadı.";

            /// <summary>
            /// The connection error
            /// </summary>
            public const string ConnectionError = "Veritabanı bağlantısında bir hata oluştu";

            /// <summary>
            /// The unexpected error
            /// </summary>
            public const string UnexpectedError = "Beklenmedik bir hata oluştu";

            /// <summary>
            /// The inromation cant take from database
            /// </summary>
            public const string InromationCantTake = "Bilgiler alınamadı.";

            /// <summary>
            /// The cant delete car information
            /// </summary>
            public const string CantDeleteCarRecord = "Araç kaydı sistemden silinirken hata oluştu.";

            /// <summary>
            /// The cant deleted selected identifier
            /// </summary>
            public const string CantDeletedSelectedID = " id' li kayıt silinemedi.";

        }

        /// <summary>
        /// Bilgilendirme mesajlarının tutulduğu kısımdır.
        /// </summary>
        public class InfoMessages
        {
            /// <summary>
            /// The access successfully
            /// </summary>
            public const string AccessSuccessfully = "plakalı araç giriş yaptı.";

            /// <summary>
            /// The delete successfully
            /// </summary>
            public const string DeleteSuccessfully = "Araç bilgileri sistemden silindi.";

            /// <summary>
            /// The multiple records delete successfully
            /// </summary>
            public const string MultipleRecordsDeleteSuccessfully = "Seçilen araç kayıtları sistemden silindi.";
        }

        /// <summary>
        /// Uyarı mesajlarının tutulduğu kısımdır.
        /// </summary>
        public class WarningMessage
        {
            /// <summary>
            /// The please choose record
            /// </summary>
            public const string PleaseChooseRecord = "Lütfen silinecek kaydı seçiniz.";
        }

        /// <summary>
        /// Kullanıcıya yöneltilen soruların tutulduğu kısımdır.
        /// </summary>
        public class QuestionMessage
        {
            /// <summary>
            /// The are you sure to delete multiple records
            /// </summary>
            public const string AreYouSureToDeleteMultipleRecords = "Birden fazla kaydı silmek üzeresiniz.Devam etmek istiyor musunuz?";
        }

        /// <summary>
        /// Formda gözülen başlıkların tutulduğu kısımdır.
        /// </summary>
        public class FormMessages
        {
            /// <summary>
            /// Creates new record.
            /// </summary>
            public const string NewRecord = "Yeni Kayıt";

            /// <summary>
            /// Creates new plate.
            /// </summary>
            public const string NewPlate = "Yeni Plaka Girişi";

            /// <summary>
            /// The total size
            /// </summary>
            public const string TotalSize = "Toplam Boyut : ";

            /// <summary>
            /// The total time
            /// </summary>
            public const string TotalTime = "Toplam Süre : ";

            /// <summary>
            /// The start
            /// </summary>
            public const string Start = "Başlat";

            /// <summary>
            /// The received image
            /// </summary>
            public const string ReceivedImage = "Alınan Resim";

            /// <summary>
            /// The information
            /// </summary>
            public const string Information = "Bilgilendirme:";

            /// <summary>
            /// The exit
            /// </summary>
            public const string Exit = "Çıkış Yap";
        }

        public enum MessageType
        {
            /// <summary>
            /// The information
            /// </summary>
            Information,

            /// <summary>
            /// The warning
            /// </summary>
            Warning,

            /// <summary>
            /// The error
            /// </summary>
            Error,

            /// <summary>
            /// The database error
            /// </summary>
            DBError,

        }
    }
}
