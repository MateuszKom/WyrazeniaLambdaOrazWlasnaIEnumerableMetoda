using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsGaam
{
    class RolePlayingGamesList
    {
        public static IEnumerable<RolePlayingGames> LoadSampleData()
        {
            List <RolePlayingGames> output = new List<RolePlayingGames>();

            output.Add(new RolePlayingGames { Name = "Witcher 3: Wild Hunt", Publisher = "CD Projekt", Developer = "CD Projekt Red", Category = "Role Playing Game", Genre = "Action RPG", Music = 10, Audio = 10, Performance = 10, Visuals = 10, Narrative = 10, RPGElements = 10, Art = 10, IsMultiPlayerMode = "No" });
            output.Add(new RolePlayingGames { Name = "Assassin Creed: Odyssey", Publisher = "Ubisoft", Developer = "Ubisoft Quebec", Category = "Role Playing Game", Genre = "Action RPG", Music = 7, Audio = 8, Performance = 7, Visuals = 9, Narrative = 7, RPGElements = 9, Art = 8, IsMultiPlayerMode = "No" });
            output.Add(new RolePlayingGames { Name = "Assassi Creed: Valhalla", Publisher = "Ubisoft", Developer = "Ubisoft Montreal", Category = "Role Playing Game", Genre = "Action RPG", Music = 6, Audio = 7, Performance = 6, Visuals = 9, Narrative = 7, RPGElements = 9, Art = 8, IsMultiPlayerMode = "No" });
            output.Add(new RolePlayingGames { Name = "God of War 2018", Publisher = "Sony Interactive Entertainment", Developer = "Santa Monica Studio", Category = "Role Playing Game", Genre = "Action Adventure, Hack'n'slash", Music = 8, Audio = 8, Performance = 10, Visuals = 10, Narrative = 10, RPGElements = 7, Art = 10, IsMultiPlayerMode = "No" });
            output.Add(new RolePlayingGames { Name = "Baldur's Gate III", Publisher = "Larian Stuidos", Developer = "Larian Studios", Category = "Role Playing Game", Genre = "RPG", Music = 6, Audio = 6, Performance = 8, Visuals = 8, Narrative = 9, RPGElements = 10, Art = 8, IsMultiPlayerMode = "Yes" });

            return output;
        }
    }
}
