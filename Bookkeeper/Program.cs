using Bookkeeper;
FileHandler fileHandler = new FileHandler();
TransactionList transactionList = new TransactionList();
transactionList.userTransactionList.AddRange(fileHandler.loadFromFile());

// ! List needs to be read from file
//transactionList.userTransactionList.AddRange(new List<UserTransaction>
//{
//    new UserTransaction("Köpa skor", 800, 11, false),
//    new UserTransaction("Oktober lön", 849, 10, true),
//    new UserTransaction("Barnbidrag", 650, 10, true),
//    new UserTransaction("Julklappar", 2000, 11, false),
//    new UserTransaction("Simskola", 1600, 12, false),

//});

//MenuOptions menu = new MenuOptions();
//menu.mainMenu(transactionList);

//transactionList.displayAllTransactions();
// the true argument means descending order.
//transactionList.sortByMonth(true);
//transactionList.displayExpense();
//transactionList.displayIncome();
//transactionList.sortByAmount(false);
//transactionList.sortByTitle(true);