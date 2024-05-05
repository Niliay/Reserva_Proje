using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Reserva.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class DestinationController : Controller
    {

        TatilYerleriManager tatilYerleriManager = new TatilYerleriManager(new EfTatilYerleriDal());
       
        public IActionResult Index()
        {
            var values = tatilYerleriManager.TGetList();
            return View(values);
        }
    }
}
