using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PART#1 STEP # 01 */

            // declare an array of type double containing 10 elements
            double[] mArray = new double[10];

            //Assigning the first value of array
            mArray[0] = 1.0;
            
            //Assigning the second value of array
            mArray[1] = 1.1;

            //Assigning the third value of array
            mArray[2] = 1.2;

            //Assigning the fourth value of array
            mArray[3] = 1.3;

            //Assigning the fifth value of array
            mArray[4] = 1.4;

            //Assigning the sixth value of array
            mArray[5] = 1.5;

            //Assigning the seventh value of array
            mArray[6] = 1.6;

            //Assigning the eightth value of array
            mArray[7] = 1.7;

            //Assigning the ninth value of array
            mArray[8] = 1.8;

            //Assigning the tenth value of array
            mArray[9] = 1.9;

            /*PART#1 STEP # 02 */
            //printing the value in the console
            Console.WriteLine("The element at index 0 in the array is " + mArray[0]);

            //printing the value in the console
            Console.WriteLine("The element at index 1 in the array is " + mArray[1]);

            //printing the value in the console
            Console.WriteLine("The element at index 2 in the array is " + mArray[2]);

            //printing the value in the console
            Console.WriteLine("The element at index 3 in the array is " + mArray[3]);

            //printing the value in the console
            Console.WriteLine("The element at index 4 in the array is " + mArray[4]);

            //printing the value in the console
            Console.WriteLine("The element at index 5 in the array is " + mArray[5]);

            //printing the value in the console
            Console.WriteLine("The element at index 6 in the array is " + mArray[6]);

            //printing the value in the console
            Console.WriteLine("The element at index 7 in the array is " + mArray[7]);

            //printing the value in the console
            Console.WriteLine("The element at index 8 in the array is " + mArray[8]);

            //printing the value in the console
            Console.WriteLine("The element at index 9 in the array is " + mArray[9]);

            Console.WriteLine();

            /*PART#2 STEP # 01 */

            //declaring an array of type int with 10 elements
            int[] myArrayint = new int[10];

            //assigning the values to the array using loop
            for (int i = 0; i < 10; i++) {
                
                myArrayint[i] = i;

            }

            /*PART#2 STEP # 02 */

            //printing the values of the array using loop
            for (int i = 0; i < 10; i++)
            {
                //using the loop it reduces the effort 
                //to write multiple line of code
                Console.WriteLine("The element at position " + i + " in the array is " + myArrayint[i]);

            }

            Console.WriteLine();

            /*PART#3 */

            //declaring and initializing integer array
            int[] marksArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            //variable to store the total
            int total = 0;

            //calculating total marks
            for (int i = 0; i < marksArray.Length; i++) {

                total += marksArray[i];
            }

            //printing the total marks, total number of marks and average marks
            Console.WriteLine("The total marks for the student is: " + total);
            Console.WriteLine("This consists of " + marksArray.Length + " marks");
            Console.WriteLine("Therefore the average mark is " + (total / marksArray.Length));

            Console.WriteLine();

            /*PART#4 */
            
            //Declaring an array to store student name 
            String[] studentNames = new string[6];

            //Getting student names from the console
            for (int i = 0; i < 6; i++) {

                Console.WriteLine("Enter Student Name: ");
                studentNames[i] = Console.ReadLine();
            }

            Console.WriteLine();

            //printing student names
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Student Name: "  + studentNames[i]);
            }

            Console.WriteLine();

            /*PART#5 */

            //creating a double array of 10 elements
            double[] dArray = new double[10];

            int currentSize = dArray.Length;
            double currentLargest = 0.0;
            double currentSmallest = 0.0;

            //getting array values from console
            for (int i = 0; i < currentSize; i++) {

                Console.WriteLine("Enter Values: ");
                dArray[i] = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine();

            //printing array values
            for (int i = 0; i < currentSize; i++)
            {

                Console.WriteLine("Array Value at " + i + " is: " + dArray[i]);


            }

            Console.WriteLine();

            currentLargest = dArray[0];
            //finding the currentLargest
            for (int i = 0; i < currentSize; i++)
            {
                Console.WriteLine("Value: " + dArray[i]);
                if (currentLargest < dArray[i]) {

                    currentLargest = dArray[i];
                }

            }

            Console.WriteLine();

            Console.WriteLine("The current Largest Value of Array is: " + currentLargest);

            Console.WriteLine();

            currentSmallest = dArray[0];
            //finding the currentSmallest
            for (int i = 0; i < currentSize; i++)
            {
                Console.WriteLine("Value: " + dArray[i]);
                if (currentSmallest > dArray[i])
                {

                    currentSmallest = dArray[i];
                }

            }

            Console.WriteLine();

            Console.WriteLine("The current Smallest Value of Array is: " + currentSmallest);

            /*PART#6 */

            //Declaring and initializing 2-D Array
            int[,] myArray2D = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

            //Printing the 2-D array
            for (int i = 0; i < myArray2D.GetLength(0); i++) {

                for (int j = 0; j < myArray2D.GetLength(1); j++)
                {

                    Console.Write(myArray2D[i,j] + "\t");

                }
                    Console.WriteLine();
            }

            Console.WriteLine();

            /*PART#7 */

            //Declaring a list of students and initializing it with a new Object
            List<String> myStudentList = new List<String>();

            //Creating an object of random class in .Net
            Random randomValue = new Random();

            //Creating a random number between 1 and 12
            int randomNumber = randomValue.Next(1, 12);

            Console.WriteLine("You now need to add " + randomNumber + " students to your class list");
            for (int i = 0; i < randomNumber; i++) {

                Console.Write("Please Enter Name of The Student " + (i + 1) + ": ");
                myStudentList.Add(Console.ReadLine());
                Console.WriteLine();

            }

            //print the students names to console
            for (int i = 0; i < myStudentList.Count(); i++)
            {

                Console.Write("Name of The Student is " + myStudentList[i]);
                
            }

            Console.WriteLine();

            /*PART#8 */

            int[] array1 = { 1,2,2,1};
            int[] array2 = { 1,2,3,1,3,2,1};
            int[] array3 = { 3,2,1};
            Palindrome(array1);
            Palindrome(array2);
            Palindrome(array3);

            Console.WriteLine();

            /*PART#9 */

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 6, 7, 8, 9 };
            List<int> list3 = new List<int>() { 66, 77, 88, 99 };
            List<int> list4 = new List<int>() { 67, 79, 89, 91 };

            Console.WriteLine("One List of Merged List is");
            Console.WriteLine(String.Join(",", Merge(list1, list2).OrderBy(a => a)));
            Console.WriteLine("One List of Merged List is");
            Console.WriteLine(String.Join(",", Merge(list3, list4).OrderBy(a => a)));

            Console.WriteLine();

            /*PART#10 */

            int[,] array = { { 0, 2, 4, 0, 9, 5 }, { 7, 1, 3, 3, 2, 1 }, { 1, 3, 9, 8, 5, 6 }, { 4, 6, 7, 9, 1, 0 } };

            Console.WriteLine("2-D to 1-D Odd List is");
            Console.WriteLine(String.Join(",", ArrayConversion(array)));


        }//main-thread

        static bool Palindrome(int[] array) {

            // Initialise a bool flag.
            bool isPalindrome = true;
            int arraySize = array.Length;

            // check till half of the array
            for (int i = 0; i <= arraySize / 2 && arraySize != 0; i++)
            {

                // if first and last element are different
                // then set flag to false.
                if (array[i] != array[arraySize - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            // If flag is true then Palindrome
            // else Not Palindrome.
            if (isPalindrome)
            {
                Console.WriteLine(String.Join(",", array) + " is Palindrome");

            }
            else {
                Console.WriteLine(String.Join(",", array) + " is Not Palindrome");
            }
            return isPalindrome;

        }//Palindrome

        static List<int> Merge(List<int> list_a, List<int> list_b) {

            List<int> list = new List<int>();

            if (!(IsListSortedASC(list_a) && IsListSortedASC(list_b)))
            {

                return null;
            }
            else {


                list = JoinList(list_a, list_b);

            }

            return list;

        }//Merge


        public static bool IsListSortedASC(List<int> numbers)
        {
            var orderedAsc = numbers.OrderBy(a => a);

            bool isSorted = numbers.SequenceEqual(orderedAsc);

            return isSorted;
        }

        public static List<int> JoinList(List<int> first, List<int> second)
        {
            if (first == null)
            {
                return second;
            }
            if (second == null)
            {
                return first;
            }

            return first.Concat(second).ToList();
        }

        static int[] ArrayConversion(int[,] array) {

            List<int> list = new List<int>();

            for (int i = 0; i < array.GetLength(0); i++) {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j]%2 != 0) {

                        list.Add(array[i, j]);

                    }
                }
            }

            return list.ToArray();

        }


    }
}
