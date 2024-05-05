using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TatilYerleri
    {
        [Key]
        public int OtelID { get; set; } //DestinationID
        public string OtelAdi { get; set; } //city
        public string Sehir { get; set; } //day-night
        public double Fiyat { get; set; } //price
        public string Resim { get; set; } //image
        public string Aciklama { get; set; } //description
        public int Kapasite { get; set; } // capacity
        public bool MusaitlikDurumu { get; set; } //status
		public string Adres { get; set; }
		public string SlaytResmi1 { get; set; } //CoverImage
		public string SlaytResmi2 { get; set; } //CoverImage
		public string SlaytResmi3 { get; set; } //CoverImage
		public string SlaytResmi4 { get; set; } //CoverImage
		public string Detay1 { get; set; } //details1
        public string Detay2 { get; set; } //details2
        public string Resim2 { get; set; } //Image2
        public List<Yorumlar2> Yorumlar2 { get; set; }
        public List<Rezervasyon> Rezervasyons { get; set; }

    }
}
