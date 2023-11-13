using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignmentJArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a jagged array to store the scores of three students
            int[][] studentScores = new int[][]
            {
               new int[] { 85, 92, 78 },
               new int[] { 90, 87, 93, 89 },
               new int[] { 76, 88 }
            };

            // Print the scores of each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                foreach (int score in studentScores[i])
                {
                    Console.WriteLine(score);
                }
            }

            // Calculate the average score for each student
            double[] studentAverages = new double[studentScores.Length];
            for (int i = 0; i < studentScores.Length; i++)
            {
                double totalScore = 0;
                foreach (int score in studentScores[i])
                {
                    totalScore += score;
                }
                studentAverages[i] = totalScore / studentScores[i].Length;
            }

            // Print the average score for each student
            for (int i = 0; i < studentAverages.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} average: {studentAverages[i]:F2}");
            }

            // Calculate the average score for all students combined
            double overallAverage = 0;
            foreach (double average in studentAverages)
            {
                overallAverage += average;
            }
            overallAverage /= studentAverages.Length;

            // Print the average score for all students combined
            Console.WriteLine($"Overall average: {overallAverage:F2}");
        }
    }
}
