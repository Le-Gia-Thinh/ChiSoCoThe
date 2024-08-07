using System;

public class Program
{
    public static void Main(string[] args)
    {
        double height;
        double weight;

        Console.WriteLine("Please enter a height in meters:");
        height = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your weight in kilograms:");
        weight = double.Parse(Console.ReadLine());

        double bmi = weight / Math.Pow(height, 2);
        bmi = Math.Round(bmi, 1);

        Console.WriteLine($"BMI: {bmi}");

        if (bmi < 18.5)
            Console.WriteLine("Classification: Underweight");
        else if (bmi < 25.0)
            Console.WriteLine("Classification: Normal weight");
        else if (bmi < 30.0)
            Console.WriteLine("Classification: Overweight");
        else
            Console.WriteLine("Classification: Obesity");
    }
}
