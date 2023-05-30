using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsArrayString
{
    internal class PrintUnique
    {
        public static void PrintUniqOnly(int[] array) 
        {
            Console.WriteLine("Unique Numbers");
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[j] == array[i])
                    { 
                        isUnique = false; 
                        break; 
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
