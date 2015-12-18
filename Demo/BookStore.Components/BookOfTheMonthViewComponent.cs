using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Components
{
    public class BookOfTheMonthViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View((object)"Little Red Riding Hood");
        }
    }
}
