using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //interface tatil yerleri data access layer:
    public interface ITatilYerleriDal : IGenericDal<TatilYerleri> //IDestinationDal
    {

       /* void Insert(TatilYerleri tatilYerleri);
        void Delete(TatilYerleri tatilYerleri);
        void Update(TatilYerleri tatilYerleri);
        List<TatilYerleri> GetList();*/
    }
}
