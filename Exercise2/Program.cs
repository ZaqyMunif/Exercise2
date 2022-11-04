using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private int[] zaqy = new int[117];
        private int n;
        
        public void Input()
        {
            while (true)
            {
                Console.Write("Enter the number element in array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 117))
                    break;
                else
                    Console.WriteLine("\n Maksimal Array 117 element. \n");
            }

        }
    }
}
