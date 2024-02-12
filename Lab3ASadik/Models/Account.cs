using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3ASadik.Models
{
    public class Account
    {
        public string Surname { get; set; }
        public int AccountNumber { get; set; }
        public double AccrualCent {  get; set; }

        public double Balance { get; set; }

        private Date OpeningDate { get; set; }

        public Account(string surname, int accountNumber, double accrualCent, double balance, Date openingDate)
        {
            Surname = surname;
            AccountNumber = accountNumber;
            AccrualCent = accrualCent;
            Balance = balance;
            OpeningDate = openingDate;
        }

        public void CalculateAndAddInterest()
        {
            int daysSinceOpening = Date.DaysBetween(OpeningDate, Date.Today());
            double additionalInterestRate = 0.0001 * daysSinceOpening;
            AccrualCent += additionalInterestRate;
        }

        public void ChangeOwner(string newOwnerLastName)
        {
            Surname = newOwnerLastName;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void AccrueInterest()
        {
            double interestAmount = Balance * AccrualCent / 100;
            Balance += interestAmount;
        }

        public double ConvertToDollars(double exchangeRate)
        {
            return Balance / exchangeRate;
        }

        public double ConvertToEuros(double exchangeRate)
        {
            return Balance / exchangeRate;
        }

        public override string? ToString()
        {
            return Balance.ToString();
        }


    }
}
