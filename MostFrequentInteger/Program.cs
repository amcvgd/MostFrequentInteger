using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentInteger
{
    class Program
    {

        

        static void Main(string[] args)
        {
            //Array we are gonna be working with
            int[] array = { 1, 2, 3, 3, 4, 6, 2, 1, 2, 7, 9, 5, 23, 45, 64, 3, 2, 1, 5 };

            //Dictionary where the key is actually the integer and the value is the number of times the integer is repeated.
            Dictionary<int, int> intCount = new Dictionary<int, int>();

            //This is the key pointing to the dictionary of the integer that currently repeats the most
            int maxInt = -1;

            //Iterate over all items of array
            for (int i = 0; i < array.Length; i++)
            {
                if (intCount.ContainsKey(array[i]))//If integer is already in dictonary we increase count by 1
                {
                    intCount[array[i]] += 1;

                }
                else
                    intCount.Add(array[i], 1);//If not we add it to the dictionary and its initial value is 1

                if (maxInt == -1)//If the current maxInt is -1 we just set it to the current element of the array
                    maxInt = array[i];
                else if(intCount[maxInt] <= intCount[array[i]])// If not we only update maxInt if the integer is repeated more than the current maxInt.
                {
                    maxInt = array[i];

                }
                
                 
            }

            System.Console.WriteLine("Max int: " + maxInt);
            System.Console.WriteLine("Repeated times: " + intCount[maxInt]);

            System.Console.ReadLine();

        }
    }
}
