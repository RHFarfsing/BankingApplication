using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class Checking {

        private InterestAccount iacct;
        public int CheckNbr { get; private set; }

        public void Deposit(decimal amount) {
            iacct.Deposit(amount);
        }
        public bool Withdraw(decimal amount) {
            CheckNbr++;
            return iacct.Withdraw(amount);
        }
        public void Transfer(decimal amount, Account ToAccount) {
            iacct.Transfer(amount, ToAccount);
        }
        public void Transfer(decimal amount, Checking ToAccount) {
            iacct.Transfer(amount, ToAccount.iacct);
        }
        public Checking(double intRate) {
            iacct = new InterestAccount(intRate);
            iacct.Description = "Checking";
        }
        public Checking() : this(0.02) {
            
        }
    }
}