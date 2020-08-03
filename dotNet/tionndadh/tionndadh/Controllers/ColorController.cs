using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tionndadh.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            return View();
        }

        public Color MixColor(Color first, Color second)
        {
            // combine the values of Red, Green, and Blue fields then devide by 2 to get average
            int red = (first.R + second.R) / 2;
            int green = (first.G + second.G) / 2;
            int blue = (first.G + second.B) / 2;

            // create a color mix from combined values
            Color mixed = Color.FromArgb(red, green, blue);

            return mixed;
        } 

    }

}