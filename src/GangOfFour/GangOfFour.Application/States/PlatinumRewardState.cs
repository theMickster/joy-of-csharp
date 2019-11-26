using System;
using System.Drawing;

namespace GangOfFour.Application.States
{
    public class PlatinumRewardState : RewardState
    {
        public PlatinumRewardState(RewardState state) : this(state.PointsBalance, state.RewardAccount)
        {

        }

        public PlatinumRewardState(int balance, RewardAccount rewardAccount)
        {
            PointsBalance = balance;
            RewardAccount = rewardAccount;
            Initialize();
            StateChangeCheck();
        }

        private void Initialize()
        {
            // In a real scenario, these would come from an external database.
            LowerPointLimit = 5000;
            UpperPointLimit = 10000;
        }

        public sealed override void StateChangeCheck()
        {
            if (PointsBalance >= UpperPointLimit)
            {
                RewardAccount.RewardsState = new DiamondRewardState(this);
            }
            else if (PointsBalance < LowerPointLimit)
            {
                RewardAccount.RewardsState = new GoldRewardState(this);
            }
        }
    }
}