using System;
using System.Collections.Generic;
using System.Linq;

namespace VsGaam
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEngine();
            SuggestEngine();
        }

        static void SearchEngine()
        {
            List<RolePlayingGames> rpggames = RolePlayingGamesList.LoadSampleData();

            rpggames = rpggames.OrderBy(n => n.Name).ToList();
            rpggames = rpggames.Where(n => n.Audio <= 8).ToList();

            foreach (var game in rpggames)
            {
                Console.WriteLine($"{game.Name} - {game.Developer} - {game.Audio}");
            }
            Console.WriteLine("\n");
        }
        static void SuggestEngine()
        {
            List<RolePlayingGames> sugGames = RolePlayingGamesList.LoadSampleData();

            sugGames = sugGames
                .Where(g => g.Audio >= 8 && g.Performance >= 8).ToList()
                .OrderBy(g => g.Name).ToList()
                .Take(2).ToList();

            foreach (var game in sugGames)
            {
                Console.WriteLine($"{game.Name} - { game.Audio} - { game.Performance}");
            }
        }
    }
}
