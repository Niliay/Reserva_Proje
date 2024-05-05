using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.ViewComponents.Default
{
    public class _Yorumlar :ViewComponent
    {
        YorumlarManager yorumlarManager = new YorumlarManager(new EfYorumlarDal());
        public IViewComponentResult Invoke()
        {
            var values = yorumlarManager.TGetList();
            return View(values);
        }

    }
}
