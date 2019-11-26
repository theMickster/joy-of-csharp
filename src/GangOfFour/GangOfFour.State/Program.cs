using System;
using GangOfFour.Application.States;

namespace GangOfFour.State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - State");

            var myRewardAccount = new RewardAccount("Mick");

            Console.WriteLine(myRewardAccount.PointsBalance);

            // Apply rewards for air travel.
            myRewardAccount.DepositPoints(750);
            myRewardAccount.DepositPoints(200);
            myRewardAccount.DepositPoints(50);
            myRewardAccount.DepositPoints(4000);
            myRewardAccount.WithdrawPoints(3000);
            myRewardAccount.DepositPoints(7999);
            myRewardAccount.DepositPoints(1);
            myRewardAccount.WithdrawPoints(3000);
            myRewardAccount.DepositPoints(5000);


        }
    }
}
