using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookkeeper
{
    internal class FileHandler
    {

        string path = @"../../../SavedTransactions.txt";
        
        public List<UserTransaction> loadFromFile()
        {
            List<string> lines = File.ReadAllLines(path).ToList();
            List<UserTransaction> transactions = new List<UserTransaction>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if(parts.Length != 4)  continue;
                var title = parts[0];
                var amount = int.TryParse(parts[1], out int intAmount);
                var month = int.TryParse(parts[2], out int intMonth);
                var income = bool.TryParse(parts[3], out bool isIncome);
                
                if(amount && month && income)
                {
                    // Create a new UserTransaction object from the text file input and add to list.
                    UserTransaction userTransaction = new UserTransaction(title, intAmount, intMonth, isIncome);
                    transactions.Add(userTransaction);
                    
                }
            }
         
            return transactions;
            
        }
    }
}
