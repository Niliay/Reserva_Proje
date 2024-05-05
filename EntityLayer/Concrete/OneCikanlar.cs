using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OneCikanlar //Feature
    {
        [Key]
        public int OneCikanlarID { get; set; } //FeaturedID
        public int Baslik { get; set; } //Title
        public string Aciklama { get; set; } //Description
        public string Resim { get; set; } //Image
        public bool Durum { get; set; } // status
    }
}
