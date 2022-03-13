using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsGaam
{
    public class RolePlayingGames : Game
    {
        public string Genre { get; set; }
        public int Narrative { get; set; }
        public int RPGElements { get; set; }
        public int Art { get; set; }
        public RolePlayingGames(string name = "No name",
            string publisher = "No data",
            string developer = "No data",
            string category = "No data",
            string genre = "No data",
            int music = 0,
            int audio = 0,
            int performance = 0,
            int visuals = 0,
            int narrative = 0,
            int rpgelements = 0,
            int art = 0,
            string ismultiplayermode = "No")
        {
            Name = name;
            Publisher = publisher;
            Developer = developer;
            Category = category;
            Genre = genre;
            Music = music;
            Audio = audio;
            Performance = performance;
            Visuals = visuals;
            Narrative = narrative;
            RPGElements = rpgelements;
            Art = art;
            IsMultiPlayerMode = ismultiplayermode;
        }

    }
}
