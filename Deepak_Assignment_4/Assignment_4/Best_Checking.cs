using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Best_Checking: IChecking
    {
        int Account_num;
        string Account_name;
        double balance;

        public Best_Checking(int acc_num,string acc_name,double bal)
        {
            Account_num = acc_num;
            Account_name = acc_name;
            balance = bal;

            Console.WriteLine("Account Number:" + acc_num);
            Console.WriteLine("Account Name:" + acc_name);
            Console.WriteLine("Initial Balance:" + bal);
        }

      public void deposit()
        {
            double deposit_amt;
            Console.WriteLine("Enter the amount to be deposited");
            deposit_amt = Convert.ToDouble(Console.ReadLine());
            balance = balance + deposit_amt;
            Console.WriteLine("Amount after deposit is"+ balance);
        }

        public void withdrawl()
        {
            double withdrawl_amt;
            Console.WriteLine("Enter the amount to be withdrawn");
            withdrawl_amt = Convert.ToDouble(Console.ReadLine());
            
            balance = balance - withdrawl_amt;
            if (balance < -1)
            {
                throw new Exception("Cannot process this withdrawl transaction as this results in neagtive balance");
            }

            Console.WriteLine("Amount after withdrawal is"+ balance);
        }

        public void PostInterestAndCredits()
        {
            Console.WriteLine("Best Checking Account");
            Console.WriteLine("Interest per year is 3% for this Account");
            double interest = balance * 0.25 / 100;
            Console.WriteLine("Ineterest is", interest);
            balance = balance + interest;
            Console.WriteLine("Balance after the added interest is "+ balance);
            Deductfees();
        }

        public void Deductfees()
        {
            Console.WriteLine("No Deduction fees as you got best credit history");
        }

        
    }
}
