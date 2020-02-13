using System;

namespace BankingLibrary {
    public class Account {

        private static int NextAcctNbr = 1;
        private const int AcctNbrInc = 9;

        public decimal Balance { get; set; }
        public string Description { get; set; } = "Account";
        public int AcctNbr { get; private set; }

        private int AttemptsToOverdraw = 0;
        
        private bool IsCheckAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true;
        }

        private bool IsSufficientFunds(decimal amount) {
            if(Balance >= amount) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }
        
        public void Deposit(decimal amount) {
            if (IsCheckAmountGTZero(amount)) {
            Balance += amount;            
            }
        }
        
        public bool Withdraw(decimal amount) {
            if (IsCheckAmountGTZero(amount) && IsSufficientFunds(amount)) {
                Balance -= amount;
                return true;
            }
            return false;
        }
        
        public void Transfer(decimal amount, Account toAccount) {
            if (this.Withdraw(amount)) {
                toAccount.Deposit(amount);
            }
        }

        public override string ToString() {
            return $"AcctNbr = {AcctNbr}, Desc = {Description}, Bal = {Balance}";
        }

        public void Debug() {
            Console.WriteLine(this);
        }

        public Account() {
            this.AcctNbr = NextAcctNbr;
            NextAcctNbr += AcctNbrInc;
        }
    }
}