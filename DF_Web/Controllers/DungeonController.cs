using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DF_Web.Models;

namespace DF_Web.Controllers
{
    public class DungeonController : Controller
    {
        // GET: Dungeon/Random
        public ActionResult Random()
        {
            Random rnd = new System.Random();
            DungeonList DungeonList = new DungeonList(rnd);
            
            return View(DungeonList.GetRandomDungeon());
        }
    }
}