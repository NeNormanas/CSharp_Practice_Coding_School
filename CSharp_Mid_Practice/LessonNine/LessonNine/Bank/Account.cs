using System;
using System.Collections.Generic;
using System.Text;

namespace LessonNine.Bank
{
    class Account
    {

        private int accountNumber;
        private Double balance = 0;
        private double maxCredit = 0;
        private DateTime lastOperation;

        




        public Account(int accountNumber)
        {
            this.accountNumber = accountNumber;



        }

        public void AddMoney (double moneyIn)
        {

            balance += moneyIn;

        }

        public void TakeMoney (double moneyOut)
        {
            if (balance + maxCredit >= moneyOut)
            {
                balance -= moneyOut;
            }
            else
            {
                Console.WriteLine("Do not have enought");
            }

        }

        public void SetMaxCredit(double newMaxCredit)
        {
            if (newMaxCredit >= 0)
            {
                maxCredit = newMaxCredit;
            }
            else
            {
                Console.WriteLine("Error");
            }
            

        }


        public void PrintDetails()
        {
            Console.WriteLine($"Your balance is: {balance}");
        }

        


    }
}
