using BankingLibrary;
using System;
using System.Collections.Generic;

namespace BankingApplication {
    class Program {
        static void Main(string[] args) {
            var sav1 = new Savings(0.01);
            //sav1.Debug();

            var int1 = new InterestAccount(0.06);
            int1.Deposit(100);
            int1.CalculateInterest(3); ;
            //int1.Debug();

            var chk1 = new Checking();
            chk1.Deposit(100);
            chk1.Withdraw(75);
            chk1.Deposit(-10);
            chk1.Withdraw(1000);
            chk1.Deposit(0);
            chk1.Withdraw(100);

            var chk2 = new Checking();
            chk2.Deposit(200);
            chk2.Withdraw(40);

            //chk1.Debug();
            //chk2.Debug();
            chk2.Transfer(100, chk1);
            //chk1.Debug();
            //chk2.Debug();

            var accounts = new List<Account>();
            accounts.Add(sav1);

            foreach(var account in accounts) {
                Console.WriteLine(account);
            }

        }
    }
}