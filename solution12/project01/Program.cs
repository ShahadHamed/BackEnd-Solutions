namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack 
            /* LIFO "Last in first out" */


            #region Stack

            //Stack<int> number= new Stack<int>();//generic

            ////Adds an item
            //number.Push(1);
            //number.Push(2);
            //number.Push(3);
            //number.Push(4);

            ////delete last element
            //number.Pop();

            ////return last element 
            //Console.WriteLine(number.Peek());

            #endregion

            //---------------------------------------------------------------
            //Queue

            #region Queue

            //Enqueue == push "Adds an item"
            //DeQueue == pop "Remove item "
            //peek "Returns the front item"
            //count

            //Queue<string> names = new Queue<string>();

            //names.Enqueue("shahad");
            //names.Enqueue("tasnim");
            //names.Enqueue("sharoq");

            //Console.WriteLine(names.Peek());

            #endregion

            //--------------------------------------------------------------
            /*Task*/

            #region TASK1

            //Stack<string> stack = new Stack<string>();


            //stack.Push("Shahad");
            //stack.Push("Tasnim");
            //stack.Push("Sharoq");
            //stack.Push("Mohammed");
            //stack.Push("Abdullah");

            //int choice;

            //do
            //{
            //    Console.WriteLine("\n1. Add String");
            //    Console.WriteLine("2. Print Strings");
            //    Console.WriteLine("3. Delete Last Element");
            //    Console.WriteLine("4. Show All Elements");
            //    Console.WriteLine("5. Exit");

            //    Console.Write("\nEnter your choice: ");
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter name: ");
            //            string name = Console.ReadLine();
            //            stack.Push(name);
            //            break;

            //        case 2:
            //            if (stack.Count > 0)
            //                Console.WriteLine("Top: " + stack.Peek());
            //            else
            //                Console.WriteLine("Stack is empty");
            //            break;

            //        case 3:
            //            if (stack.Count > 0)
            //                Console.WriteLine("Removed: " + stack.Pop());
            //            else
            //                Console.WriteLine("Stack is empty");
            //            break;

            //        case 4:
            //            if (stack.Count > 0)
            //            {
            //                Console.WriteLine("All elements:");
            //                foreach (var item in stack)
            //                {
            //                    Console.WriteLine(item);
            //                }
            //            }
            //            else
            //                Console.WriteLine("Stack is empty");
            //            break;

            //        case 5:
            //            Console.WriteLine("Exiting...");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }

            //} while (choice != 5);

            #endregion

            //---------------------------------------------------------------
            //Dictionary

            #region Dictionary

            //Dictionary<string,int> studentData = new Dictionary<string,int>();

            ////Add element
            //studentData.Add("Shahad", 26);
            //studentData.Add("Tasnim", 24);

            ////print age
            //try
            //{
            //    Console.WriteLine($"Shahad is " + studentData["Shahad"] + "years old.");
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////Update the age
            //try
            //{
            //    studentData["Shahad"] = 22;
            //    Console.WriteLine("Shahad's age has been update");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////Remove 
            //try
            //{
            //    studentData.Remove("Shahad");
            //    Console.WriteLine(studentData.ContainsValue(22);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

           




        }
    }
}
