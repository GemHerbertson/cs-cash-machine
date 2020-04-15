using System;

namespace cSharpCashMachine
{
    class Program
    {
        void checkPin()
        {
        START:
            string pinNumber = "1000";
            string userInput;
            Console.Write("Please enter your pin: ");
            userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            if(userInput == pinNumber)
            menu();
            else
            goto START;
        }

        void menu()
        {
        SELECT:
            string menuUserInput;
            Console.Write("Please select which service you require: 1. Withdrawal 2. Deposit 3. Change Pin 4. Exit");
            menuUserInput = Console.ReadLine();
            Console.WriteLine(menuUserInput);

            if(menuUserInput == "1")
            withdrawal();
            else if (menuUserInput == "2")
            
            else if (menuUserInput == "3")
            
            else if (menuUserInput == "4")
            
            else 
            goto SELECT;
        }
        void withdrawal(int bankBalance, int withdrawalAmount)
        {
            bankBalance -= withdrawalAmount;
            Console.WriteLine("Your new balance is: {0}", bankBalance);
        }



        static void Main(string[] args) 
        {
            Program cashMachine = new Program();
            cashMachine.withdrawal(500, 30);
            cashMachine.checkPin();
    

        }
    }
}
