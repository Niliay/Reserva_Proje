using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Iletisim //contact
    {
        [Key]
        public int IltesimID { get; set; } //contactid
        public string Aciklama { get; set; } //description
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; } //phone
        public string HaritaKonum { get; set; } //mapLocation
        public bool Durum { get; set; } //status

    }
}
