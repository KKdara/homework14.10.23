using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14._10._23
{
    internal class BankAccount3
    {
        public double balance { get; set; }
        public Type type;
        private ulong ID;
       

        public ulong id
        {
            get
            {
                return ID;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The ID can not be negative");
                }
                else
                {
                    ID = value;
                }
            }
        }
        public void EmptyMoney(double sum)
        {
            if (sum > balance)
            {
                Console.WriteLine("Unable to withdraw money. The requested amount exceeds the balance.");
            }
            else
            {
                balance += balance - sum;
                Console.WriteLine($"Withdrawal: {sum} \nCurrent balance: {balance}");
            }
        }

        public void MakeContribution(double contribution )
        {
            if (contribution < 0)
            {
                Console.WriteLine("Negative value. Impossible to contribute.");
            }
            else
            {
                Console.WriteLine($"Credited: {contribution} \nCurrent balance: {balance + contribution}");
            }
        }
        public void Print()
        {
            Console.WriteLine($"ID: {ID} \nType: {type} \nBalance: {balance}");
        }

        
    }
}
