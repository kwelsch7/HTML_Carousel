using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HTML_Carousel.Models;

namespace HTML_Carousel.Controllers
{
    public class TagsController : Controller
    {
        private TagList _tagList = new TagList();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult a()
        {
            return View();
        }
    }
}
