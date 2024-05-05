using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Areas.Member.Controllers
{
    [Area("Member")]
   public class RezervasyonController : Controller
   {
        TatilYerleriManager tatilYerleriManager = new TatilYerleriManager(new EfTatilYerleriDal());
        RezervasyonManager rezervasyonManager = new RezervasyonManager(new  EfRezervasyonDal());

        private readonly UserManager<AppUser> _userManager;

        public RezervasyonController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> AktifRezervasyonlar()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rezervasyonManager.GetListWithOnaylanmısRezervasyonlar(values.Id);
            return View(valuesList);
        }

        public async Task <IActionResult> EskiRezervasyonlar()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rezervasyonManager.GetListWithGecmisRezervasyonlar(values.Id);
            return View(valuesList);
        }

        public async Task <IActionResult> OnayBekleyenReservasyonlar()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = rezervasyonManager.GetListWithOnayBekleyenReservasyonlar(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult YeniRezervasyon() 
        {
            List<SelectListItem> values = (from u in tatilYerleriManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = u.Sehir,
                                               Value = u.OtelAdi
                                           } ).ToList();
            ViewBag.Values= values;
            return View();
        }

        [HttpPost]
        public IActionResult YeniRezervasyon(Rezervasyon p)
        {
            p.AppUserID = 5; //şuanlık statikte dursun
            p.RezervasyonDurumu = "Onay Bekliyor";
            rezervasyonManager.TAdd(p);
            return RedirectToAction("AktifRezervasyonlar");
        }
    }
}
