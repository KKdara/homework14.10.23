using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework14._10._23
{
    enum Type
    {
        Current,
        Savings
    }
      
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7.1");
            BankAccount account = new BankAccount();
            account.id = 132874590762;
            account.balance = 10;
            Type type = Type.Current;
            account.type = type;
            account.Print();

            Console.WriteLine("\nTask 7.2");
            BankAccount2 user1 = new BankAccount2();
            user1.balance = 500;
            user1.type = Type.Current;
            user1.Print();
            BankAccount2 user2 = new BankAccount2();
            user2.type = Type.Savings;
            user2.balance = 1000;
            user2.Print();

            Console.WriteLine("\nTask 7.3");
            BankAccount3 user = new BankAccount3();
            user.id = 123456;
            user.balance = 100000;
            user.type = Type.Current;
            user.Print();
            Console.WriteLine("Enter the amount to withdraw:");
            string a = Console.ReadLine();
            bool res = double.TryParse(a, out double sum);
            if (res)
            {
                user.EmptyMoney(sum);
            }
            Console.WriteLine("Enter the amount to deposit:");
            string b = Console.ReadLine();
            bool result = double.TryParse(b, out double contribution);
            if (result)
            {
                user.MakeContribution(contribution);
            }

            Console.WriteLine("\nHome Task 7.1");
            Building building1 = new Building(25, 15, 120, 12, 6);
            building1.Print();
           
            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
