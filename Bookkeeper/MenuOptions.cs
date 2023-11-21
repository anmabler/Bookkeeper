using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookkeeper
{
    internal class MenuOptions
    {
        public void mainMenu(TransactionList userTransactions)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Welcome to Bookkeeper!");
            Console.WriteLine("Pick an option: ");
            Console.WriteLine("1/ Show items");
            Console.WriteLine("2/ Add new expense/income");
            Console.WriteLine("3/ Edit item (edit, remove)");
            Console.WriteLine("4/ Save and quit");
            Console.WriteLine("-----------------------------");

            var mainMenuInput = Console.ReadLine();
            
            switch (mainMenuInput)
            {
                case "1":
                    sortItems(userTransactions);
                    showAscendingDescending(userTransactions);
                    break;
                case "2":
                    addNewItem();
                    break;
                case "3":
                    editItem();
                    break;
                case "4":
                    saveAndExit();
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    mainMenu(userTransactions);
                    break;
            }
        }
        public void showAscendingDescending(TransactionList userTransactions)
        {
            Console.WriteLine("Pick an option:");
            Console.WriteLine("1/ Show all transactions");
            Console.WriteLine("2/ Show expenses");
            Console.WriteLine("3/ Show income");
            var displayInput = Console.ReadLine();
            switch (displayInput)
            {
                case "1":
                    Console.WriteLine("Showing all transactions.");
                    userTransactions.displayAllTransactions();
                    break;
                case "2":
                    Console.WriteLine("Showing expenses");
                    userTransactions.displayExpense();
                    break;
                case "3":
                    Console.WriteLine("Showing income");
                    userTransactions.displayIncome();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    showAscendingDescending(userTransactions);
                    break;
            }

        }

        public void sortItems(TransactionList userTransactions)
        {

            // I already wrote the methods to take an argument, that is why I chose to show all possible combinations for sorting at once.
            Console.WriteLine("Show items");
            Console.WriteLine("Pick an option:");
            Console.WriteLine("1/ Sort by month ascending");
            Console.WriteLine("2/ Sort by month descending");
            Console.WriteLine("3/ Sort by amount ascending");
            Console.WriteLine("4/ Sort by amount descending");
            Console.WriteLine("5/ Sort by title ascending");
            Console.WriteLine("6/ Sort by title descending");
            Console.WriteLine("-----------------------------");

            var sortInput = Console.ReadLine();

            switch (sortInput)
            {
                case "1":
                    userTransactions.sortByMonth(false);
                    break;
                case "2":
                    userTransactions.sortByMonth(true);
                    break;
                case "3":
                    userTransactions.sortByAmount(false);
                    break;
                case "4":
                    userTransactions.sortByAmount(true);
                    break;
                case "5":
                    userTransactions.sortByTitle(false);
                    break;
                case "6":
                    userTransactions.sortByTitle(true);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    sortItems(userTransactions);
                    break;
            }

        }
        public void addNewItem()
        {

        }
        public void editItem()
        {

        }
        public void saveAndExit()
        {

        }
    }
}
