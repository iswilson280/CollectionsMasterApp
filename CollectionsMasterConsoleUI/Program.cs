using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numberArray = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numberArray);

            //TODO: Print the first number of the array

            Console.WriteLine("The first number is: " + numberArray[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine(numberArray[numberArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(numberArray);

            foreach (int number in numberArray)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numberArray);
            NumberPrinter(numberArray);


            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numberArray);
            NumberPrinter(numberArray);

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */

            Console.WriteLine("List Sorted Numbers");
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> myList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine("List Capacity");
            Console.WriteLine(myList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(myList);
            NumberPrinter(myList);

            Console.WriteLine("New List Capacity");
            //TODO: Print the new capacity
            Console.WriteLine(myList.Capacity);

            NumberPrinter(myList);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int numberLookingFor = int.Parse(Console.ReadLine());
            NumberChecker(myList, numberLookingFor);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(myList);
            NumberPrinter(myList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            myList.Sort();
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            int[] newArray = myList.ToArray();
            //TODO: Clear the list
            myList.Clear();
            Console.WriteLine("This list is clear. Here are all the numbers on the list now");
            NumberPrinter(myList);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]% 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i< numberList.Count; i ++)
            {
                if (i % 2 != 0)
                {
                    numberList.Remove(numberList.IndexOf(i));
                }

            }

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool foundNumber = false;
            foreach (var item in numberList)
            {


                if (item == searchNumber)
                {
                    Console.WriteLine($"{searchNumber}is in you list");
                    foundNumber = true;
                    break;

                }

            }
            if (foundNumber == false)
            {
                Console.WriteLine($"{searchNumber} is Not in you list");


            }

        }   

        private static void Populater(List<int> numberList)
        {
            Random instance = new Random();

            for (int i = 0; i < 50; i++)
            {
                int randomNumber = instance.Next(51);
                numberList.Add(randomNumber);

            }

        }

        private static void Populater(int[] numbers)
        {
            Random instance = new Random();

            for (int index = 0; index < numbers.Length; index++)
            {

                int randomNumber = instance.Next(0, 51);
                numbers[index] = randomNumber;
            }


        }

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[50];
            int index = 0;
            for (int i = array.Length - 1; i > 0; i--)
            {
                newArray[index] = array[i];
                index++;

            }
            foreach ( var item in newArray)
            {
                Console.WriteLine(item);
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
