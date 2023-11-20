using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookkeeper
{
    internal class UserTransaction
    {
        private string title;
        private int amount;
        private int month;
        private bool isIncome;

        // Getters and setters

        public int getAmount()
        {
            return amount;
        }
        public int getMonth()
        {
            return month;
        }
        public string getTitle()
        {
            return title;
        }
        public bool getIsIncome()
        {
            return isIncome;
        }
        
        public void editTransaction(string title, int amount, int month, bool isIncome)
        {
            this.title = title;
            this.amount = amount;
            this.month = month;
            this.isIncome = isIncome;

        }

        public void setAmount(int amount)
        {
            this.amount = amount;
        }
        public void setMonth(int month)
        {
            this.month = month;
        }
        public void setisIncome(bool isIncome)
        {
            this.isIncome = isIncome;
        }
        public void setTitle(string title)
        {
            this.title = title; 
        }
    }
}
