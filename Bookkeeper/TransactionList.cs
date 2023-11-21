using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookkeeper
{
    internal class TransactionList
    {  
        public List<UserTransaction> userTransactionList = new List<UserTransaction>();

        // All sorting methods are in ascending order
        public void sortByMonth()
        {
            var listByMonth = userTransactionList.OrderBy(transaction => transaction.getMonth());
            userTransactionList = listByMonth.ToList();
            displayAllTransactions();
        }

        public void sortByAmount()
        {
            var listByAmount = userTransactionList.OrderBy(transaction => transaction.getAmount());
            userTransactionList = listByAmount.ToList();
            displayAllTransactions();
        }

        public void sortByTitle()
        {
            var listByTitle = userTransactionList.OrderBy(transaction => transaction.getTitle());
            userTransactionList = listByTitle.ToList();
            displayAllTransactions();
        }

        public void displayIncome()
        {
            var incomeList = userTransactionList.Where(transaction => transaction.getIsIncome() == true).ToList();
            transactionOutput(incomeList);
        }

        public void displayExpense()
        {
            var expenseList = userTransactionList.Where(transaction => transaction.getIsIncome() == false).ToList();

            transactionOutput(expenseList);
        }

        public void displayAllTransactions()
        {
            transactionOutput(userTransactionList);
        }

        private void transactionOutput(List<UserTransaction> list)
        {
            foreach (var transaction in list)
            {
                Console.WriteLine($"{transaction.getTitle()} {transaction.getAmount()}  {transaction.getMonth()}  {transaction.getIsIncome()}");

            }
        }
    }
}
