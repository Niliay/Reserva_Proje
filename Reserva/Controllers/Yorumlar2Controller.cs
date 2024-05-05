using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Controllers
{
    public class Yorumlar2Controller : Controller
    {
        Yorumlar2Manager yorumlar2Manager = new Yorumlar2Manager(new EfYorumlar2Dal());

        [HttpGet]
        public PartialViewResult YorumEkle()
        {
            return PartialView();
        }

        //Yukarıdaki metotla aynı isme sahip, overload yapılır:
        [HttpPost]
        public IActionResult YorumEkle(Yorumlar2 p)
        {
            p.Yorumlar2Tarih=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Yorumlar2Durum = true;
            yorumlar2Manager.TAdd(p);
            return RedirectToAction("Index", "TatilYerleri");
        }


    }
}
