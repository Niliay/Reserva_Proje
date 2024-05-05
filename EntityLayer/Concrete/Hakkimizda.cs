using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaID { get; set; } //AboutID
        public string Baslik { get; set; } //Title
        public string Aciklama { get; set; } //Description
        public string Baslik2 { get; set; } //Ttile2
        public string Resim1 { get; set; } //Image
        public string Aciklama2 { get; set; }//description2 
        public bool MusaitlikDurumu { get; set; } //status
    }
}
