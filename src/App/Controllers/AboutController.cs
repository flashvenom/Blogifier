using Core.Data;
using Core.Data.Models;
using Core.Helpers;
using Core.Services;
using Markdig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace App.Controllers
{
    public class AboutController : Controller
    {
        IDataService _db;
        IFeedService _ss;
        SignInManager<AppUser> _sm;
        private readonly ICompositeViewEngine _viewEngine;
        static readonly string _listView = "~/Views/Themes/{0}/List.cshtml";

        public AboutController(IDataService db, IFeedService ss, SignInManager<AppUser> sm, ICompositeViewEngine viewEngine)
        {
            _db = db;
            _ss = ss;
            _sm = sm;
            _viewEngine = viewEngine;
        }

        public async Task<IActionResult> Index()
        {
            var blog = await _db.CustomFields.GetBlogSettings();
            var model = new AboutPage();
            model.Blog = blog;
            model.Title = "About Metro Insurance Services";
            return View(model);
        }   
    }
}