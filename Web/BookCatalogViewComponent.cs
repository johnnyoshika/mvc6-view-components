using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web
{
    public class BookCatalogViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new[] {
                "Three Little Pigs",
                "Little Red Riding Hood",
                "Ugly Duckling"
            });
        }
    }
}
