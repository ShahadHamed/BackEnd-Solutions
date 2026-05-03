namespace project01
{
    internal class Program
    {
        //** Overloading: same method name but with different parameters (inputs).**/


        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static double Add(double a, double b, double c)
        //{
        //    return a + b + c;
        //}

        //static int Add(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("5 + 4 = " + Add(5, 4));
        //    Console.WriteLine("5 + 4 + 3 = " + Add(5, 4, 3));
        //    Console.WriteLine("5 + 4 + 3 + 2 = " + Add(5, 4, 3, 2));
        //}


        //--------------------------------------------------------------

        /*reference: 
         used when I want to send prameters to function and i want change parameters , change effect in variable that I sent and the params should have initial value
         --> variable already has value, can be changed */


        //static void Increase(ref int x)
        //{
        //    x = x + 1;
        //}

        //static void Main(string[] args)
        //{
        //    int num = 5;

        //    Increase(ref num);
        //    Console.WriteLine(num); //6
        //}


        //--------------------------------------------------------------

        /* Out --> variable starts empty, method must assign it */


        //static void Increase(out int x)
        //{

        //    x = 1;
        //}
        //int num;//1
        //static void Main(string[] args)
        //{
        //    int num;//1
        //    Increase(out num);
        //    Console.WriteLine(num);//1


        //--------------------------------------------------------------


        /*    Diff between reference & Out  
        _____________________________________________
                          |   ref      |    out
        ----------------------------------------------
          initial value   |   true     |   false
        ----------------------------------------------
          change value    |   may      |   must
        ----------------------------------------------
          Usage           |  change    |   Assign
                          |    exist   |    new
                          |    value   |    value
        ----------------------------------------------
       */

        // Recursion : A method that calls itself to solve a problem.

        //static void Hello()
        //{
        //      Console.WriteLine("Plz enter your age");
        //      int age = Convert.ToInt32(Console.ReadLine());

        //      if (age < 18 ) 
        //           Hello();
        //      else
        //           return;
        //}

        //static void Main(string[] args)
        //{
        //    Hello();
        //}

        //--------------------------------------------------------------
    }
}