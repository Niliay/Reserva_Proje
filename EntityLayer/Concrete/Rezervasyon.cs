using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rezervasyon
    {
        [Key]
        public int ReservasyonID { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public string KisiSayisi {  get; set; }
       //silindi: public string Sehir { get; set; } //destination
       //sil: public string OtelAdi { get; set; }
        public DateTime RezervayonTarihi { get; set; }
        public string RezervasyonDurumu { get; set; } //status
       // public string Aciklama { get; set; } //description
        public int TatilYerleriOtelID { get; set; }
        public TatilYerleri TatilYerleri { get; set; }
    }
}
