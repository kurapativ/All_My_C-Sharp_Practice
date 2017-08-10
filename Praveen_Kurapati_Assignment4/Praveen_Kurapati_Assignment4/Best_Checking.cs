using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praveen_Kurapati_Assignment4
{
    class Best_Checking
    {
        int Account_num;
        string Account_name;
        double balance;

        public Best_Checking(int acct_num, string acct_name, double bal)
        {
            Account_num = acct_num;
            Account_name = acct_name;
            balance = bal;

            Console.WriteLine("Account Number:" + acct_num);
            Console.WriteLine("Account Name:" + acct_name);
            Console.WriteLine("Initial Balance:" + bal);
        }

        public void deposit()
        {
            double dpst_amt;
            Console.WriteLine("Enter the amount to be deposited into Best Checking Account");
            dpst_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance + dpst_amt;
            Console.WriteLine("Total Amount after deposit is " + balance);
            Console.WriteLine(".................................................................................................");

        }

        public void withdrawl()
        {
            double withdrawl_amt;
            Console.WriteLine("Enter the amount to be withdrawn from  the Best Checking Account ");
            withdrawl_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance - withdrawl_amt;
            if (balance < -1)
            {
                throw new Exception("Cannot process this withdrawl transaction as this results in negative balance");
            }

            Console.WriteLine("Total Amount after withdrawal from Best Checkings Account:" + balance);
            Console.WriteLine(".................................................................................................");

        }

        public void PostInterestAndCredits()
        {
            Console.WriteLine("Best Checking Account");
            Console.WriteLine("Interest per year is 3% for Preferred Checkings Account");
            double interest = balance * 0.25 / 100;
            Console.WriteLine("Interest for the Best Checking Account", interest);
            balance = balance + interest;
            Console.WriteLine("Total Best Checking Account Balance after the added interest : " + balance);
            Deductionfees();
            Console.WriteLine(".................................................................................................");

        }

        public void Deductionfees()
        {
            Console.WriteLine("No Deduction fees as you got best credit history");
        }


    }
}
