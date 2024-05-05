using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.ViewComponents.Default
{
    public class _AltHakkimizda :ViewComponent
    {
        AltHakkimizdaManager altHakkimizdaManager = new AltHakkimizdaManager(new EfAltHakkimizdaDal());

        public IViewComponentResult Invoke()
        {
            var values = altHakkimizdaManager.TGetList();
            return View(values);
        }
    }
}
