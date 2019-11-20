using System;
using GangOfFour.Core.Entities.MonsterGame;

namespace GangOfFour.Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Composite");

            // Creating leaf nodes in the tree
            var ally = new MonsterHunter {FirstName = "Ally", LastName = "Jones"};
            var cory = new MonsterHunter {FirstName = "Cory", LastName = "Olsen"};
            var gluck = new MonsterHunter {FirstName = "Jen", LastName = "Gluck"};
            var janet = new MonsterHunter {FirstName = "Janet", LastName = "Smith"};
            var jennifer = new MonsterHunter {FirstName = "Jen", LastName = "Parker"};
            var john = new MonsterHunter {FirstName = "John", LastName = "Olsen"};
            var matt = new MonsterHunter {FirstName = "Matt", LastName = "Parker"};
            var pete = new MonsterHunter {FirstName = "Pete", LastName = "Olsen"};

            // Creating groups or branches in the tree
            var parkers = new MonsterHunterTeam {GroupName = "The Parkers", MonsterHunters = {jennifer, matt}};
            var olsenGang = new MonsterHunterTeam {GroupName = "Gaggle of Geese", MonsterHunters = {cory, john, pete, parkers}};

            // Creating root composed of leaves and branch nodes
            var teamA = new MonsterHunterTeam {GroupName = "Team A", MonsterHunters = {olsenGang, ally, gluck, janet}};

            teamA.GoldTokens = 1023;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(teamA.ShowStats());

            Console.ReadKey();

        }
    }
}
