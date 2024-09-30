User user = new User();
 Transactions transactions= new Transactions();
Account account= new Account();
User user1= new User();
bool Welcome = true;
  
  while (Welcome)
 {
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
     Console.WriteLine("3. Admin");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            user1.Register();
            break;
        case "2":
            var loggedInUser =user1 .Login();
            if(loggedInUser != null)
            {
                bool loggedIn = true;
                while (loggedIn)
                {
                    Console.WriteLine("1. Open account");
                    Console.WriteLine("2. View account");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4.Withdraw");
                     Console.WriteLine("5.Transfer");
                      Console.WriteLine("6.View balance");
                      Console.WriteLine("7.View Transactions");
                     Console.WriteLine("8. Exit");
                    Console.Write("Choose an option: ");
                    string loginChoice = Console.ReadLine();

                    switch (loginChoice)
                    {
                        case "1":
                           account.OpenAccount(loggedInUser);
                            break;
                        case "2":
                            account.viewAccount(loggedInUser);
                            break;
                        case "3":
                        account.Deposit(loggedInUser);
                        break;

                        case "4":
                        account.Withdraw(loggedInUser);
                        break;

                        case "5":
                        account.Transfer(loggedInUser);
                        break ;

                        case "6":
                        account.ViewBalance(loggedInUser);
                        break;

                        case "7":
                        transactions.ViewTransactions(account);
                        break;

                        case "8":
                            loggedIn = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
            break;

        
        
        case "4":
            Welcome = false;
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

