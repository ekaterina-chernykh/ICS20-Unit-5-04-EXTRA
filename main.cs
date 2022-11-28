// Created by: Ekaterina
// Created on: Nov 2022
//
// This program generates random positive or negative number

using System;

class Program
{
    public static void Main(string[] args)
    {
        int age;
        string day;

        // This function accepts user input
        Console.WriteLine("What is your age and day of the week?");
        Console.WriteLine(" ");

        Console.WriteLine("Enter your age ");
        Console.WriteLine(" ");
        age = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine("Enter the day of the week ");
        Console.WriteLine(" ");
        day = (Console.ReadLine());

        Console.WriteLine(" ");
        if ((age <= 5 || age >= 65) || (day == "tuesday" || day == "thursday"))
        {
            Console.WriteLine("You can go to the museum for free ");
        }
        else
        {
            Console.WriteLine("You need to pay for a ticket ");
        }
        Console.WriteLine("\nDone.");
    }
}