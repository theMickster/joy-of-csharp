using System;

namespace GangOfFour.Application.States
{
    public class GoldRewardState : RewardState
    {
        public GoldRewardState(RewardState state) : this(state.PointsBalance, state.RewardAccount)
        {

        }

        public GoldRewardState(int balance, RewardAccount rewardAccount)
        {
            PointsBalance = balance;
            RewardAccount = rewardAccount;
            Initialize();
            StateChangeCheck();
        }

        private void Initialize()
        {
            // In a real scenario, these would come from an external database.
            LowerPointLimit = 1000;
            UpperPointLimit = 5000;
        }

        public sealed override void StateChangeCheck()
        {
            if (PointsBalance >= UpperPointLimit)
            {
                RewardAccount.RewardsState = new PlatinumRewardState(this);
            }
            else if (PointsBalance < LowerPointLimit)
            {
                RewardAccount.RewardsState = new SilverRewardState(this);   
            }
        }
    }
}