public class BanckAccount

{

    //readonly 

    public string AccontHolder;

    public double Balance;



    //constuructor for the initilizing 

    public BanckAccount(string account, double balance)

    {

        AccontHolder = account;

        Balance = balance;



    }

    public void deposit(double amount)

    {

        if (amount > 0)

        {

            Balance += amount;

            Console.WriteLine($"Deposit of {amount} successful and newBalance is {Balance}");

        }

        else

        {

            Console.WriteLine("invalid deposit amount");

        }

    }

    public void withDraw(double amount)

    {

        if (amount > 0 && amount <= Balance)
        {

            Balance -= amount;

            Console.WriteLine($"Amout is successfuly deposited{amount} and left amount is the {Balance}");

        }

        else

        {

            Console.WriteLine("Invalid amount");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            BanckAccount myAccount = new BanckAccount("Amit Kumar", 20000);

            Console.WriteLine($"Account holder name {myAccount.AccontHolder}");

            Console.WriteLine($"Balance is {myAccount.Balance}");

            myAccount.deposit(400);

            myAccount.withDraw(300);



        }

    }



}
