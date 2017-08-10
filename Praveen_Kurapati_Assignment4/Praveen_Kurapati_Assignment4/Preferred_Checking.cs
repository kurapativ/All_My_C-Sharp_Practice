using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praveen_Kurapati_Assignment4
{
   
    class Preferred_Checking : IChecking
    {
        int Account_num;
        string Account_name;
        double balance;

        public Preferred_Checking(int acct_num, string acct_name, double bal)
        {
            Account_num = acct_num;
            Account_name = acct_name;
            balance = bal;

            Console.WriteLine("Account Number:" + acct_num);
            Console.WriteLine("Account Name:" + acct_name);
            Console.WriteLine("Initial Balance:" + bal);
            Console.WriteLine(".................................................................................................");

        }

        public void deposit()
        {
            double dpst_amt;
            Console.WriteLine("Enter the amount to be deposited into Preferred Checking Account");
            dpst_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance + dpst_amt;
            Console.WriteLine("Total Amount after deposit is " + balance);
            Console.WriteLine(".................................................................................................");

        }

        public void withdrawl()
        {
            double withdrawl_amt;
            Console.WriteLine("Enter the amount to be withdrawn from  the Preferred Checking Account ");
            withdrawl_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance - withdrawl_amt;

            if (balance < -1)
            {
                throw new Exception("Cannot process this withdrawl transaction as this results in negative balance");
            }

            Console.WriteLine("Total Amount after withdrawal from Preferred Checkings Account:" + balance);
            Console.WriteLine(".................................................................................................");

        }

        public void PostInterestAndCredits()
        {
            Console.WriteLine("Preferred Checking Account");
            Console.WriteLine("Interest per year is 2% for Preferred Checkings Account");
            double interest = balance * 0.167 / 100;
            Console.WriteLine("Interest for the Preferred Checking Account", interest);
            balance = balance + interest;
            Console.WriteLine("Total Preferred Checking Account Balance after the added interest : " + balance);
            Deductionfees();
            Console.WriteLine(".................................................................................................");


        }

        public void Deductionfees()
        {
            Console.WriteLine("there is a 2 dollar deduct fee for Preferred Checking Account");
            balance = balance - 2;
            Console.WriteLine("Balance after the deduction fees is " + balance);

        }
    }
}
