using Bookkeeper;
FileHandler fileHandler = new FileHandler();
TransactionList transactionList = new TransactionList();
MenuOptions menu = new MenuOptions();
transactionList.userTransactionList.AddRange(fileHandler.loadFromFile());
menu.mainMenu(transactionList, fileHandler);
