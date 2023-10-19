using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14._10._23
{
    internal class BankAccount
    {
        public float balance { get; set; }
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
        public void Print()
        {
            Console.WriteLine($"ID: {ID} \nType: {type} \nBalance: {balance}");
        }

    }


}
    

