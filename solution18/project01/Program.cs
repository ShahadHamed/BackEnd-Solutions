namespace project01
{

    public class student
    {
        public string name { get; set; }
        public int Age { get; set; }
    }


    internal class Program
    {
      
        static void Main(string[] args)
        {
            List<student> stds = new List<student>()
            {
            new student {name= "shahad", Age=24},
            new student {name= "Tasnim", Age=20},
            new student {name= "sharouq", Age=22},
            new student {name= "shima", Age=18},
            new student {name= "Manar", Age=23},
            new student {name= "Fatima", Age=30},
            new student {name= "shatha", Age=32},
            };


            //**********Linq **********

            //Query Syntax---

            //var result0 =
            //    from s in stds
            //    where s.Age > 22
            //    select s;

            //foreach (var item in result0)
            //{
            //    Console.WriteLine(item.name);
            //}

            //Console.WriteLine("-----------------------");

            //-----------------------------------

            //Methods Syntax---
            //**Where**

            //var result01 = stds.Where(x => x.Age > 22);

            //foreach (var item in result01)
            //{
            //    Console.WriteLine(item.name);
            //}

            //Console.WriteLine("-----------------------");

            //-----------------------------------
            //**Select**

            //var result02 = stds.Select(x => x.Age > 22);

            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------------------");

            //-----------------------------------

            var result03 = stds.Where(hamada => hamada.Age > 75);

            var result04 = stds.Any(hamada => hamada.Age > 75);

            var result05 = stds.Select(x => x.name).Count();

            var result06 = stds.Select(hamada => hamada.name);

            var result07 = stds.Where(x => x.Age > 22).Select(y => y.name).OrderBy(h =>h);

            //oredering
            var result08=stds.OrderBy(x => x.Age);
            var result09 = stds.OrderByDescending(x => x.Age);

            Console.WriteLine(result05);

            Console.WriteLine("----------------------------");


            foreach (var item in result07)
            {
                Console.WriteLine(item);
            }


            //-----------------------------------


        }
    }
}
