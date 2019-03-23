using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DF_Web.Models;

namespace DF_Web.Controllers
{
    public class DungeonListController : Controller
    {
        // GET: DungeonList/Random
        public ActionResult Random()
        {
            Random rnd = new System.Random();
            DungeonList DList = new DungeonList(rnd);
            
            return View(DList);
        }
    }
}