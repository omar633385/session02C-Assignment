﻿namespace session_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter number");
            //int input;
            //int.TryParse(Console.ReadLine(),out input);
            //for (int i = 1; i <=input ; i++)
            //{
            //    Console.WriteLine(i);
            //    
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            Console.WriteLine("Enter number");
            int input;
            int.TryParse(Console.ReadLine(), out input);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i*input);

            }

            #endregion
        }
    }
}