using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    //entitt framework hakkımızda data access layer:
    public class EfHakkimizdaDal : GenericRepository<Hakkimizda>, IHakkimizdaDal
    {
    }
}
