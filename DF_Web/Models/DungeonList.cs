using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DF_Web.Models
{
    public class DungeonList
    {
        private List<Dungeon> ContentList;
        private Dungeon Arah;
        Random rnd;

        public DungeonList(Random _rnd)
        {
            rnd = _rnd;
            ContentList = new List<Dungeon>();
        
            ContentList.Add(new Dungeon(new List<string>() { "Path 1 - Hodgins", "Path 2 - Detha", "Path 3 - Tzark" }, "Ascalonian Catacombs", _rnd));
            ContentList.Add(new Dungeon(new List<string>() { "Path 1 - Asura", "Path 2 - Seraph", "Path 3 - Butler" }, "Caudecus\' Manor", _rnd));
            ContentList.Add(new Dungeon(new List<string>() { "Path 1 - Forward", "Path 2 - Up", "Path 3 - Aetherpath" }, "Twilight Arbor", _rnd));
            ContentList.Add(new Dungeon(new List<string>() { "Path 1 - Fergg", "Path 2 - Rasolov", "Path 3 - Koptev" }, "Sorrow\'s Embrace", _rnd));
            ContentList.Add(new Dungeon(new List<string>() { "Path 1 - Ferrah", "Path 2 - Magg", "Path 3 - Rhiannon" }, "Citdel of Flame", _rnd));
            ContentList.Add(new Dungeon(new List<string>() { "Path 1 - Butcher", "Path 2 - Plunderer", "Path 3 - Zealot" }, "Honor of the Waves", _rnd));
            ContentList.Add(new Dungeon(new List<string>() { "Path 1 - Submarine", "Path 2 - Teleporter", "Path 3 - Front Door" }, "Crucible of Eternity", _rnd));
            Arah = new Dungeon(new List<string>() { "Path 1 - Jotun", "Path 2 - Mursaat", "Path 3 - Forgotten", "Path 4 - Seer" }, "The Ruined City of Arah", _rnd);
        }

        public Dungeon GetRandomDungeon()
        {
            return ContentList.ElementAt(rnd.Next(ContentList.Count));
        }

        public List<Dungeon> GetRandomDungeonList(int size)
        {
            if (size > 0 && size < ContentList.Count)
            {
                HashSet<Dungeon> DSet = new HashSet<Dungeon>();
                
                while (DSet.Count < size)
                {
                    DSet.Add(ContentList.ElementAt(rnd.Next(ContentList.Count)));
                }

                return DSet.ToList();
            }
         
            return ContentList;
        }

        public Dungeon GetArah()
        {
            return Arah;
        }
        /*
        public string FinalList(int size)
        {
            List<Dungeon> RandomList = GetRandomDungeonList(size);
            string BonusPath = Arah.GetRandomPath();

            StringBuilder result = new StringBuilder();
            
            foreach(Dungeon d in RandomList)
            {
                result.Append(d.GetName() + "\n");
                result.Append(d.GetRandomPath() + "\n");
            }
            result.Append(BonusPath + "\n");

            return result.ToString();

        }
        */
    }
}