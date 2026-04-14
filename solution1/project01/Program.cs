namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
//ValueTask datatypes
            int x = 10; 
            long y = 9999997896;
            float x2 = 2.5f;
            double x3 = 12.5;
            decimal x4 = 45.45m;
            bool hasWife = true;
            char latter = 'D';

//Reference Dtatatypes

            string name = "shahad";

 //var vs const
            var g = "tasnim";

            const int x5 = 20;




            //Console.WriteLine("plz enter your name");
            //string username01= Console.ReadLine();

            //Console.WriteLine("plz enter your Age");
            //string userAge01 = Console.ReadLine();

            //Console.WriteLine($"My name {username01}, and I'm {userAge01} years old");



            //int t1 = 10;
            //double result = t1;

            //Console.WriteLine(result);


            //double t1 = 10.5;
            //int s1= (int)t1;
            //Console.WriteLine(s1);


            Console.WriteLine("plz enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("plz enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1}+{num2}={num1+num2}");
            Console.WriteLine($"{num1}*{num2}={num1 * num2}");
            Console.WriteLine($"{num1}-{num2}={num1 - num2}");
            Console.WriteLine($"{num1}/{num2}={num1 / num2}");

        }
    }
}
