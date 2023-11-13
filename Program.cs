using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array to store student scores
            int[][] studentScores = new int[][]
            {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
            };

            // Print scores of each student
            Console.WriteLine("Student Scores:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Calculate and print average score for each student
            Console.WriteLine("\nAverage Scores:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                double average = CalculateAverage(studentScores[i]);
                Console.WriteLine($"Student {i + 1}: {average:F2}");
            }

            // Calculate and print average score for all students combined
            double overallAverage = CalculateOverallAverage(studentScores);
            Console.WriteLine($"\nOverall Average Score: {overallAverage:F2}");

            Console.ReadKey();
        }

        // Helper method to calculate average of an array of scores
        static double CalculateAverage(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return (double)sum / scores.Length;
        }

        // Helper method to calculate overall average of all students' scores
        static double CalculateOverallAverage(int[][] studentScores)
        {
            int totalSum = 0;
            int totalCount = 0;

            foreach (int[] scores in studentScores)
            {
                foreach (int score in scores)
                {
                    totalSum += score;
                    totalCount++;
                }
            }

            return (double)totalSum / totalCount;
            
        }
        
    }
}
