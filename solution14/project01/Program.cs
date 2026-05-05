namespace project01
{
    internal class Program
    {
        /*---OOP (Object-Oriented Programming): programming approach to better simulate reality---*/
        //class : Blueprint ,  Object: A copy of the class

        //inaitail value of properties will be null --> string , 0 --> int

        //Getters {get}: only read it , Setters {set}:Assigns value

        /*Access Modifiers: 1.public -> Accessible everywhere
                            2.private -> Access inside the class only
                            3.protected -> Accessible with inheritance (الوارثين منه)
                            4.internal -> Same project only */

        //Constructor: organize code , Reduce errors , Make code cleaner , same as class name


        //-----------------------------------------------------------------------------------------


        //class Car
        //{
        //    public string color ;
        //    public int model_year;
        //    private int temp =10;

        //    public int Speed 
        //    { 
        //        get { return temp; } 
        //        set 
        //        { 
        //            if (value > 0 )
        //                temp = value;
        //        } 
        //    }

        //    public void Drive()
        //    {
        //        Console.WriteLine("Hi!!!");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Car my_car = new Car();

        //    my_car.color = "Red";
        //    my_car.model_year = 2000;

        //    Console.Write("plz enter speed: ");
        //    my_car.Speed = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(my_car.Speed);
        //}


        //----------------------------------------------------------------

        //*****Constructor function*****


        //class Car
        //{
        //    public string color;
        //    public int age;
        //    public Car(String c, int a)
        //    {
        //        color = c;
        //        age = a;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Car myCar = new Car("black", 24);
        //    Console.WriteLine(myCar.color);
        //    Console.WriteLine(myCar.age);
        //}

        //------------------------------------------------------------------

        class Car
        {
            public string color;
            public int age;
            public Car(String c, int a)
            {
                color = c;
                age = a;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter color:");
            string color = Console.ReadLine();
            Console.WriteLine("Enter ur age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Car my_car = new Car(color, age);
            Console.WriteLine(my_car.color);
            Console.WriteLine(my_car.age);
        }

    }
}
