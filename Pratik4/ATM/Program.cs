using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 1000;
            Console.WriteLine("Bakiyeniz =" + balance);
            Console.WriteLine("\n ****Operations****\n ");
            Console.WriteLine("1. Withdrawal ");
            Console.WriteLine("2. Lodgment");
            Console.WriteLine("3. Balance Inquiry");
            Console.WriteLine("4. Card Return");
            Console.WriteLine("\n Please Select Operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    Console.WriteLine("Balance ="+balance);
                    Console.Write("Amount to be withdrawn: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if(amount>balance)
                    {
                        Console.Write("Insufficient Balance. Try Again");
                        amount = Convert.ToInt32(Console.ReadLine());
                    }
                    balance -= amount;                   
                    Console.WriteLine("New Balance = "+balance);
                    break;       
                case 2:
                    Console.WriteLine("Balance = "+balance);
                    Console.Write("Amount to be Lodgement: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine("New Balance ="+balance);
                    break;
                case 3:
                    Console.WriteLine("Balance = "+balance);
                    break;
                case 4:
                    Console.WriteLine("Don't forget to get the card");
                    break;
                default:
                    Console.WriteLine("You have selected the wrong operation. Try Again.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
