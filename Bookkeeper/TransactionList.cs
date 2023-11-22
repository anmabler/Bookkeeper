using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bookkeeper
{
    internal class TransactionList
    {  
        public List<UserTransaction> userTransactionList = new List<UserTransaction>();

        public void sortByMonth(bool sortByDesc)
        {
            if(sortByDesc)
            {
                userTransactionList = userTransactionList.OrderByDescending(transaction => transaction.getMonth()).ToList();

            }
            else
            {
                userTransactionList = userTransactionList.OrderBy(transaction => transaction.getMonth()).ToList();
            }
        }

        public void sortByAmount(bool sortByDesc)
        {
            if (sortByDesc)
            {
                userTransactionList = userTransactionList.OrderByDescending(transaction => transaction.getAmount()).ToList();
            }
            else
            {
                userTransactionList = userTransactionList.OrderBy(transaction => transaction.getAmount()).ToList();
            }
        }

        public void sortByTitle(bool sortByDesc)
        {
            if(sortByDesc)
            {
                 userTransactionList = userTransactionList.OrderByDescending(transaction => transaction.getTitle()).ToList();
            }
            else
            {
                userTransactionList = userTransactionList.OrderBy(transaction => transaction.getTitle()).ToList();
            }
        }

        public void displayIncome()
        {
            Console.WriteLine(listHeader());
            var incomeList = userTransactionList.Where(transaction => transaction.getIsIncome() == true).ToList();
            transactionOutput(incomeList);
        }

        public void displayExpense()
        {
            Console.WriteLine(listHeader());
            var expenseList = userTransactionList.Where(transaction => transaction.getIsIncome() == false).ToList();

            transactionOutput(expenseList);
        }

        public void displayAllTransactions()
        {
            Console.WriteLine(listHeader());
            transactionOutput(userTransactionList);
        }

        private void transactionOutput(List<UserTransaction> list)
        {
            foreach (var transaction in list)
            {
                Console.WriteLine($"{transaction.getTitle().PadRight(15)} {transaction.getAmount().ToString().PadRight(15)}  {transaction.getMonth().ToString().PadRight(15)}  {transaction.getIsIncome()}");

            }
        }

        public int countBalance()
        {
            int balance = 0;

            for(int i = 0; i < userTransactionList.Count; i++)
            {
                if (userTransactionList[i].getIsIncome())
                {
                    balance += userTransactionList[i].getAmount();
                }
                else
                {
                    balance -= userTransactionList[i].getAmount();
                }
            }

            return balance;
        }

        private string listHeader()
        {
           return "Title".PadRight(15) + "Amount".PadRight(15) + "Month".PadRight(15) + "Income?" + "\n------------------------------------------------------------";
        }
    }
}
