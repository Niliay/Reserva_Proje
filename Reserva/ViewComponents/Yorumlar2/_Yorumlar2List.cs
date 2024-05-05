using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.ViewComponents.Yorumlar2

{
    public class _Yorumlar2List : ViewComponent
    {
        Yorumlar2Manager yorumlar2Manager = new Yorumlar2Manager(new EfYorumlar2Dal());
        public IViewComponentResult Invoke(int id)
        {
            var values = yorumlar2Manager.TGetTatilYerleriById(id);
            return View(values);
        }
    }
}
