/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP09 EX01
** Date: 2021 - 12 - 05
** Description: Create accounts classes and pass variable to the child classes
** Including Creating a child class from a child class
**
********/

using static System.Console;

namespace Inheritance_EX01
{
    class Program
    {
        public static void Main()
        {
            const decimal OPENING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;

            // Create and use Savings object.
            Savings savings = new Savings(OPENING_BALANCE);
            savings.AddMonthlyInterest(MONTHLY_INTEREST);
            savings.ShowBalance();
                        
            // Create and use Checking object.
            Checking checking = new Checking(OPENING_BALANCE);
            checking.DeductServiceCharge();
            checking.ShowBalance();

            JointSavings jointSavings = new JointSavings("George", "Jane", OPENING_BALANCE);
            jointSavings.AddMonthlyInterest(MONTHLY_INTEREST);
            jointSavings.ShowBalance();
            ReadLine();
        }
    }

    class Account
    {
        // Base class - Account
        protected decimal BankBalance { set; get; }

        protected Account()
        {
            WriteLine();
            WriteLine("Inside the Account constructor.");
        }

        public void ShowBalance()
        {
            WriteLine("The balance is " +
                              BankBalance.ToString("C"));
        }
    }

    class Savings : Account
    {
        // Derived class - Savings
        public Savings(decimal balance)
        {
            WriteLine("Inside the Savings constructor.");
            BankBalance = balance;
        }

        public Savings()
        {
            WriteLine("Inside the default Savings constructor.");
        }

        // Custom child method.
        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }
    }

    class Checking : Account
    {
        // Derived class – Checking
        public Checking(decimal balance)
        {
            WriteLine("Inside the Checking constructor.");
            BankBalance = balance;
        }

        // Custom child method.
        public void DeductServiceCharge()
        {
            const decimal CHECKING_FEE = 1.50m;
            BankBalance -= CHECKING_FEE;
        }
    }

    class JointSavings : Savings
    {
        public string FirstNameA { get; set; }
        public string FirstNameB { get; set; }

        public JointSavings(string firstNameA, string firstNameB, decimal balance)
        {
            WriteLine("Inside the JointSavings constructor.");
            FirstNameA = firstNameA;
            FirstNameB = firstNameB;
            WriteLine("The account owners are: " + FirstNameA + " and " + FirstNameB);
            BankBalance = balance;
        }

        public void ShowOwners()
        {
            FirstNameA = "George";
            FirstNameB = "Jane";
        }
    }
}