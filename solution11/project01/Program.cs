using System.Data;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list01 = new List<int>();

            /*===============List================*/

            // list data
            //int datatype (inside the list)
            //list02 list name

            //int[] newarr = { 50, 110, 60, 70, 80, 90 };
            //list01.Add(10);
            //list01.Add(20);
            //list01.Add(30);
            //list01.Add(30);

            //list01.Add(10);
            //list01.Add(40);
            //list01.AddRange(newarr);



            //try
            //{
            //   list01.RemoveAt(4);

            //    foreach (int i in list01)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("//---------------------------------//");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //----------------------------------------------------------
            //1.Add() add element
            //2. Remove() remove first wanted element
            //3.RemoveAt() remove with index 
            //4.Removeall() remove every element applying with condition 
            //5.Count Know the number of element in the list
            //6.AddRange()
            //7.clear clear all of the list
            //8.contains return true or false to know if the element exists
            //9. indexof() returns the first index of the element
            //10. find()
            //11. exist return true or false if there any elemnt applying the conditions
            //----------------------------------------------------------


            //foreach (int i in list01)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("//-----------------------------//");
            //Console.WriteLine(list01.Count);

            //try
            //{
            //    //list01.Clear();
            //    Console.WriteLine(list01.Contains(450));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            /*******************************************************/
            //-------------------Functions--------------------------

            #region Functions


            //int AddTwoNumbers(int x , int y){

            //return x + y

            //}


            //-----------------------------------------------------


            //void AddTwoNumbers(int x, int y)
            //{

            //    Console.WriteLine(x + y);

            //}

            //AddTwoNumbers(5, 10);


            //-----------------------------------------------------


            //void AddTwoNumbers(int x, int y)
            //{

            //    Console.WriteLine(x + y);

            //}

            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            //AddTwoNumbers(x, y);


            //-----------------------------------------------------


            //void AddTwoNumbers(int x, int y)
            //{

            //    Console.WriteLine(x + y);

            //}

            //int Fnum = Convert.ToInt32(Console.ReadLine());
            //int Lnum = Convert.ToInt32(Console.ReadLine());

            //AddTwoNumbers(Fnum, Lnum);


            //-----------------------------------------------------
            /***********************Task**************************/


            double Add(double x, double y)
            {
                return x + y;
            }

            //-----------------------------------------------------

            double Subtract(double x, double y)
            {
                return x - y;
            }

            //-----------------------------------------------------

            double Multiply(double x, double y)
            {
                return x * y;
            }

            //-----------------------------------------------------

            double Divide(double x, double y)
            {
                if (y != 0)
                    return x / y;
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    return 0;
                }
            }

            //-----------------------------------------------------

            bool again = true;

            while (again)
            {
                Console.Write("Enter first number: ");
                double first = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double second = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operation (+ - * /): ");
                char op = Convert.ToChar(Console.ReadLine());

                double result = 0;

                if (op == '+')
                    result = Add(first, second);

                else if (op == '-')
                    result = Subtract(first, second);

                else if (op == '*')
                    result = Multiply(first, second);

                else if (op == '/')
                    result = Divide(first, second);

                else
                {
                    Console.WriteLine("Wrong operation");
                    continue;
                }

                Console.WriteLine("Result = " + result);

                Console.Write("Do you want again? (y/n): ");
                char answer = Convert.ToChar(Console.ReadLine());

                if (answer != 'y' && answer != 'Y')
                    again = false;
            }

            Console.WriteLine("Program ended");


            //-----------------------------------------------------




            #endregion





        }
    }
}
