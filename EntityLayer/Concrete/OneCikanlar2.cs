using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OneCikanlar2 //feaure2
    {
        [Key]
        public int OneCikanlar2ID { get; set; } //feature2id
        public string Baslik { get; set; } //title
        public string Aciklama { get; set; } //description
        public string Resim { get; set; } //image
        public bool Durum { get; set; } //status
    }
}
