using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class AppUser : IdentityUser<int>
	{
        public string ResimUrl { get; set; }//ImageUrl
        public string Isim { get; set; } //Name
        public string Soyisim {  get; set; }//surname
        public string Cinsiyet { get; set; }//gender
        public List<Rezervasyon> Rezervasyons{ get; set; }

    }
}
