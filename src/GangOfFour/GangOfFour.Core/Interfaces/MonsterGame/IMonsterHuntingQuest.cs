namespace GangOfFour.Core.Interfaces.MonsterGame
{
    public interface IMonsterHuntingQuest
    {
        int GoldTokens { get; set; }

        string ShowStats();
    }
}