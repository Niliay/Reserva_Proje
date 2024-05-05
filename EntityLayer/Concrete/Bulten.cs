using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bulten //NEWSLETTER
    {
        [Key]
        public int BultenID { get; set; } //NEWSLETTER
        public string Mail { get; set; }
    }
}
