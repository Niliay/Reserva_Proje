using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AltHakkimizda //subAbout
    {
        [Key]
        public int AltHakkimizdaID { get; set; } //SubAboutID
        public string Baslik { get; set; } //title
        public string Aciklama { get; set; } //description
    }
}
