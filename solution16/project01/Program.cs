using System;
using System.Collections.Generic;


//public class Room
//{
//    public string Name;
//    public Room (string name)
//    {
//        Name = name;
//    }
//}

//public class House
//{
//    public string Address;
//    private List<Room> rooms;   
//    public House (string address)
//    {
//        Address = address;
//        rooms.Add(new Room("Living Room"));
//        rooms.Add(new Room("Bed Room"));
//        rooms.Add(new Room("Living02 Room"));
//    }
//    public void showRooms()
//    {
//        foreach(var x in rooms)
//        {
//            Console.WriteLine(x.Name);
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//            House hh = new House("Sur");
//        hh.showRooms();
//    }
//}

//-----------------------------------------------------------------------------
//***SOLID principle***//


//namespace project01
//{
//    // interface
//    interface IMessage
//    {
//        void Send();
//    }
//    // open close
//    class Email : IMessage
//    {
//        public void Send()
//        {
//            Console.WriteLine("Email Sent ");
//        }
//    }
//    //another class add
//    class SMS : IMessage
//    {
//        public void Send()
//        {
//            Console.WriteLine("SAend SMS");
//        }
//    }
//    //
//    class Notification
//    {
//        // Dependency
//        private IMessage message;

//        public Notification(IMessage m)
//        {
//            message = m;
//        }
//        //method for send message
//        public void Notify()
//        {
//            message.Send();
//        }

//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                // liskove principle
//                IMessage email = new Email();
//                Notification n1 = new Notification(email);
//                n1.Notify();

//                IMessage sms = new SMS();
//                Notification n2 = new Notification(sms);
//                n2.Notify();



//            }
//        }
//    }
//}


//-----------------------------------------------------------------------------

//*** async , await , Task ***//

//namespace project01
//{
    //internal class Program
    //{
    //    static async Task Main(string[] args)
    //    {
    //        Console.WriteLine("Start");
    //        await Task.Delay(3000);
    //        Console.WriteLine("End");
    //    }
    //}

    //***************************

    //internal class Program
    //{
    //    static async  Task Main(string[] args)
    //    {
    //        int num = await GetNumber();
    //        Console.WriteLine(num); 
    //    }
    //    static async Task<int> GetNumber()
    //    {
    //        await Task.Delay(2000);
    //        return 10;
    //    }
    //}

    //***************************

    //internal class Program
    //{
    //    static async Task Main(string[] args)
    //    {
    //        Console.WriteLine("Hello before method");

    //        string num = await GetNumber();

    //        Console.WriteLine(num);

    //        Console.WriteLine("Hello after method");
    //    }

    //    static async Task<string> GetNumber()
    //    {
    //        await Task.Delay(2000);

    //        return "Hello from async method";
    //    }
    //}

//}

//-----------------------------------------------------------------------------


