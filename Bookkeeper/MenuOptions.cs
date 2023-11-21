﻿using System;
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
                    addNewItem(userTransactions);
                    userTransactions.displayAllTransactions();
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
            // At first I wanted to choose ascending/descending in another step.
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
        // Method for adding a new item
        // Checks the input for int and that month is not greater than 12.
        public void addNewItem(TransactionList transactions)
        {
            

            Console.WriteLine("Add a new item");
            Console.Write("Add title: ");
            var titleInput = Console.ReadLine();

            bool isAmountInt = false;
            string amountInput;
            int amount;

            do
            {
                Console.Write("Add amount: ");
                amountInput = Console.ReadLine();
                isAmountInt = int.TryParse(amountInput, out amount);
                if (!isAmountInt)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect price format. Please enter only numbers.");
                    Console.ResetColor();
                }
            }
            while (!isAmountInt);

            bool isMonthInt = false;
            string monthInput;
            int month;
            do
            {
                Console.Write("Add month (number): ");
                monthInput = Console.ReadLine();
                isMonthInt = int.TryParse(monthInput, out month);
                if (!isAmountInt)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect price format. Please enter only numbers.");
                    Console.ResetColor();
                }
                if (month > 12)
                {
                    Console.WriteLine("Enter a valid month");
                }
            }
            while (!isMonthInt || month > 12);

            Console.WriteLine("Pick an option:");
            Console.WriteLine("1/ Expense");
            Console.WriteLine("2/ Income");
            var transactionInput = Console.ReadLine();
            bool isIncome = true;
            if (transactionInput == "1")
            {
                isIncome = false;
            }
            else if(transactionInput == "2")
            {
                isIncome = true;
            }
            else 
            {
                Console.WriteLine("Invalid input");
            }

            UserTransaction transaction = new UserTransaction(titleInput, amount, month, isIncome);
            transactions.userTransactionList.Add(transaction);
            Console.WriteLine("Item added");
        }
        public void editItem()
        {

        }
        public void saveAndExit()
        {

        }
    }
}
