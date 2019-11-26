using System;

namespace GangOfFour.Application.States
{
    /// <summary>
    /// The 'Context' class in the state design pattern.
    /// </summary>
    public class RewardAccount
    {
        private readonly string _accountOwner;

        private RewardState _rewardState;

        public RewardAccount(string accountOwner)
        {
            _accountOwner = accountOwner;
            _rewardState = new SilverRewardState(0, this);
        }

        public int PointsBalance => _rewardState.PointsBalance;

        public RewardState RewardsState
        {
            get => _rewardState;
            set => _rewardState = value;
        }

        public void DepositPoints(int amount)
        {
            _rewardState.DepositPoints(amount);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Deposit  {amount} points  .... Point Balance {this.PointsBalance} .... Reward Status {this.RewardsState.GetType().Name}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WithdrawPoints(int amount)
        {
            _rewardState.WithdrawPoints(amount);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Withdraw {amount} points  .... Point Balance {this.PointsBalance} .... Reward Status {this.RewardsState.GetType().Name}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}