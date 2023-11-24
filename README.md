# Bookkeeper
Lexicon Individual Project

## Description
A console app to keep track of income and expenses. A list of transactions is read from a text file. The user can add new entries, edit existing ones and delete entries.
When printing out the list of transaction the user can choose to sort by title, month, amount, descending or ascending.
When the user exits the modified list overwrites the original.

## Installation
1. clone project
```
https://github.com/anmabler/Bookkeeper.git
```
2. Run Main class

## Usage
This project needs a .txt file called "SavedTransactions" in the project folder to work properly. This because the app currently has no exception handling when reading/ writing to file.
The file should contain comma separated lines with title(string), amount(int), month(int) and true/false for income or not.

## Authors
[Martina Blixt Eriksson](https://github.com/anmabler)

