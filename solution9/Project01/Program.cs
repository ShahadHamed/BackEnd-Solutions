using System.Diagnostics;

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*================Multidimensional Arrays==================*/

            #region Multidimensional Arrays
            //Console.WriteLine("Enter the number of rows:");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns:");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //int[,] numbers = new int[rows, columns];


            //Console.WriteLine("---------------------------");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Plz Enter element for [{i},{j}]: ");
            //        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("//The matrix=============");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(numbers[i , j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            /*====================Jagged array====================*/


            //int[][] num02 = new int[3][];

            //num02[0] = new int[3];
            //num02[1] = new int[2];
            //num02[2] = new int[4];
            //num02[0][0] = 1;
            //num02[0][1] = 20;
            //num02[0][2] = 30;
            //num02[1][0] = 40;
            //num02[1][1] = 50;
            //num02[2][0] = 60;
            //num02[2][1] = 70;
            //num02[2][2] = 80;
            //num02[2][0] = 90;


            //int[][] num03 =
            //{
            //   new int []{10,20,30},
            //   new int []{40,50},
            //   new int []{60,70,80,90},
            //};

            //Console.WriteLine(num03[0][2]);


            //--------------------------------------------------
            /* -- Assignment - Student Management System Using Arrays (C#) -- */


            //Part 1 – Student Names(One Dimensional Array)


            int students = 2;
            int subjects = 3;

            string[] subjectNames = { "English", "Science", "Math" };
            string[] studentNames = new string[students];

            Console.WriteLine("Enter student names:");
            for (int i = 0; i < students; i++)
            {
                Console.Write($"Student {i + 1} Name: ");
                studentNames[i] = Console.ReadLine();
            }

         
            // Part 2 – Student Grades (2D Array)
          

            int[,] grades = new int[students, subjects];

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"\nEnter grades for {studentNames[i]}:");

                for (int j = 0; j < subjects; j++)
                {
                    Console.Write($"{subjectNames[j]}: ");

                    int value;
                    while (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.Write("Invalid input. Enter a number: ");
                    }

                    grades[i, j] = value;
                }
            }

            
            // Part 3 – Display Student Grades
            

            Console.WriteLine("\n// Grades Table ----------------------------------------");

            Console.Write("Student\t\t");

            for (int j = 0; j < subjects; j++)
            {
                Console.Write(subjectNames[j] + "\t\t");
            }
            Console.WriteLine();

            for (int i = 0; i < students; i++)
            {
                Console.Write($"{studentNames[i]}\t\t");

                for (int j = 0; j < subjects; j++)
                {
                    Console.Write(grades[i, j] + "\t\t");
                }

                Console.WriteLine();
            }

            
            // Part 4 – Calculate Student Average
            

            Console.WriteLine("\n// Student Averages ---------------------------------");

            double[] averages = new double[students];

            for (int i = 0; i < students; i++)
            {
                int sum = 0;

                for (int j = 0; j < subjects; j++)
                {
                    sum += grades[i, j];
                }

                averages[i] = (double)sum / subjects;

                Console.WriteLine($"{studentNames[i]} - Average: {averages[i]:F2}");
            }

           
            // Part 5 – Jagged Array
            

            Console.WriteLine("\n// Jagged Array Input -------------------------------");

            int[][] jaggedGrades = new int[students][];

            for (int i = 0; i < students; i++)
            {
                Console.Write($"\nEnter number of subjects for {studentNames[i]}: ");
                int numSubjects = Convert.ToInt32(Console.ReadLine());

                jaggedGrades[i] = new int[numSubjects];

                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write($"Enter grade {j + 1}: ");

                    int value;
                    while (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.Write("Invalid input. Enter a number: ");
                    }

                    jaggedGrades[i][j] = value;
                }
            }

            Console.WriteLine("\n// Jagged Array Output ------------------------------");

            for (int i = 0; i < students; i++)
            {
                Console.Write($"{studentNames[i]} - ({jaggedGrades[i].Length} subjects): ");

                for (int j = 0; j < jaggedGrades[i].Length; j++)
                {
                    Console.Write(jaggedGrades[i][j] + " ");
                }

                Console.WriteLine();
            }


            // Part 6 – Search for Student

            Console.WriteLine("\n-----------------------------------------------------");

            Console.Write("\nEnter student name to search: ");
            string searchName = Console.ReadLine();

            int foundIndex = -1;

            for (int i = 0; i < students; i++)
            {
                if (!string.IsNullOrEmpty(studentNames[i]) &&
                    studentNames[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                Console.WriteLine($"Student found at index: {foundIndex} ({studentNames[foundIndex]})");
            }
            else
            {
                Console.WriteLine("Student was not found.");
            }


            // Part 7 – Find Highest Grade

            Console.WriteLine("\n-----------------------------------------------------");

            int highest = int.MinValue;

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < subjects; j++)
                {
                    if (grades[i, j] > highest)
                    {
                        highest = grades[i, j];
                    }
                }
            }

            Console.WriteLine($"\nHighest grade in the system: {highest}");

            Console.WriteLine("\n-----------------------------------------------------");

            #endregion
        }
    }
}
