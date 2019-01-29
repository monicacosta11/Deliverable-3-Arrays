/*
Author: Monica Costa
Date: 1/28/2019
Comments: This C# Console application code demonstrates the use of
  arrays.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                // n is an array of 25 integers
                int[] array = new int[25];
                int i, j;

                /* initialize elements of array n */
                for (i = 1; i < 25; i++)
                {
                    array[i] = i;
                }

                /* output each array element's value */
                for (j = 1; j < 25; j++)
                {
                    Console.WriteLine("Element = {1}", j, array[j]);
                }
                Console.ReadKey();


            } //End of try

            catch
            {
                Console.WriteLine("There was an error");
                Console.ReadKey(true);
            } //End of catch
        } //End of main
    } //End of class
} //End of namespace
