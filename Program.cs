using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {5,9,2,8,6,1,7,5,4,7,3};
            InsertionSorting(myArray);
            for (int i = 0; i < myArray.Length; i++) 
             {
                 Console.Write(myArray[i] + "  "); 
             } 
             Console.ReadKey(); 

        }

        static void InsertionSorting(int[] myArray)
        {
            for (var counter = 1; counter < myArray.Length; counter++)
            {
                var currentNumberLocation = counter;
                while (currentNumberLocation > 0)
                {
                    if (myArray[currentNumberLocation - 1] > myArray[currentNumberLocation])
                    {
                        int temp = myArray[currentNumberLocation - 1];
                        myArray[currentNumberLocation - 1] = myArray[currentNumberLocation];
                        myArray[currentNumberLocation] = temp;
                        currentNumberLocation--;
                    }
                    else
                        break;
                }
            }
        }
    }
}
