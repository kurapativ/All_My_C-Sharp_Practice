using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Basic_Checking:IChecking
    {
        int Account_num;
        string Account_name;
        double balance;

        public Basic_Checking(int acc_num, string acc_name, double bal)
        {
            Account_num = acc_num;
            Account_name = acc_name;
            balance = bal;
           
            Console.WriteLine("Account Number:"+ acc_num);
            Console.WriteLine("Account Name:"+acc_name);
            Console.WriteLine("Initial Balance:"+ bal);

        }

        public void deposit()
        {
           
            double deposit_amt;
            Console.WriteLine("Enter the amount to be deposited");
            deposit_amt = Convert.ToDouble(Console.ReadLine());
            
            balance = balance + deposit_amt;
            
            Console.WriteLine( "Amount after deposit is " + balance);
        }

        public void withdrawl()
        {
            double withdrawl_amt;
            Console.WriteLine("Enter the withdrawl amount");
            withdrawl_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance - withdrawl_amt;
            if (balance < -1)
            {
                throw new Exception("Cannot process this withdrawl transaction as this results in neagtive balance");
            }

            Console.WriteLine("Amount after withdrawal is"+ balance); ;
        }

        public void PostInterestAndCredits()
        {
            Console.WriteLine("Basic Checking Account");
            Console.WriteLine("No credits are there for this account as this is a basic one");
            Deductfees();
            
        }

        public void Deductfees()
        {
            Console.WriteLine("As this is basic account ,there are deduct fees");
            if(balance<500)
            balance = balance - 5;
            Console.WriteLine("Balance after the deduction fees is "+ balance);
            
        }

        
    }
}
