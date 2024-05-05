using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYorumlar2Service : IGenericService<Yorumlar2>
    {
        List<Yorumlar2> TGetTatilYerleriById(int id);
    }
}
