using System;

namespace GangOfFour.Application.States
{
    public class SilverRewardState : RewardState
    {
        public SilverRewardState(RewardState state) : this(state.PointsBalance, state.RewardAccount)
        {

        }

        public SilverRewardState(int balance, RewardAccount rewardAccount)
        {
            this.PointsBalance = balance;
            this.RewardAccount = rewardAccount;
            Initialize();
            StateChangeCheck();
        }

        private void Initialize()
        {
            // In a real scenario, these would come from an external database.
            LowerPointLimit = 0;
            UpperPointLimit = 1000;
        }

        public sealed override void StateChangeCheck()
        {
            if (PointsBalance >= UpperPointLimit)
            {
                RewardAccount.RewardsState = new GoldRewardState(this);
            }
        }
    }
}