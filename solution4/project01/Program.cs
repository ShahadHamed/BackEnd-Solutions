namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*===== control statement ======*/
            // 1. conditinal statement (if, switch)
            // 2. loop statement


            /*----Practices----*/

            //int x = 20;

            //if (x > 20) 
            //{
            //    Console.WriteLine("x is grater than 20 ");
            //}
            //else
            //{
            //    Console.WriteLine("x is less than 20 ");
            //}



            //------------------------------------------------------
            //40=>50 red
            //30=>40 green
            //0=>30 yellow


            //int x = Convert.ToInt32(Console.ReadLine());

            //if (x > 50)
            //{
            //    Console.WriteLine("red ");
            //}
            //else if (x > 40)
            //{
            //    Console.WriteLine("green");
            //}
            //else if (x > 0 )
            //{
            //    Console.WriteLine("yellow");
            //}


            //------------------------------------------------------

            //Console.WriteLine("plz enter your child gender: ");
            //string gender = Console.ReadLine();

            //Console.WriteLine("plz enter your child Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());


            //if (gender == "boy")
            //{
            //   if (Age > 16 || Age < 4)
            //    {
            //        Console.WriteLine("we accepts boys from 4-16 years");
            //    }
            //    else if (Age > 12)
            //    {
            //        Console.WriteLine("Football");
            //    }
            //    else if (Age > 9)
            //    {
            //        Console.WriteLine("Swimming");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("drawing");
            //    }
            //}


            //else if (gender == "girl")
            //{
            //    if (Age > 18 || Age < 6)
            //    {
            //        Console.WriteLine("we accepts Girls from 6-18 years");
            //    }
            //    else if (Age > 12)
            //    {
            //        Console.WriteLine("Dansing");
            //    }
            //    else if (Age > 9)
            //    {
            //        Console.WriteLine("hoursing");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Singing");
            //    }
            //}


            //else
            //{
            //    Console.WriteLine("Invaild Gender");
            //}



            //------------------------------------------------------
            //Task 1 : Positive, Negative or zero


            //Console.WriteLine("plz enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num > 0)
            //{
            //    Console.WriteLine("Positive");
            //}

            //else if (num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}

            //else
            //{
            //    Console.WriteLine("Zero");
            //}



            //------------------------------------------------------
            //Task 2 : Even or Odd


            //Console.WriteLine("plz enter an integer number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}



            //------------------------------------------------------
            //Task 3 : Student Grade System


            //Console.WriteLine("plz enter a student score : ");
            //int num = Convert.ToInt32(Console.ReadLine());


            //if (num > 90 && num <= 100)
            //{
            //    Console.WriteLine("Excellant");
            //}
            //else if (num > 75 && num < 89)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (num > 60 && num < 74)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (num > 50 && num < 59)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else if (num >= 0 && num < 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("The score must be between 0 to 100");
            //}



            //------------------------------------------------------
            //Task 4 : Simple Login System


            //Console.WriteLine("please enter your username : ");
            //string username = Console.ReadLine();

            //Console.WriteLine("please enter your password: ");
            //int pass = Convert.ToInt32(Console.ReadLine());


            //if (pass == 1234 && username == "admin")
            //{
            //    Console.WriteLine("Login Successful");
            //}
            //else
            //{
            //    Console.WriteLine("Invaild username or password");
            //}



            //------------------------------------------------------
            //Task 5 : Simple ATM System


            //int balance = 1000;
            //Console.WriteLine("please enter a withdrawal Amount: ");
            //int amount = Convert.ToInt32(Console.ReadLine());


            //if (amount <= 0)
            //{
            //    Console.WriteLine("Invaild Amount");
            //}
            //else if (amount > balance)
            //{
            //    Console.WriteLine("Insufficient Balance");
            //}
            //else if (amount <= balance)
            //{
            //    balance = balance - amount;
            //    Console.WriteLine("Withdrawal Successful");
            //    Console.WriteLine($"Remaining balance = {balance}");
            //}



        }
    }
}
