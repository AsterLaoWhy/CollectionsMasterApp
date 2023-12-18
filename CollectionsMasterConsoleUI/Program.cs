using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var size50Array = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            static int[] Populate(int[] array)
            {
                Random rnd = new Random();

                for ( int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(50);
                }
                return array;
            }

            //TODO: Print the first number of the array
            size50Array= Populate(size50Array);
            Console.WriteLine(size50Array[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(size50Array[size50Array.Length-1]);
            Console.WriteLine("All Numbers Original");
            
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(size50Array);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(size50Array);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            static void multiplesOfThree(int[] array) {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 3 == 0)
                    {
                        array[i] = 0;
                    }
                    Console.WriteLine(array[i]);
                }
                
            }
            multiplesOfThree(size50Array);
            Console.WriteLine("-------------------");
            
            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion
            
            
            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> numbers = new List<int>();
            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numbers.Capacity);
            
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            static List<int> FiftyRandomNumbers(List<int> intList)
            {
                Random rnd = new Random();
                for (int i = 0; i <= 50; i++)
                {
                    intList.Add(rnd.Next(50));
                }
                return intList;
            }
            numbers = FiftyRandomNumbers(numbers);
            //TODO: Print the new capacity
            Console.WriteLine(numbers.Capacity);
            
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            static void IsNumeberInList(List<int> numberedList)
            {
                Console.WriteLine("What number will you search for in the number list?");
                var userNumber = Console.ReadLine();
                int num = -1;
                if (!int.TryParse(userNumber, out num))
                {
                    Console.WriteLine("Not an integer");
                }
                else
                {
                    foreach (int number in numberedList)
                    {
                        if (int.Parse(userNumber) == number) Console.WriteLine("Your number is also in the list");
                    }
                }
            }
            IsNumeberInList(numbers);
            Console.WriteLine("-------------------");
            
            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            
            //TODO: Create a method that will remove all odd numbers from the list then print results
            //For this, for some reason when dont make a new list, it isn't working, but if I populate a new list, it does
            Console.WriteLine("Evens Only!!");
            static List<int> RemoveOdds(List<int> byeOdds) {
                List<int> evens = new List<int>();
                for (int i=0;i<=byeOdds.Count-1;i++)
                {
                    int num = byeOdds[i];
                    if (num % 2 == 0)
                    {
                        evens.Add(num);
                    }
                    else
                    {
                        byeOdds.Remove(num);
                    }
                }
                foreach (int i in evens) Console.WriteLine(i);
                return evens;
            }
            List<int> evenNumbers = RemoveOdds(numbers);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            evenNumbers.Sort();
            foreach(int number in evenNumbers) Console.WriteLine(number);

            Console.WriteLine("------------------");
            Console.ReadLine();
            //TODO: Convert the list to an array and store that into a variable
            int[] numArray = evenNumbers.ToArray();

            //TODO: Clear the list
            evenNumbers.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            int j = 0;
            var size50ArrayReversed = new int[50];
            for (int i = array.Length - 1; i >= 0; i--) 
            {
                size50ArrayReversed[j] = array[i];
                j++;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
