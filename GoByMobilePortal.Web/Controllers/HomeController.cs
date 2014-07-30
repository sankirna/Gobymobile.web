using System.Web.Routing;
using GoByMobilePortal.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoByMobilePortal.Web.Helper;
using GoByMobilePortal.Web.Models;

namespace GoByMobilePortal.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            // TODO Logic here find default city
            return RedirectToAction("RedirectCustomeCityAction", new { cityName = "vadodara" });
        }


        public ActionResult RedirectCustomeCityAction(string cityName)
        {
            // TODO Logic here find default service basec on city
            return RedirectToAction("RedirectCustomeCityResturentAction", new { cityName = cityName, serviceName = "Restaurent" });
        }

        public ActionResult RedirectCustomeCityResturentAction(string cityName, string serviceName)
        {
            return View(EnumUtil.GetEnumDescription(TemplateType.HomePage));
        }



        public ActionResult List()
        {
            ViewBag.Message = "Your app description page.";

            return View(EnumUtil.GetEnumDescription(TemplateType.RestaurantList), new RestaurantList()
            {
                RestaurantDetailses = new List<RestaurantDetails>()
                {
                    new RestaurantDetails() { Id = 1, Name = "Gateway" },
                    new RestaurantDetails() { Id = 2, Name = "Surya" }
                }
            });
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your contact page.";

            int[] numbers = new int[3] { 1, 2, 3 };
            Random rd = new Random();
            int randomIndex = rd.Next(0, 3);
            int randomNumber = numbers[randomIndex];

            TemplateType templateType = (TemplateType)randomNumber;
            MasterTemplateModel model = new MasterTemplateModel();
            model.LayoutPath = EnumUtil.GetEnumDescription(templateType);
            model.TemplateType = templateType;
            return View(model.LayoutPath, new RestaurantDetails() { Id = 1, Name = "Gateway" });
        }

        [ChildActionOnly]
        public ActionResult FooterLevel1(FooterType footerType)
        {
            //TODO  Set Server Side Logic  and assign model
            return PartialView("_Footer.Level1");
        }

        [ChildActionOnly]
        public ActionResult FooterLevel2(FooterType footerType)
        {
            //TODO  Set Server Side Logic  and assign model
            return PartialView("_Footer.Level2");
        }
    }
}
