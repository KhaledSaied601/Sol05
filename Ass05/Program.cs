using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ass05
{
    internal class Program
    {

        static void Swap1(int x, int y)
        {

            int temp = x;
            x = y;
            y = temp;

        } 
        static void Swap2(ref int x,ref int y)
        {

            int temp = x;
            x = y;
            y = temp;

        }

        static int CalculateSumOfDigits(int num)
        {
            int sum = 0; 

             while (num != 0) 
            {
                sum += num % 10;
                num /= 10;
            }
            
            return sum; 
        
        }


        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;

            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }


      static int CalculateFactorial(int num) 
        { int result = 1; 
            for (int i = 1; i <= num; i++) 
            { 
                result *= i;
            } 
            return result;
        }


        static string ChangeChar(string s, int index,char newCharacter)
        {
          char oldChar =  char.Parse(s.Substring(index, 1));
                
            string newString = s.Replace(oldChar, newCharacter);

            return newString;
                
        }

        static void Main(string[] args)
        {



            #region 19 - Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.WriteLine("Enter a number to show identity table");
            //int x = int.Parse(Console.ReadLine());


            //for (int i = 0; i <x; i++) 
            //{


            //    for (int j = 0; j < x; j++)
            //    {


            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");

            //        }
            //    }
            //        Console.WriteLine();
            //}


            #endregion


            #region 20 -  Write a program in C# Sharp to find the sum of all elements of the array.


            //int[] numbers = new int[] { 5, 3, 2,10,8,7 };

            //Console.WriteLine( numbers.Sum());


            #endregion



            #region 21 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            // int[] numbers1 = { 5, 8, 3, 20, 4 };
            // int[] numbers2 = { 30, 2, 0, 22, 10 };

            // int[] mergedNumbers = new int[numbers1.Length*2];



            //Array.ConstrainedCopy(numbers1,0,mergedNumbers,0,numbers1.Length);

            // Array.ConstrainedCopy(numbers2, 0, mergedNumbers, numbers1.Length , numbers2.Length);

            // Array.Sort(mergedNumbers);

            // for (int i = 0;i < mergedNumbers.Length; i++)
            // {
            //     Console.WriteLine(mergedNumbers[i]);

            // }


            #endregion


            #region 22- Write a program in C# Sharp to count the frequency of each element of an array.


            //int[] array = { 5,5,5,5,1, 1,1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            //Array.Sort(array);


            //int freq=1;

            //for (int i = 1; i < array.Length; i++) 
            //{




            //    if (array[i] == array[i - 1] && i != array.Length - 1)
            //    {
            //        freq++;
            //    }

            //    else if(array[i] != array[i - 1] || i == array.Length - 1)
            //    {
            //        Console.WriteLine($"{array[i - 1]} repeated {freq} times");
            //        freq = 1;

            //    }




            //}



            #endregion



            #region   23 - Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] numbers = { 20, 100, 1, 1000 };
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers.Max());

            #endregion

            #region 24- Write a program in C# Sharp to find the second largest element in an array.


            //int[] numbers = { 20, 100, 1, 1000 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[1]);

            #endregion



            #region 25 - Consider an Array of Integer values with size N, having values as  in this Example



            //bool bol=false;
            //int x=0;
            //do
            //{
            //    Console.WriteLine("Enter Size of Array");
            //    bol = int.TryParse(Console.ReadLine(), out  x);

            //}
            //while (bol=false);


            //int[] numbers = new int[x];

            //for (int i = 0; i < numbers.Length; i++) 
            //{

            //    Console.WriteLine($"Enter number {i+1}");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}


            //Console.WriteLine("Enter number to find how many Cells between");

            //int numbToSearchForCells = int.Parse(Console.ReadLine());

            //int firstIndex =  Array.IndexOf(numbers, numbToSearchForCells);

            //int secIndex = Array.LastIndexOf(numbers, numbToSearchForCells);



            //Console.WriteLine((secIndex)-(firstIndex+1));


            #endregion



            #region 26 - Given a list of space separated words, reverse the order of the words.




            //bool bol = false;
            //int x = 0;
            //do
            //{
            //    Console.WriteLine("Enter Size of Array");
            //    bol = int.TryParse(Console.ReadLine(), out x);

            //}
            //while (bol = false);

            //Console.WriteLine("Input Words to Reverse it");


            //string[] words = new string[x];


            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine($"Enter words {i + 1}");
            //    words[i] = Console.ReadLine();
            //}


            //foreach (string word in words) 
            //{



            //    string[] splitedString = word.Split(' ');
            //    StringBuilder reversedString = new StringBuilder();
            //    for (int i = splitedString.Length - 1; i >= 0; i--)
            //    {


            //        reversedString.Append(splitedString[i]);
            //        reversedString.Append(" ");

            //    }

            //    Console.WriteLine(reversedString);



            //}



            #endregion


            #region 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.




            //bool bol = false;
            //int x = 0;
            //do
            //{
            //    Console.WriteLine("Enter Size of Array");
            //    bol = int.TryParse(Console.ReadLine(), out x);

            //}
            //while (bol = false);



            //int[,] numbers = new int[x, x];

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Input Row {i + 1}");

            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Input Col {j + 1}");
            //        numbers[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}





            //int[,] copiedNumbers = new int[x, x];


            //Console.WriteLine("---------------------------------------");

            //for (int i = 0;i < copiedNumbers.GetLength(0); i++)
            //{
            //    for (int j = 0;j < copiedNumbers.GetLength(1); j++)
            //    {
            //        copiedNumbers[i,j] = numbers[i,j];
            //        Console.WriteLine(copiedNumbers[i,j]);
            //    }
            //}



            #endregion



            #region 28- Write a Program to Print One Dimensional Array in Reverse Order

            // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            //int[] reversedNumbers =  numbers.Reverse().ToArray();

            // for (int i = 0; i < reversedNumbers.Length; i++)
            // {

            //     Console.WriteLine(reversedNumbers[i]);

            // }

            #endregion



            #region Functions 1-  Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // in passing by value you change in values not a variable and the variables inside the function they went in stack as a new variable 
            // on the other side you have passing by reference that you get the variable in the function not just value but its the main variable you can change on it and you can save the stack with less variables


            //int x = 10;  
            //int y = 20;

            ////Swap1(x, y);

            //Swap2(ref x, ref y);

            //Console.WriteLine(x);
            //Console.WriteLine(y);


            #endregion


            #region 2 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.



            //Console.WriteLine(CalculateSumOfDigits(25)); 



            #endregion


            #region 3 - Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .

            //Console.WriteLine(IsPrime(5)); 


            #endregion



            #region 4 - Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .


            //Console.WriteLine(CalculateFactorial(5));

            #endregion

            #region  5 - Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter .



            //Console.WriteLine(ChangeChar("Khaled",1,'s'));




            #endregion

        }
    }
}
