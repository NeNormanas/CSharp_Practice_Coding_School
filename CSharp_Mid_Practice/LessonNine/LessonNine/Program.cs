using System;

namespace LessonNine.Bank   
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountManager accountmanager = new AccountManager(new Account(123456));

            accountmanager.AddMoney(20.0); // abstrakcija paslepiam detales , klase klaseje.

            
            //account.AddMoney(20.0);
            //account.SetMaxCredit(100);
            //account.TakeMoney(40.0);

            //account.PrintDetails();

            Console.ReadKey();





        }
    }
}
