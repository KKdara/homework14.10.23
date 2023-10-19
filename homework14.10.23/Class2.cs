using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14._10._23
{
    internal class BankAccount2
    {
        public float balance { get; set; }
        public Type type;
        public ulong ID { get; }
        public static ulong number = 11111111;
        public BankAccount2()
        {
            ID = number++;
        }
        public void Print()
        {
            Console.WriteLine($"ID: {ID} \nType: {type} \nBalance: {balance}");
        }
        
    }
}
