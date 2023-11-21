using Bookkeeper;

TransactionList transactionList = new TransactionList();
transactionList.userTransactionList.AddRange(new List<UserTransaction>
{
    new UserTransaction("Köpa skor", 800, 11, false),
    new UserTransaction("Oktober lön", 849, 10, true),
    new UserTransaction("Barnbidrag", 650, 10, true),
    new UserTransaction("Julklappar", 2000, 11, false),

});

//transactionList.displayExpense();
//transactionList.displayIncome();
//transactionList.displayAllTransactions();
//transactionList.sortByMonth();
//transactionList.sortByAmount();
//transactionList.sortByTitle();