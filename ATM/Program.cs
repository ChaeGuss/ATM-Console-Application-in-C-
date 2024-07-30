using System;

public class cardHolder
{
    String cardNumber;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, String firstName, String lastName, double balance)
    {
        this.cardNumber = cardNum;
        this.pin = 0;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;

    }

    public String getCardNum()
    {
        return cardNumber;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNumber)
    {
        cardNumber = newCardNumber;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currUser)
        {
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currUser.setBalance(deposit + currUser.getBalance());
            Console.WriteLine("Thank you for your deposit. Your new balance is: " + currUser.getBalance());
        }

        void withdraw(cardHolder currUser)
        {
            Console.WriteLine("How much would you like to withdraw: ");
            double withdraw = Double.Parse(Console.ReadLine());

            if (currUser.getBalance() > withdraw)
            {
                Console.WriteLine("Insufficient balance!");
            } else
            {
                currUser.setBalance(currUser.getBalance() - withdraw);
                Console.WriteLine("Thank you!");
            }
        }

        void balance(cardHolder currUser)
        {
            Console.WriteLine("Current balance: " + currUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("2390900339292", 1234, "Anu", "Perera", 150.31));
        cardHolders.Add(new cardHolder("4390900339294", 5234, "Pabs", "Perera", 150.31));
        cardHolders.Add(new cardHolder("7390900339297", 1344, "Indu", "Perera", 150.31));
        cardHolders.Add(new cardHolder("4390900339234", 2636, "Dul", "Perera", 150.31));
        cardHolders.Add(new cardHolder("5390900439209", 1630, "Ash", "Perera", 150.31));

        Console.WriteLine("Welcome to Gukki ATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCNum = "";
        cardHolder currUser;

        while (true)
        {
            try
            {
                debitCNum = Console.ReadLine();
                currUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCNum);

                if (currUser != null)
                {
                    break;
                } else
                {
                    Console.WriteLine("Card not recognized.");
                }
            }
            catch
            {
                Console.WriteLine("Card not recognized.");
            }
        }

        Console.WriteLine("Please enter your Pin: ");
        int userPin = 0;

        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currUser.getPin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Pin.");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect Pin.");
            }

         }

        Console.WriteLine("Welcome " + currUser.getFirstName());

        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1)
            {
                deposit(currUser);
            }
            else if (option == 2)
            {
                withdraw(currUser);
            }
            else if (option == 3)
            {
                balance(currUser);
            }
            else if (option == 4)
            {
                break;
            }
            else {
                option = 0;
            }
        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day!");
    }

}