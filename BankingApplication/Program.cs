using BankingLibrary;
using System;


namespace BankingApplication {
    class Program {
        static void Main(string[] args) {
            var chk = new Account();
            chk.Deposit(100);
            chk.Withdraw(75);
        }
    }
}