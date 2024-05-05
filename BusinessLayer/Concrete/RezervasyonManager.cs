using DataAccessLayer.Abstract;
using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class RezervasyonManager : IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;

        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public List<Rezervasyon> GetListWithGecmisRezervasyonlar(int id)
        {
            return _rezervasyonDal.GetListWithGecmisRezervasyonlar(id);
        }

        public List<Rezervasyon> GetListWithOnayBekleyenReservasyonlar(int id)
        {
            return _rezervasyonDal.GetListWithOnayBekleyenReservasyonlar(id);
        }

        public List<Rezervasyon> GetListWithOnaylanmısRezervasyonlar(int id)
        {
            return _rezervasyonDal.GetListWithOnaylanmısRezervasyonlar(id) ;
        }

        public void TAdd(Rezervasyon t)
        {
            _rezervasyonDal.Insert(t);
        }

        public void TDelete(Rezervasyon t)
        {
            throw new NotImplementedException();
        }

        public Rezervasyon TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervasyon> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Rezervasyon t)
        {
            throw new NotImplementedException();
        }
    }
}
