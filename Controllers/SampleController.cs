using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using SampleMvc.Models;

namespace SampleMvc.Controllers
{
    public class SampleController : SitecoreController
    {
        public ActionResult SampleMvcInnerSublayout()
        {
            //ignore this block, not sure how to delete w/o breaking the view
            var model = new SampleMvcInnerSublayoutViewModel
            {
                CurrentYear = Sitecore.DateUtil.ToServerTime(DateTime.UtcNow).Year
            };


            //read in config file & get parentGuid value
            var parentGuidValue = Sitecore.Configuration.Settings.GetSetting("parentGuid");

            //init Sitecore db 
            Database database = Context.Database;
            Item dataHolder = database.GetItem(parentGuidValue);

            //build list of children Guids from parentGuid - Not sure if it's working or not.
            //List<ID> templateList = dataHolder.Children.Where(x => x.TemplateID.ToString() == parentGuidValue).Select(i => i.ID).ToList();

            //pass parent guid from config file to view
            ViewBag.parentGuid = parentGuidValue;

            //pass templateID from parent Guid to view
            ViewBag.templateID = dataHolder.TemplateID;

            //pass children list from parent Guid to view
            ViewBag.tempList = dataHolder.Children;

            //pass item headline from current itemID to view
            //ViewBag.itemHeadline = dataHolder.Fields["Headline"];

            return View(model);
        }
    }
}