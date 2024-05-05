using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.ViewComponents.Default
{
    public class _OneCikanlar :ViewComponent
    {
        OneCikanlarManager oneCikanlarManager = new OneCikanlarManager(new EfOneCikanlarDal());
        public IViewComponentResult Invoke()
        {
           // var values = oneCikanlarManager.TGetList();

            return View();
        }
    }
}
