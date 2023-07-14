using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[] {  85, 92, 78  };
            studentScores[1] = new int[] {  90, 87, 93, 89  };
            studentScores[2] = new int[] {  76, 88  };

            int Alltotal = 0;
            int count1 = 0;
            Console.WriteLine("Stored Students Scores");
            for (int i = 0; i < studentScores.Length; i++)
            {
                //Printing Each Student Scores

                Console.WriteLine("\n*****************************************");
                Console.Write($"Scores of Student {i + 1}:\t ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + "\t");
                }


                //Calculating the average
                int total = 0;
                int average;
                Console.Write("\nAverage :\t ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    total += studentScores[i][j];
                    count1++;
                }
                average = total / studentScores[i].Length;
                Console.WriteLine(average);
                Alltotal += total;


            }
            //Calculating the average score of all students
            Console.WriteLine("\n*****************************************");
            Console.Write("Average Score of all Students :\t");
            double totalAverage = (double)Alltotal / count1;
            Console.Write(totalAverage);
            
            Console.ReadKey();
        }
    }
}
