using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praveen_Kurapati_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to different Checking Accounts Management system");
            Console.WriteLine(".................................................................................................");

            // 1. Basic Checking Account Implementation

            Console.WriteLine("1.Basic Checking Accounts");
            Console.WriteLine("...................................................");

            Basic_Checking bc = new Basic_Checking(0001, "Daniel_Basic", 500.0);

            Console.WriteLine("Implementing all the transactions for the Basic Checkings account ");

            bc.deposit(); //Deposit Transaction

            bc.withdrawl(); //Withdrwal Transaction

            Console.WriteLine("Pressuming its end of month");

            bc.PostInterestAndCredits(); //Posting Credits

            Console.WriteLine();

            Console.WriteLine(".................................................................................................");


            // 2. Preferred Checking Account Implementation

            Console.WriteLine("2.Preferred Checking Accounts");
            Console.WriteLine("...................................................");

            Preferred_Checking pc = new Preferred_Checking(0002, "Daniel_Preferred", 500.0);

            Console.WriteLine("Implementing all the transactions for the Preferred Checkings account ");

            pc.deposit();  //Deposit Transaction

            pc.withdrawl();  //Withdrwal Transaction

            Console.WriteLine("Pressuming its end of month");

            pc.PostInterestAndCredits();  //Posting Credits

            Console.WriteLine();

            Console.WriteLine(".................................................................................................");


            // 3. Best Checking Account Implementation

            Console.WriteLine("3.Best Checking Accounts");
            Console.WriteLine("...................................................");

            Best_Checking bcc = new Best_Checking(0003, "Daniel_Best", 500.0);

            Console.WriteLine("Implementing all the transactions for the Best Checkings account ");

            bcc.deposit(); //Deposit Transaction

            bcc.withdrawl();   //Withdrwal Transaction

            Console.WriteLine("Pressuming its end of month");

            bcc.PostInterestAndCredits();//Posting Credits

            Console.WriteLine(".................................................................................................");


            Console.ReadLine();
        }
    }
}
