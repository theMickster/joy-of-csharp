namespace GangOfFour.Application.States
{
    public class DiamondRewardState : RewardState
    {
        public DiamondRewardState(RewardState state) : this(state.PointsBalance, state.RewardAccount)
        {

        }

        public DiamondRewardState(int balance, RewardAccount rewardAccount)
        {
            PointsBalance = balance;
            RewardAccount = rewardAccount;
            Initialize();
            StateChangeCheck();
        }

        private void Initialize()
        {
            // In a real scenario, these would come from an external database.
            LowerPointLimit = 10000;
            UpperPointLimit = 1000000;
        }

        public sealed override void StateChangeCheck()
        {
            if (PointsBalance < LowerPointLimit)
            {
                RewardAccount.RewardsState = new PlatinumRewardState(this);
            }
        }
    }
}