﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.ViewComponents.MemberDashboard
{
    public class _PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
