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
                //Automatically populate an array with 25 elements in in
                int[] count = new int[26];
                int pop_array = 26;
                
                //Iterate through the array using a For loop
                for(int i = 1; i < 26; i++ )
                {
                    count[i] = pop_array;
                    Console.WriteLine("The element value = " + i + " ");
                   
                }

                Console.ReadKey(true);

            } //End of try

            catch
            {
                Console.WriteLine("There was an error");
                Console.ReadKey(true);
            } //End of catch
        } //End of main
    } //End of class
} //End of namespace
