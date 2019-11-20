using GangOfFour.Core.Interfaces.MonsterGame;

namespace GangOfFour.Core.Entities.MonsterGame
{
    public class MonsterHunter : IMonsterHunter, IMonsterHuntingQuest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int GoldTokens { get; set; }
        
        public string ShowStats()
        {
            return $"{FirstName} {LastName} has accumulated {GoldTokens} gold tokens from hunting monsters!";
        }
    }
}