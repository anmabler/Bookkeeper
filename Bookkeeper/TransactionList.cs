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
