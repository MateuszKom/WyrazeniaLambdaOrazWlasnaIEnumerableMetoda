using System;
using System.Collections.Generic;
using System.Linq;

namespace VsGaam
{
    class Program
    {
        static void Main(string[] args)
        {
            //SearchEngine();
            SuggestEngine();
        }

        static void SearchEngine()
        {
            var rpggames = RolePlayingGamesList.LoadSampleData();

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
            var sugGames = RolePlayingGamesList.LoadSampleData();

            sugGames = sugGames
                .NameByYear()
                //.Where(Filter)
                .ToList();

            foreach (var game in sugGames)
            {
                Console.WriteLine($"{game.Name} - { game.Audio} - { game.Performance}");
            }
        }

        public static bool Filter(RolePlayingGame rpg) => rpg.Audio >= 8 && rpg.Performance >= 8;
    }

    public static class LinqExtensions
    {
        public static IOrderedEnumerable<T> NameByYear<T>(this IEnumerable<T> t) where T : RolePlayingGame
        {
            return t.OrderBy(a => a.Name);
        }
    }
}
