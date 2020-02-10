using System;

namespace Assignment1_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n: "); // Main function for printing pattern with a value of n
            string str = Console.ReadLine();
            int n = int.Parse(str);
            PrintPattern(n);

            Console.WriteLine("Enter the value of m: ");// Main function for printing the series with a sum of previous two variables
            string str2 = Console.ReadLine();
            int n2 = int.Parse(str2);
            PrintSeries(n2);

            Console.WriteLine("Enter time: "); //Main function for printing the USF time converted from the 12 hour time format
            string str5 = Console.ReadLine();
            DateTime dateFromString =
            DateTime.Parse(str5, System.Globalization.CultureInfo.InvariantCulture);
            UsfTime(dateFromString.ToString());

            Console.WriteLine("Enter the value of n3: "); //Accepting the n3 value for qustion 4
            string str3 = Console.ReadLine();
            int n3 = int.Parse(str3);

            Console.WriteLine("Enter the value of k: "); //Accepting the k value for qustion 4
            string str4 = Console.ReadLine();
            int k = int.Parse(str4);
            Console.WriteLine();

            Console.WriteLine();
            UsfNumbers(n3, k); //Main function for printing the position of palindrome pairs.

            Console.WriteLine();
            PalindromePairs();  //Main function for getting an input that prints a series with a change of line after every 11 digits

            int n4 = 5;
            Stones(n4); //Main function for drawing a heap of rocks and printing the winning conditions
        }

        // Time to string function


        // Question 1
        public static void PrintPattern(int n)
        {
            for (int i = n; i > 0; i = i - 1) // Loop for number of rows
            {
                for (int j = i; j > 0; j = j - 1) // Loop for printing the digits
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        // Reflection: Learned nested loops from W3 schools, took approximately 5 hours.

        // Question 2
        public static void PrintSeries(int n2)
        {
            int sum = 0;
            for (int i = 1; i <= n2; i = i + 1) //Loop for initializing incrementing digits
            {
                sum = 0;
                for (int j = 1; j <= i; j = j + 1) //Loop for initializing the next digit that needs to be added: It will run upto the prevoius digit to sum the subsequent digits.
                {

                    sum = sum + j; // Sum of the two initialized digits
                }
                Console.Write(sum + " "); //Printing the sum

            }

            Console.WriteLine();
        }
        // Reflection: Learned nested loops from W3 schools, this particular question took around 3 hours. I learned that the sum has to be reset to 0 after every iteration of the inner loop so I can calculate a fresh sum.

        //Question 3
        public static void UsfTime(string s)
        {
            Console.WriteLine(s); //Printing the time
        }


        // I learned how to use the datetime function in c#, in theory, we should convert all to seconds, then use seconds as a base and then divide the seconds in accordance to the USF time format. However, I was unable to code this. 
        // I tried this question for approximately 3 hours.

        // Question 4
        public static void UsfNumbers(int n3, int k)
        {

            for (int j = 1; j <= n3; j = j + 1) // Loop for the digits to be initialized and incremented
            {

                if (j % 3 == 0 && j % 5 != 0 && j % 7 != 0) // Condition to check if a number is a multiple of 3 and not of 5 or 7 and printing a U in its place
                {
                    Console.Write("U ");
                    if (j % k == 0) // Condition to check if we have printed the 11th digit or not.
                        Console.WriteLine();
                }
                else if (j % 5 == 0 && j % 3 != 0 && j % 7 != 0)// Condition to check if a number is a multiple of 5 and not of 3 or 7 and printing a S in its place
                {
                    Console.Write("S ");
                    if (j % k == 0)
                        Console.WriteLine();
                }
                else if (j % 7 == 0 && j % 3 != 0 && j % 5 != 0) // Condition to check if a number is a multiple of 7 and not of 5 or 3 and printing a F in its place
                {
                    Console.Write("F ");
                    if (j % k == 0)
                        Console.WriteLine();
                }
                else if (j % 5 == 0 && j % 3 == 0 && j % 7 != 0) // Condition to check if a number is a multiple of 3 and 5 and not of 7 and printing a US in its place
                {
                    Console.Write("US ");
                    if (j % k == 0)
                        Console.WriteLine();
                }
                else if (j % 5 == 0 && j % 3 != 0 && j % 7 == 0) // Condition to check if a number is a multiple of 7 and 5 and not of 3 and printing a SF in its place
                {
                    Console.Write("SF ");
                    if (j % k == 0)
                        Console.WriteLine();
                }
                else if (j % 5 != 0 && j % 3 == 0 && j % 7 == 0) // Condition to check if a number is a multiple of 7 and 3 and not of 5 and printing a UF in its place
                {
                    Console.Write("UF ");
                    if (j % k == 0)
                        Console.WriteLine();
                }
                else if (j % 5 == 0 && j % 3 == 0 && j % 7 == 0) // Condition to check if a number is a multiple of 3, 7 and 5 and printing USF in its place
                {
                    Console.Write("USF ");
                    if (j % k == 0)
                        Console.WriteLine();
                }

                else
                {
                    Console.Write(j + " "); // If no condition is met we just print the digit as is.
                    if (j % k == 0)
                        Console.WriteLine();
                }

            }

            Console.WriteLine();

        }
        // This question was more complicated than others, especially the printing part as I had to change the line everytime I printed 11 characters. So I had to add a check for every condition if it had printed 11 characters or not. 
        // The conditions took a while to figure out as there were a lot of corner cases. 
        // This question took approximately 6 hours.

        //Question 5:
        public static void PalindromePairs()
        {
            string[] words = new string[3] { "bat", "tab", "cat" }; // initializing an array of string.


            for (int i = 0; i < 3; i = i + 1)
            {
                for (int j = 0; j < 3; j = j + 1)
                {


                    if ((words[i] + words[j]) == (words[j] + words[i])) // Checking if the sum of two words are a palindrome or not
                    {
                        Console.Write("[" + i + "," + j + "]");
                    }
                }


            }

            Console.WriteLine();

        }


        // This question was extremely challenging as I did not know how to execute functions regarding palindromes.
        // This question took approximately 4 hours.

        //Question 6:
        public static void Stones(int n4)
        {


            if ((n4 % 4) != 0) // If the number of rocks is a multiple of four, the first person to start or the first person to reach the mark where only four stones are left will lose.
            {
                Console.WriteLine("You will win if you start first");
            }
        }

    }

}
// Tried understanding this and coding but was unable to figure out the permutation and combinations required for winning.
// I understand that when there are 4 stones left, the person who's turn it is will lose. However, was unable to explain that in code. 
// This question took 2             hours.