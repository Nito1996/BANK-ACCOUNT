using System;
using Microsoft.VisualBasic.FileIO;

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
            Console.WriteLine($"Welcome {userAccount.Owner} to the besto' BANK all over the world! " +
                $"Your current balance is {userAccount.ShowBalance()}.");
            do
            {
                int selectedOption = GetSelectedOption();
                if (selectedOption == 4 && ConfirmLogOut())
                {
                        break;                   
                }
                else
                {
                    ProcessSelectedOption(selectedOption, userAccount);
                }
            } while (true);
            Console.WriteLine($"Thank you for using our services. You have a great day {userAccount.Owner}!");
        }

        static int GetSelectedOption()
        {
            Console.WriteLine("Which option would you like to perform?");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Log out");
            Console.WriteLine("");

            int selectedOption;
            while (!int.TryParse(Console.ReadLine(), out selectedOption) || selectedOption < 1 || selectedOption > 4)
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value (1-4).");
                Console.WriteLine("");
            }
            return selectedOption;
        }

        static bool ConfirmLogOut()
        {
            Console.WriteLine("");
            Console.WriteLine("You sure you want to log out?");
            Console.WriteLine("1.YES");
            Console.WriteLine("2.NO");
            Console.WriteLine("");

            int userChoice;
            while (!int.TryParse(Console.ReadLine(), out userChoice) || (userChoice != 1 && userChoice != 2))
            {
                Console.WriteLine("Invalid input. Please enter either 1 for YES or 2 for NO.");
                Console.WriteLine("");
            }
            return userChoice == 1;
        }

        static void ProcessSelectedOption(int selectedOption, BankAccount userAccount)
        {
            switch (selectedOption)
            {
                case 1:
                    userAccount.Deposit();
                    break;
                case 2:
                    userAccount.Withdraw();
                    break;
                case 3:
                    userAccount.ShowBalance();
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
            if (int.TryParse(userInput, out int selectedOption))
            {
                return selectedOption;
            }
            else
            {
                return 0;
            }
        }
    }
}
