/*
 3. Дано целое число N большее 0, найти число, получен-
ное при прочтении числа N справа налево. Например,
если было введено число 345, то программа должна
вывести число 543.
 */


using System;

namespace _03_reverse_digit
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number > 0:\t");
            int digit = Convert.ToInt32(Console.ReadLine());

            while(digit > 0)
            {
                Console.Write(digit % 10);
                digit /= 10;
            }
      
            Console.ReadLine();
        }
    }
}
