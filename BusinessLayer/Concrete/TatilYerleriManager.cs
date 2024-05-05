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
    //
    public class TatilYerleriManager : ITatilYerleriService
    {
        ITatilYerleriDal _tatilyerleriDal;

        public TatilYerleriManager(ITatilYerleriDal tatilyerleriDal)
        {
            _tatilyerleriDal = tatilyerleriDal;
        }

        public void TAdd(TatilYerleri t)
        {
            _tatilyerleriDal.Insert(t);
        }

        public void TDelete(TatilYerleri t)
        {
            _tatilyerleriDal.Delete(t);
        }

        public TatilYerleri TGetByID(int id)
        {
            return _tatilyerleriDal.GetByID(id);
        }

        public List<TatilYerleri> TGetList()
        {
            return _tatilyerleriDal.GetList();
        }

        public void TUpdate(TatilYerleri t)
        {
            _tatilyerleriDal.Update(t);
        }
    }
}
