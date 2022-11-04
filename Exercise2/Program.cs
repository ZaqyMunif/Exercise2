using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private int[] zaqy = new int[117];
        private int n;
        int i;
        private int k;

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
            Console.WriteLine("");
            Console.WriteLine(" Enter array element ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1= Console.ReadLine();
                zaqy[i] = Int32.Parse(s1);
            }

        }
        public void InsertionSort()
        {
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine(" Elemen Array yang tersusun ");
            Console.WriteLine("----------");
            for (int i = 0; i < n; i++) 
            {
                for (int mz = i - 1; mz>= 0; n = 1 )
                {
                    if (i < zaqy[mz])
                    {
                        zaqy[mz + 1] = zaqy[mz];
                        mz--;
                        zaqy[mz + 1] = n;
                    }
                }
            }
            Console.Write(" Array Is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(zaqy[i] + " ");
            }
        }
        public void Mergesort()
        {
            if (i>= n)
                return;
            int mid = (n-1)+()
        }
    }
}
