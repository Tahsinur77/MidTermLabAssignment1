using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(int accountNumber,string accountName,double balance,Address address)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.address = address;

        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address= value; }
            get { return this.address; }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("\t\t||\tPrevious Balance : {0}\n\t\t||\tWithdraw Amount: {1}", balance, amount);
                this.balance -= amount;
                Console.WriteLine("\t\t||\tCurrent Balance: " + this.balance);
            }
            else Console.WriteLine("\t\t||\tCan Not Withdraw.....");
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("\t\t||\tPrevious Balance : {0}\n\t\t||\tDeposit Amount: {1}", balance, amount);
                this.balance += amount;
                Console.WriteLine("\t\t||\tCurrent Balance: " + this.balance);
            }
            else Console.WriteLine("\t\t||\tCan Not Deposit......");
        }
        public void Transfer(Account receiver,double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("\t\t||\tPrevious Balance : {0}\n\t\t||\tTransfer Amount: {1}", balance, amount);
                this.balance -= amount;
                receiver.balance += amount;
                Console.WriteLine("\t\t||\tCurrent Balance: " + this.balance);
            }
            else Console.WriteLine("\t\t||\tCan Not Transfer.....");
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("\t\t||\tAccount Number : {0}\n\t\t||\tAccount Name: {1}\n\t\t||\tBalance : {2}", this.accountNumber, this.accountName, this.balance);
            Console.WriteLine(address.GetAddress());
        }
    }
}
