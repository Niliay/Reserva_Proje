using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        TatilYerleriManager tatilYerleriManager = new TatilYerleriManager(new EfTatilYerleriDal());
        public IActionResult Index()
        {
            var values=tatilYerleriManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult OtelEkle() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult OtelEkle(TatilYerleri tatilYerleri)
        {
            tatilYerleriManager.TAdd(tatilYerleri);
            return RedirectToAction("Index");
        }

        public IActionResult OtelSil(int id)
        { 
            var values=tatilYerleriManager.TGetByID(id);
            tatilYerleriManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OtelGüncelle(int id) 
        {
            var values=tatilYerleriManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult OtelGüncelle(TatilYerleri tatilYerleri)
        {
            tatilYerleriManager.TUpdate(tatilYerleri);
            return RedirectToAction("Index");
        }
    }
}
