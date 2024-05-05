using Microsoft.AspNetCore.Mvc;

namespace Reserva.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        //
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        } 
    }
}
