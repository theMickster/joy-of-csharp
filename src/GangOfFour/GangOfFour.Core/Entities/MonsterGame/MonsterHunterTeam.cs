using System;
using System.Collections.Generic;
using System.Linq;
using GangOfFour.Core.Interfaces.MonsterGame;

namespace GangOfFour.Core.Entities.MonsterGame
{
    public class MonsterHunterTeam : IMonsterHunterTeam, IMonsterHuntingQuest
    {
        public string GroupName { get; set; }

        public List<IMonsterHuntingQuest> MonsterHunters { get; set; } = new List<IMonsterHuntingQuest>();

        public int GoldTokens
        {
            get
            {
                return MonsterHunters.Sum(monsterHunter => monsterHunter.GoldTokens);
            }
            set
            {
                var goldTokensPerHunter = value / MonsterHunters.Count;
                var leftoverGoldTokens = value % MonsterHunters.Count;

                foreach (var monsterHunter in MonsterHunters)
                {
                    monsterHunter.GoldTokens += goldTokensPerHunter + leftoverGoldTokens;
                    leftoverGoldTokens = 0;
                }
            }
        }

        public MonsterHunterTeam()
        {
        }

        public string ShowMemberStats()
        {
            return MonsterHunters.Aggregate
                (string.Empty, (current, monsterHunter) => current + (monsterHunter.ShowStats() + Environment.NewLine));
        }

        public string ShowStats()
        {
            return ShowMemberStats();
        }

    }
}