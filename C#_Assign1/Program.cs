using System;

namespace Task1 
{
    class Program 
    {
        static void Main(string [] args) 
        {
            Console.Write("Enter the number you want (not negative numbers and out of 3 digits): ");
            int num = int.Parse(Console.ReadLine()!);
            string[] englishNum = new string[] {"", "One", "Two", "Three", "Four", "Five",
                                            "Six", "Seven", "Eight", "Nine", "Ten"};
            
            if (num >= 0 && num <= 10) 
            {
                Console.Write(englishNum[num]);
            }
            else if (num > 10 && num < 100) 
            {
                string res = StrResult(num, englishNum);
                Console.WriteLine(res);
            }
            else if (num >= 100 && num < 1000) 
            {
                int hundreds = num / 100;
                if (num % 100 == 0) Console.Write($"{englishNum[hundreds]} hundred");
                else if (num % 100 >= 1 && num % 100 <= 9) 
                    Console.Write($"{englishNum[hundreds]} hundred and {englishNum[num % 100]}");
                else 
                    Console.Write($"{englishNum[hundreds]} hundred and {StrResult(num % 100, englishNum)}");
            }
            else Console.Write("out of ability");
        }

        static string StrResult(int num, string[] array)  
        {
            string[] englishNum = new string[] {"Eleven", "Twelve", "Thirdteen", "Fourteen", "Fithteen"};
            string result = "";
            int dozen = num / 10;
            int unit = num % 10;
            
            switch (dozen) 
            {
                case 1:
                    if (unit >= 1 && unit <= 5) result = englishNum[unit - 1];
                    else if (unit >= 6 && unit <= 9) result = array[unit] + "teen";
                    break;
                case 2:
                    result = "Twenty " + array[unit];
                    break;
                case 3:
                    result = "Thirty " + array[unit];
                    break;
                case 4:
                    result = "Forty " + array[unit];
                    break;
                case 5:
                    result = "Fifty " + array[unit];
                    break;
                case 6:
                    result = "Sixty " + array[unit];
                    break;
                case 7:
                    result = "Seventy " + array[unit];
                    break;
                case 8:
                    result = "Eighty " + array[unit];
                    break;
                case 9:
                    result = "Ninety " + array[unit];
                    break;
            }
            return result;
        }
    }
}
