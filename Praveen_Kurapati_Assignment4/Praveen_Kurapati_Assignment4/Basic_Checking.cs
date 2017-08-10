using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praveen_Kurapati_Assignment4
{
    class Basic_Checking : IChecking
    {

        int Account_num;
        string Account_name;
        double balance;

        public Basic_Checking(int acct_no, string acct_name, double bal)
        {
            Account_num = acct_no;
            Account_name = acct_name;
            balance = bal;

            Console.WriteLine("Basic Checkings Account Number:" + acct_no);
            Console.WriteLine("Basic Checkings Account Name:" + acct_name);
            Console.WriteLine("Initial Balance in Basic Checkings Account:" + bal);
            Console.WriteLine(".................................................................................................");



        }

        public void deposit()
        {

            double dpst_amt;
            Console.WriteLine("Enter the amount to be deposited into Basic Checking Account");
            dpst_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance + dpst_amt;

            Console.WriteLine("Total Amount after deposit is " + balance);
            Console.WriteLine(".................................................................................................");

        }

        public void withdrawl()
        {
            double withdrawl_amt;
            Console.WriteLine("Enter the amount to be withdrawn from  the Basic Checking Account ");
            withdrawl_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance - withdrawl_amt;
            if (balance < -1)
            {
                throw new Exception("Cannot process this withdrawl transaction as this results in negative balance");
            }

            Console.WriteLine("Total Amount after withdrawal from Basic Checkings Account:" + balance);
            Console.WriteLine(".................................................................................................");

        }

        public void PostInterestAndCredits()
        {
            Console.WriteLine("Basic Checking Account");
            Console.WriteLine("No credits for Basic Checkings Account");
            Deductionfees();
            Console.WriteLine(".................................................................................................");


        }

        public void Deductionfees()
        {
            Console.WriteLine("As this is a Basic Checkings Account ,there are no deduction fees");
            if (balance < 500)
                balance = balance - 5;
            Console.WriteLine("Total Balance after the deducting credit fees : " + balance);

        }


    }
}
