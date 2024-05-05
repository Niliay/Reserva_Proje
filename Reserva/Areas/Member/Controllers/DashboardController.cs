﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Reserva.Areas.Member.Controllers
{
	[Area("Member")]
	public class DashboardController : Controller
	{
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IActionResult> Index()
		{
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Isim +" "+ values.Soyisim;
            ViewBag.imageUrl = values.ResimUrl;
            return View();
		}
	}
}
