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
    public class YorumlarManager : IYorumlarService
    {
        IYorumlarDal _yorumlarDal;

        public YorumlarManager(IYorumlarDal yorumlarDal)
        {
            _yorumlarDal = yorumlarDal;
        }

        public void TAdd(Yorumlar t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Yorumlar t)
        {
            throw new NotImplementedException();
        }

        public Yorumlar TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Yorumlar> TGetList()
        {
            return _yorumlarDal.GetList();  
        }

        public void TUpdate(Yorumlar t)
        {
            throw new NotImplementedException();
        }
    }
}
