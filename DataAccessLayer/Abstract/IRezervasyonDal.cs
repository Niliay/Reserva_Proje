using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRezervasyonDal : IGenericDal<Rezervasyon>
    {
        List<Rezervasyon> GetListWithOnayBekleyenReservasyonlar(int id);
        List<Rezervasyon> GetListWithOnaylanmısRezervasyonlar(int id);
        List<Rezervasyon> GetListWithGecmisRezervasyonlar(int id);
    }
}
