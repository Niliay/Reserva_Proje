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
    public class AltHakkimizdaManager : IAltHakkimizdaService
    {
        IAltHakkimizdaDal _altHakkimidaDal;

        public AltHakkimizdaManager(IAltHakkimizdaDal altHakkimidaDal)
        {
            _altHakkimidaDal = altHakkimidaDal;
        }

        public void TAdd(AltHakkimizda t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AltHakkimizda t)
        {
            throw new NotImplementedException();
        }

        public AltHakkimizda TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AltHakkimizda> TGetList()
        {
            return _altHakkimidaDal.GetList(); 
        }

        public void TUpdate(AltHakkimizda t)
        {
            throw new NotImplementedException();
        }
    }
}
