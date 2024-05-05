using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Yorumlar2Manager : IYorumlar2Service
    {
        IYorumlar2Dal _yorumlar2Dal;

        public Yorumlar2Manager(IYorumlar2Dal yorumlar2Dal)
        {
            _yorumlar2Dal = yorumlar2Dal;
        }

        public void TAdd(Yorumlar2 t)
        {
            _yorumlar2Dal.Insert(t);
        }

        public void TDelete(Yorumlar2 t)
        {
            throw new NotImplementedException();
        }

        public Yorumlar2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Yorumlar2> TGetList()
        {
            throw new NotImplementedException();
        }

       public List<Yorumlar2>  TGetTatilYerleriById(int id) //Servicete de aynısını kullandım, implement edilmiş oldu
        {
           return _yorumlar2Dal.GetListByFilter(x => x.TatilYerleriID == id);
        }

        public void TUpdate(Yorumlar2 t)
        {
            throw new NotImplementedException();
        }
    }
}
