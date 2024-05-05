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
    public class TatilYerleriController : Controller
    {
        TatilYerleriManager tatilYerleriManager = new TatilYerleriManager(new EfTatilYerleriDal());
        public IActionResult Index()
        {
            var values = tatilYerleriManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult TatilYerleriDetails(int id)
        {
            ViewBag.i = id;
            var values = tatilYerleriManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult TatilYerleriDetails(TatilYerleri p)
        {
            return View();
        }

    }
}
