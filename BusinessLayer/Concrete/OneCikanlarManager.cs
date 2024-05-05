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
    public class OneCikanlarManager : IOneCikanlarService
    {
        IOneCikanlarDal _oneCikanlarDal;

        public OneCikanlarManager(IOneCikanlarDal oneCikanlarDal)
        {
            _oneCikanlarDal = oneCikanlarDal;
        }

        public void TAdd(OneCikanlar t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(OneCikanlar t)
        {
            throw new NotImplementedException();
        }

        public OneCikanlar TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OneCikanlar> TGetList()
        {
            return  _oneCikanlarDal.GetList();
        }

        public void TUpdate(OneCikanlar t)
        {
            throw new NotImplementedException();
        }
    }
}
