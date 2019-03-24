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
        [Route("Dungeons/RandomList/{size:regex(\\d{1}):range(1, 7)}")]
        public ActionResult Random(int size)
        {
            Random rnd = new System.Random();
            DungeonList DList = new DungeonList(rnd, size);
            
            return View(DList);
        }
    }
}