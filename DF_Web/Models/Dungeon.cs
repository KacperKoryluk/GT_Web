using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DF_Web.Models
{
    public class Dungeon
    {
        private List<string> PathList;
        private string Name;
        Random rnd;
    
        public Dungeon(List<string> _pathList, string _name, Random _rnd)
        {
            rnd = _rnd;
            PathList = _pathList;
            Name = _name;
        }

        public List<string> GetPathList ()
        {
            return PathList;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetRandomPath()
        {
           
            return PathList.ElementAt(rnd.Next(PathList.Count));
        }
    }
}