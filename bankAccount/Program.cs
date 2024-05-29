using System;

namespace bankAccount
{
    class Program
    {
        static void Main()
        {
            BankAccount lebronJames = new BankAccount("LeBron James", 5000);
            ManageUserAccount(lebronJames);
        }

        static void ManageUserAccount(BankAccount userAccount)
        {
            Console.WriteLine($"Welcome {userAccount.Owner} to the besto' BANK all over the world! ");
            userAccount.ShowBalance();
            do
            {
                int selectedOption = GetSelectedOption();
                if (selectedOption == 4 && ConfirmLogOut()) break;
                ProcessSelectedOption(selectedOption, userAccount);
            } while (true);
            Console.WriteLine($"Thank you for using our services. You have a great day {userAccount.Owner}!");
            Console.WriteLine("");
        }

        static int GetSelectedOption()
        {
            Console.WriteLine("Which option would you like to perform?");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Log out");
            Console.WriteLine("");

            int userChoice = GetUserInput();
            if (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value (1-4).");
                Console.WriteLine("");
                return GetSelectedOption();
            }
            return userChoice;
        }

        static bool ConfirmLogOut()
        {
            Console.WriteLine("");
            Console.WriteLine("You sure you want to log out?");
            Console.WriteLine("1.YES");
            Console.WriteLine("2.NO");
            Console.WriteLine("");

            int userChoice = GetUserInput();
            if (userChoice != 1 && userChoice != 2)
            {
                Console.WriteLine("Invalid input. Please enter either 1 for YES or 2 for NO.");
                Console.WriteLine("");
                return ConfirmLogOut();
            }
            return userChoice == 1;
        }

        static void ProcessSelectedOption(int selectedOption, BankAccount userAccount)
        {
            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine("How much money do you want to save?");
                    if(userAccount.Deposit()){
                        Console.WriteLine($"Your new balance is {userAccount.ShowBalance()}");
                    }
                    else
                    {
                    Console.WriteLine("Invalid request.");
                    };
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("How much money do you want to withdraw?");
                    if (userAccount.Withdraw()){
                    Console.WriteLine($"Your new balance is {userAccount.ShowBalance()}");
                    }
                    else
                    {
                    Console.WriteLine("Invalid request.");
                    }
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine($"Your current Balance is: {userAccount.ShowBalance()}.");
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please only enter a valid numeric value.");
                    Console.WriteLine("");
                    break;
            }
        }

        public static int GetUserInput()
        {
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int selectedOption);
            return selectedOption;
        }
    }
}
