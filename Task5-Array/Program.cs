using System;

namespace Task5_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiate randome number for grade
            Random grade = new Random();

            //Declare and create an in array
            int[] studGrade = new int[10];

            //Set grades in array
            for (int i = 0; i < studGrade.Length; i++)
            {
                studGrade[i] = grade.Next(0, 10);
            }

            for (int i = 0; i < studGrade.Length; i++)
            {
                //Declare and create a string to hold the amount fo stars
                string stars = " ";

                //Create a sting with correct number of stars
                for (int j = 0; j < studGrade[i]; j++)
                {
                    stars += "* ";
                }
                
                //Write the resualt
                Console.WriteLine($"Student {i+1} has got {studGrade[i]} : "+ stars);
            }
        }
    }
}
