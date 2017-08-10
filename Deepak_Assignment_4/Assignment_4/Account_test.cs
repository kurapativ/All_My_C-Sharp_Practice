using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Account_test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Account Management system");

            // Creation of for Account for each type of accounts

            Basic_Checking bc = new Basic_Checking(1,"sai_bc",100.0);

            Console.WriteLine("Performing various transactions on this basic account");

            bc.deposit();
           
            bc.withdrawl();
            Console.WriteLine("Assuming as end of the month");
            bc.PostInterestAndCredits();

            Console.WriteLine();

            Preferred_Checking pc = new Preferred_Checking(2, "sai_pc", 100.0);

            Console.WriteLine("Performing various transactions on this preferred account");

            pc.deposit();
            pc.withdrawl();
            Console.WriteLine("Assuming as end of the month");
            pc.PostInterestAndCredits();
            Console.WriteLine();


            Best_Checking bcc = new Best_Checking(3, "sai_bcc", 100.0);

            Console.WriteLine("Performing various transactions on this best account");

            bcc.deposit();
            bcc.withdrawl();
            Console.WriteLine("Assuming as end of the month");
            bcc.PostInterestAndCredits();

            Console.ReadLine();

        }
    }
}
