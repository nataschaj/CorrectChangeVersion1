using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int amountToPay = 266;
            int paidAmount = 500;

            int changeToPayBack = paidAmount - amountToPay;


            // To keep things simple, we assume that you pay back
            // change as: 1-kr coins, 10-kr coins and 100-kr bills.

            int noOf1krCoins = 0;
            int noOf10krCoins = 0;
            int noOf100krBills = 0;


            // YOUR JOB: Add code to calculate the correct change


            Console.WriteLine($"Your change is {noOf1krCoins} 1-kr coins, {noOf10krCoins} 10-kr coins and {noOf100krBills} 100-kr bills");
            Console.WriteLine($"A total of {changeToPayBack} kr");


            // The LAST line of code should be ABOVE this line
        }
    }
}
