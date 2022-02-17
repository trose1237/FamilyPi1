using FamilyPi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyPi.Controllers
{
    public class TipController : Controller
    {
        static private List<Tip> Tips = new List<Tip>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        //public IActionResult NewTip(string name, string description)
        //{
          //  Tip.Add(new Tip(name, description)); 
        //}


    }
}
