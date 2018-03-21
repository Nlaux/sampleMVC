using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SampleMvc.Models;

namespace SampleMvc.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult SampleMvcInnerSublayout()
        {
            var model = new SampleMvcInnerSublayoutViewModel
            {
                CurrentYear = Sitecore.DateUtil.ToServerTime(DateTime.UtcNow).Year
            };

            var guidValue = Sitecore.Configuration.Settings.GetSetting("parentGuid");

            ViewBag.Message = guidValue;

            return View(model);
        }
    }
}