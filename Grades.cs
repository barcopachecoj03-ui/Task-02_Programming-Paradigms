using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        List<double> grades = Enumerable.Range(1, 5)
            .Select(i => ReadGrade(i))
            .ToList();

        // LINQ A FUNCT
        double maxGrade = grades.Max();
        double minGrade = grades.Min();
        double avgGrade = grades.Average();

        // RE
        Console.WriteLine("\n--- Grade Summary ---");
        Console.WriteLine($"All Grades: {string.Join(", ", grades)}");
        Console.WriteLine($"Maximum:    {maxGrade:F2}");
        Console.WriteLine($"Minimum:    {minGrade:F2}");
        Console.WriteLine($"Average:    {avgGrade:F2}");
    }

    static double ReadGrade(int index)
    {
        Console.Write($"Enter grade {index}: ");
        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            return grade;
        }

        Console.WriteLine("Invalid inser a valid number.");
        return ReadGrade(index); 
    }
}