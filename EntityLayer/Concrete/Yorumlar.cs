using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorumlar //TESTIMONİAL
    {
        [Key]
        public int YorumlarID { get; set; } //TESTMİONALıd
        public string Musteri { get; set; } //client
        public string Yorum { get; set; } //comment
        public bool Durum { get; set; } //status
    }
}
