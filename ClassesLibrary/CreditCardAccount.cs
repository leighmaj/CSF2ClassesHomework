using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        public CreditCardAccount()
        {

        }

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public override string ToString()
        {
            return string.Format("\n===== CREDIT CARD ACCOUNT =====\n\nAccount Number: {0}\nCustomer Info: {1}\nBalance: {2}\n" +
                "Payment: {3}\nAnnual Interest Rate: {4}\n",
                AccountNumber,
                CustomerInfo,
                Balance,
                IsPastDue ? "is past due" : "is not past due",
                AnnualInterestRate);
        }
    }
}
