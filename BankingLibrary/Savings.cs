using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class Savings : InterestAccount{
        private void setDescription(string description) {
            this.Description = description;
        }
        public Savings(double interestRate) : base(interestRate) {
            setDescription("Savings"); 
        }
        public Savings() : base(){
            setDescription("Savings");
        }
    }
}
