/*
Write a program in C# to read n number of values in an array and display it in reverse order.

Test Data :
    Input the number of elements to store in the array :3

    Input 3 number of elements in the array :
        element 0 : 2
        element 1 : 5
        element 2 : 7
Expected Output:
    The values store into the array are:
        2 5 7
    The values store into the array in reverse are :
        7 5 2
*/

namespace Assignment_1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads n number of values in an array and displays them in reverse order.");
            Console.WriteLine("The array will only contain integers.");

            // Have user define how many elements they want to store into the array
            Console.WriteLine("\nHow many elements do you want to store in the array?");
            int arrayNumberOfElements = Convert.ToInt32(Console.ReadLine());

            // Create an array of user-defined size
            int[] numberArray = new int[arrayNumberOfElements];

            // Have user select element values for the array
            for (int i = 0; i < arrayNumberOfElements; i++)
            {
                numberArray[i] = InputElement(i);
            }

            // Display the values stored in the array
            DisplayArray(numberArray);

            // Display the array in reverse order
            DisplayReverseArray(numberArray);
        }

        static int InputElement(int element)
        {
            Console.WriteLine($"\nEnter an integer value for element {element}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void DisplayArray(int[] array)
        {
            Console.WriteLine("\nThe values stored into the array are:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }

        static void DisplayReverseArray(int[] array)
        {
            Console.WriteLine("\n\nThe values stored into the array in reverse are:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
