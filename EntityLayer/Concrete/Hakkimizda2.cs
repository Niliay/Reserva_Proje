using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda2 //about2
    {
        [Key]
        public int Hakkimizda2ID { get; set; }
        public string Baslik {  get; set; } //title
        public string Baslik2 {  get; set; }
        public string Aciklama { get; set; }//description
        public string Resim { get; set; } //Image
    }
}
