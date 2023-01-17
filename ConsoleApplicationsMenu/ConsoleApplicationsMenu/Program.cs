using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading;

namespace ConsoleApplicationsMenu
{
    public class Menu
    {
        public string input = "";
        public void Menus()
        {

            string input;
        begin:
            Console.WriteLine(
           "\n\n\t...................ConsoleApplicationsMenu...................\n\n" +
           "\t\t\tWHAT WOULD YOU LIKE TO DO?\n\n" +
           "\t\t 1. Check for Prime Number\n" +
           "\t\t 2. Check if a Number is Even Or Odd\n" +
           "\t\t 3. Create if a String is Palindrome or Not\n" +
           "\t\t 4. Create if a Number is Palindrome or Not\n" +
           "\t\t 5. Swap numbers\n" +
           "\t\t 6. Check for Leap Year\n" +
           "\t\t 7. Generate Students' MarketSheet\n" +
           "\t\t 8. Reverse Strings\n" +
           "\t\t 9. Get substrings of a given string\n" +
           "\t\t 10. Make Conversions\n" +
           "\t\t 11. Press 11 to Exit \n"
            );
            Console.Write("Pick One Option:");
            input = Console.ReadLine();
            if (input == "1") goto PrimeNumberCheck;
            if (input == "2") goto IsOddOrEven;
            if (input == "3") goto IsStringPalindrome;
            if (input == "4") goto IsNumberPalindrome;
            if (input == "5") goto SwapNumbers;
            if (input == "6") goto IsLeapYear;
            if (input == "7") goto GenerateMarkSheet;
            if (input == "8") goto StringReverse;
            if (input == "9") goto SubStrings;
            if (input == "10") goto Conversion;
            if (input == "11") System.Environment.Exit(1);
            Console.WriteLine("Invalid option!");
            goto begin;

        PrimeNumberCheck:
            {
                int num, i, m = 0, flag = 0;
                Console.Write("Enter the Number to check if Prime: ");

                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }

                m = num / 2;

                for (i = 2; i <= m; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("Number is not Prime.");
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("Number is Prime.");
                }
                goto begin;
            }
        IsOddOrEven:
            {

                int num1;
                Console.Write("Enter a Number : ");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }


                if (num1 % 2 == 0)
                {
                    Console.WriteLine(num1 + " is an Even Number");
                }
                else
                {
                    Console.WriteLine(num1 + " is an Odd Number");
                }
                goto begin;
            }
        IsStringPalindrome:
            {
                string initial = "";
                string userInput;
                do
                {
                    Console.WriteLine("Enter a String to check for Palindrome");
                    userInput = Console.ReadLine();
                }
                while (userInput.Any(y => !char.IsLetter(y)));



                int iLength = userInput.Length;

                if (iLength == 0)
                {
                    Console.WriteLine("You did not enter the string");

                }
                else
                {
                    for (int j = iLength - 1; j >= 0; j--)
                    {
                        initial = initial + userInput[j];
                    }
                    if (initial == userInput)
                    {
                        Console.WriteLine(userInput + " is palindrome");
                    }
                    else
                    {
                        Console.WriteLine(userInput + " is not a palindrome");
                    }

                }
                goto begin;
            }

        IsNumberPalindrome:
            {
                int num2 = 0, reverseNumber = 0, temp, rem;

                Console.Write("Enter a Number : ");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }

                temp = num2;

                while (temp != 0)
                {
                    rem = temp % 10;
                    temp = temp / 10;
                    reverseNumber = reverseNumber * 10 + rem;
                }

                if (num2 == reverseNumber)
                {
                    Console.WriteLine(num2 + " is a palindrome number");
                }
                else
                {
                    Console.WriteLine(num2 + " is not a palindrome number");
                }

