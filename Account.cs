public  class Account 
{
    List<Account> accounts1 = new List<Account>();
    public string  Accountnumber  { get; set; }
    public string TransactionType { get; set; }
     public   string  BVN { get; set; }
     public  int  NIN { get; set; }
     public string  Accountname { get; set; }
    public decimal Balance { get; set; }
    public  DateTime  DateOpened { get; set; }
     public  string AccountType { get; set; }
     public  string AccountStatus { get; set; }
     public string PIN { get; set; }
     public  string AccountHolder { get; set;}
     public decimal amount { get; set; }
     

     public void OpenAccount(User user1)
    {
        string Accountnumber =new Random().Next(10000000, 99999999).ToString() ;
        System.Console.WriteLine("Enter your nin number");
        int NIN = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your bvn");
        string BVN = Console.ReadLine();
        string Accountname = $"{user1.FirstName} {user1.LastName}";      
        Console.WriteLine("Enter your pin");
        string PIN = Console.ReadLine();
        System.Console.WriteLine("enter the account type Current /Savings");
        string AccountType = Console.ReadLine();

        Account account= new Account();
        account.Accountnumber = Accountnumber;
        account.Accountname = Accountname;
        account.AccountType = AccountType;
        account.AccountStatus ="Active";
        account.DateOpened = DateTime.Now;
        account.Balance =0.00m;
        account.BVN= BVN;
        account.NIN = NIN;
        account.PIN = PIN;
        account.AccountHolder = user1.Email;

        accounts1.Add(account);
        System.Console.WriteLine("Welcome");
        Console.ReadKey();
    }


    public void viewAccount(User user1)
    {
        List<Account> userAccount = new List<Account>(); 
        foreach(var account in accounts1)
       {
         if(account.AccountHolder == user1.Email)
         {
            userAccount.Add(account);
         }
       }

       if(userAccount.Count == 0)
       {
            Console.WriteLine("Currently, you do not have any account");
       }
       else
       {
            Console.WriteLine("LIST OF MY ACCOUNTS");
            foreach(var account in userAccount)
            {
                Console.WriteLine($"Account Number: {account.Accountnumber}, Balance: {account.Balance}, Status: {account.AccountStatus}");
            }
       }
    }
        public void Deposit(User user)
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();
        //check the account
        foreach(var account in accounts1)
        {
            //check if the account exist and the user is the owner of the account
            if(account.Accountnumber == accountNumber && account.AccountHolder == user.Email)
            { 
                if(account.AccountStatus == "Active")
                {
                    Console.Write("Enter deposit amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter pin : ");
                    string pin = Console.ReadLine();
                    if(account.PIN == pin)
                    {
                         account.Balance += amount;
                        Console.WriteLine("Deposit successful.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Pin");
                        return;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Account is InActive. Transaction can not be completed");
                    return;
                }
            }
        }
        Console.WriteLine("Account is invalid!");
    }
    
     public void Withdraw(User user1)
     {
        System.Console.WriteLine("Enter your Account number");
        string AccountNumber = Console.ReadLine();
        //check the account
        foreach (var account in accounts1)
        {
            if (account.Accountnumber == AccountNumber && account.AccountHolder == user1.Email)
            {
                
                if(account.AccountStatus == "Active")
                {
                    decimal Charges = 100.00m;
                    Console.Write("Enter  amount: ");
                  decimal amount =decimal.Parse (Console.ReadLine());
                    Console.Write("Enter pin : ");
                    string Pin = Console.ReadLine();
                    if(account.PIN == Pin)
                    {
                        if (account.Balance == null) 
                        {
                            Console.WriteLine("Balance (0.00)");
                            return;
                        }
                        else
                        { 
                            if (account.Balance <= amount)
                            {
                                
                                account.Balance -= amount - Charges;
                            Console.WriteLine("successful.");
                            return;
                            }
                               
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Pin");
                        return;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Account is InActive. Transaction can not be completed");
                    return;
            }
           
        }

        System.Console.WriteLine("Account is invalid");
    }

 }
    public void Transfer(User user1 )
    {

        System.Console.WriteLine("Enter  recievers Account number ");
        decimal AccountNumber= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Transaction type ");
        string TransactionType = Console.ReadLine();
         //check the account
        foreach (var account in accounts1)
        {
            if (account.Accountnumber == Accountnumber && account.AccountHolder == user1.Email)
            {
                
                if(account.AccountStatus == "Active")
                {
                    Console.Write("Enter  amount: ");
                   decimal amount =decimal.Parse (Console.ReadLine());
                   if (amount < account.Balance)
                   {
                        
                        Console.Write("Enter The reciever account number: ");
                            string Account =Console.ReadLine();
                            if (Account == "Active")
                            {
                                Console.Write("Enter pin : ");
                                string Pin = Console.ReadLine();
                                decimal Charges =100.00m;

                                if(account.PIN == Pin)
                                {
                                    account.Balance -= amount - Charges; 
                                  

                                    Console.WriteLine("successful.");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid pin");
                                }
                            }  
                            else
                            {
                                Console.WriteLine("The Reciever account is inactive");
                            }
                    
                    }
                     System.Console.WriteLine("Insufficient balance");
                }
                Console.WriteLine("Account is not active");
            }
             System.Console.WriteLine("Account is invalid");
        }
        
    }
    public void ViewBalance( User user1)
    {
        
        System.Console.WriteLine("Enter Account number ");
        decimal AccountNumber= int.Parse(Console.ReadLine());
         //check the account
        foreach (var account in accounts1)
        {
            if (account.Accountnumber == Accountnumber && account.AccountHolder == user1.Email)
            {
                
                if(account.AccountStatus == "Active")
                {
                   
                    Console.Write("Enter  amount: ");
                   decimal amount =decimal.Parse (Console.ReadLine());
                   Console.Write("Enter The reciever account number: ");
                     decimal Account =decimal.Parse (Console.ReadLine());
                    Console.Write("Enter pin : ");
                    string Pin = Console.ReadLine();
                    if(account.PIN == Pin)
                    {
                        Console.WriteLine(account.Balance);
                    }
                }
                else
                {
                    System.Console.WriteLine("Invalid pin");
                }
               
             }
             Console.WriteLine("Account is inactive");
        }
        System.Console.WriteLine("Account is invalid");
   }             
}   