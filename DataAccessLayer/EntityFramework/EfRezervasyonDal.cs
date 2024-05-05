using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfRezervasyonDal : GenericRepository<Rezervasyon>, IRezervasyonDal
    {
        public List<Rezervasyon> GetListWithGecmisRezervasyonlar(int id) //previous
        {
            using (var context = new Context())
            {
                return context.Rezervasyons.Include(x => x.TatilYerleri).Where(x => x.RezervasyonDurumu == "Geçmiş Rezervasyon" && x.AppUserID == id).ToList();
            }
        }

        public List<Rezervasyon> GetListWithOnayBekleyenReservasyonlar(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervasyons.Include(x=>x.TatilYerleri).Where(x=>x.RezervasyonDurumu=="Onay Bekliyor" && x.AppUserID==id ).ToList();
            }
        }

        public List<Rezervasyon> GetListWithOnaylanmısRezervasyonlar(int id) //accepted
        {
            using (var context = new Context())
            {
                return context.Rezervasyons.Include(x => x.TatilYerleri).Where(x => x.RezervasyonDurumu == "Onaylandı" && x.AppUserID == id).ToList();
            }
        }
    }
}
