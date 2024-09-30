using System.Transactions;

public class Transactions : Account
{
    List<Transactions> transactionsK = new List<Transactions>();
   
    public DateTime TransactionTimeAndDate { get; set; }
    public string Sender { get; set; }
    public string Reciever { get; set; }
    public Guid SenderId { get; set; }
        
    public string TransactionType { get; set; }
    public string Narration { get; set; }
    public decimal TransactionAmount { get; set; }
    public Guid TransactionReference { get; set; }
       
      public Transactions (string transactionType,decimal transactionAmount, Guid transactionReference , string Sender, string Reciever, string Narration, Guid SenderId,DateTime TransactionTimeAndDate)
            
       {

               
              
               TransactionAmount = TransactionAmount;
               TransactionReference = Guid.NewGuid();
               TransactionTimeAndDate = DateTime.Now;
               Narration="Sucessfull";
              Sender = Sender;
               SenderId  =Guid.NewGuid();
               TransactionType =TransactionType;


       }

    public Transactions()
    {
    }

    public  void ViewTransactions(Account account1)
    {
       
       if (Transfer != null)
        {
         
            TransactionAmount = account1.amount;
            TransactionReference = Guid.NewGuid();
            TransactionTimeAndDate = DateTime.Now;
            Sender = account1.Accountnumber;
            SenderId =Guid.NewGuid();
            Narration = "Sucessfull";
            TransactionType = account1.TransactionType;
              System.Console.WriteLine($"SENDER:  {account1.Accountnumber} \n Transaction Type:  {account1.TransactionType} \n Transaction Amount :  {TransactionAmount} \n Transaction Refrence:  {TransactionReference} \n  Sender ID:   {SenderId} \n Transaction Date And Time:  {TransactionTimeAndDate}  \n Naration:  {Narration} ");
       }
       if (Transfer == null) 
        {
             System.Console.WriteLine("No transaction occured");
        }
        //View transactions
         
    }
}              
       
  