using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;

namespace Reserva.ViewComponents.Default
{
    //Populer Destinations
    public class _PopulerOteller : ViewComponent
    {
        TatilYerleriManager tatilYerleriManager = new TatilYerleriManager(new EfTatilYerleriDal());
        public IViewComponentResult Invoke()
        {
            var values = tatilYerleriManager.TGetList();
            return View(values);
        }
    }
}
