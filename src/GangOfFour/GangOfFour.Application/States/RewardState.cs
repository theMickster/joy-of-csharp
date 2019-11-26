using System;
using System.Reflection;

namespace GangOfFour.Application.States
{
    public abstract class RewardState
    {
        protected RewardAccount _rewardAccount;

        protected int _pointsBalance;

        protected int LowerPointLimit;

        protected int UpperPointLimit;

        public RewardAccount RewardAccount
        {
            get => _rewardAccount;
            set => _rewardAccount = value;
        }

        public int PointsBalance
        {
            get => _pointsBalance;
            set => _pointsBalance = value;
        }

        protected internal void DepositPoints(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Invalid deposit amount. Deposit amount must be greater than 0.");

            PointsBalance += amount;

            StateChangeCheck();
        }

        protected internal void WithdrawPoints(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Invalid withdraw amount. Withdraw amount must be greater than 0.");

            PointsBalance -= amount;
            StateChangeCheck();
        }

        public abstract void StateChangeCheck();


    }
}