                goto begin;
            }

        SwapNumbers:
            {

                int num3, num4, temp;

                Console.Write("\nEnter the first Number : ");
                while (!int.TryParse(Console.ReadLine(), out num3))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }
                Console.WriteLine("\nEnter the Second Number : ");
                while (!int.TryParse(Console.ReadLine(), out num4))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }

                temp = num3;
                num3 = num4;
                num4 = temp;

                Console.WriteLine("After Swapping : ");
                Console.WriteLine("First Number : " + num3);
                Console.WriteLine("Second Number : " + num4);
                goto begin;
            }
        SubStrings:
            {
                string value, substring;
                int j, i;
                string[] myArray = new string[20];
                do
                {
                    Console.WriteLine("Enter a String : ");
                    value = Console.ReadLine();
                }
                while (value.Any(y => !char.IsLetter(y)));
                Console.WriteLine(" All Possible substrings of the given string are : ");
                for (i = 1; i <= value.Length; i++)
                {
                    for (j = 0; j <= value.Length - i; j++)
                    {
                        substring = value.Substring(j, i);
                        myArray[j] = substring;
                        Console.WriteLine(myArray[j]);
                    }
                }
                goto begin;
            }
        IsLeapYear:
            {


                int num5;
                Console.Write("Enter the Year in Four Digits : ");
                while (!int.TryParse(Console.ReadLine(), out num5))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }

                if ((num5 % 4 == 0 && num5 % 100 != 0) || (num5 % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year", num5);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year", num5);
                }

                goto begin;
            }
        GenerateMarkSheet:
            {

                int num6, num7, num8, num9, num10;
                float result;
                string name;
                while (!int.TryParse(Console.ReadLine(), out num6))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }
                Console.WriteLine("Enter Student Name :");
                do
                {
                    Console.WriteLine("Enter student's name please");
                    name = Console.ReadLine();
                }
                while (name.Any(y => !char.IsLetter(y)));
                Console.WriteLine("Mark of Subject1 : ");
                while (!int.TryParse(Console.ReadLine(), out num7))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }
                Console.WriteLine("Mark of Subject2 : ");
                while (!int.TryParse(Console.ReadLine(), out num8))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }
                Console.WriteLine("Mark of Subject3 : ");
                while (!int.TryParse(Console.ReadLine(), out num9))
                {
                    Console.WriteLine("invalid input, please enter only a number");
                }

                num10 = num7 + num8 + num9;
                result = num10 / 3.0f;
                Console.WriteLine("Total : " + num10);
                Console.WriteLine("Percentage : " + result);
                if (result >= 35 && result < 50)
                {
                    Console.WriteLine("Grade is D");
                }
                if (result >= 50 && result <= 60)
                {
                    Console.WriteLine("Grade is C");
                }
                if (result > 60 && result <= 80)
                {
                    Console.WriteLine("Grade is B");
                }
                if (result > 80 && result <= 100)
                {
                    Console.WriteLine("Grade is A");
                }
                goto begin;

            }
        StringReverse:
            string Str, reversestring = "";
            int Length;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reversestring);
            {
                goto begin;
            }
        Conversion:
            Console.WriteLine(
            "\n\n\t...................Pick one Conversion Option...................\n\n" +
            "\t\tType A to Convert from decimal to binary.\n" +
            "\t\tType B to Convert from binary to decimal.\n"
             );
            input = "";

            while (input != "A" && input != "B" && input != "C" && input != "D" && input != "E")
            {
                Console.WriteLine("\nPlease select A or B");
                input = Console.ReadLine();
                input = input.ToUpper();
            }
            if (input == "A") goto A;
            if (input == "B") goto B;

            A:
            {
                int num11;
                Console.Write("Enter a Number : ");
                while (!int.TryParse(Console.ReadLine(), out num11))
                {

                    Console.WriteLine("invalid input, please enter only a number");
                }
                int quot;
                string rem = "";
                while (num11 >= 1)
                {
                    quot = num11 / 2;
                    rem += (num11 % 2).ToString();
                    num11 = quot;
                }
                string bin = "";
                for (int i = rem.Length - 1; i >= 0; i--)
                {
                    bin = bin + rem[i];
                }
                Console.WriteLine("The Binary format for given number is {0}", bin);
                goto begin;
            }
        B:
            {
                int num12, binary_val, decimal_val = 0, base_val = 1, rem;
                Console.Write("Enter a Binary Number(1s and 0s) : ");
                while (!int.TryParse(Console.ReadLine(), out num12))
                {

                    Console.WriteLine("invalid input, please enter only  numbers 1 or 0");
                }/* maximum five digits */
                binary_val = num12;
                while (num12 > 0)
                {
                    rem = num12 % 10;
                    decimal_val = decimal_val + rem * base_val;
                    num12 = num12 / 10;
                    base_val = base_val * 2;
                }
                Console.Write("The Binary Number is : " + binary_val);
                Console.Write("\nIts Decimal Equivalent is : " + decimal_val);
                goto begin;
            }
        }
    }
}
