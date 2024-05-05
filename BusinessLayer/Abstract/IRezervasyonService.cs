using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRezervasyonService : IGenericService<Rezervasyon>
    {
        //List<Rezervasyon> GetListOnayBekleyenRezervasyonlar(int id);
        List<Rezervasyon> GetListWithOnayBekleyenReservasyonlar(int id);
        List<Rezervasyon> GetListWithGecmisRezervasyonlar(int id);
        List<Rezervasyon> GetListWithOnaylanmısRezervasyonlar(int id);
    }
}
