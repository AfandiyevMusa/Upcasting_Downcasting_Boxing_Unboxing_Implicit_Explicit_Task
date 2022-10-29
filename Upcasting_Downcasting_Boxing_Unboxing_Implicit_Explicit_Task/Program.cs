using System;
using Services.Service.Inplementations;
using Services.Helpers.Extentions;
using Upcasting_Downcasting_Boxing_Unboxing_Implicit_Explicit_Task.Models;

namespace Upcasting_Downcasting_Boxing_Unboxing_Implicit_Explicit_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HW
            //Task_1
            //AccountController account1 = new AccountController();
            //account1.Login();

            //Task_2
            //int num = 5;
            //Console.WriteLine(num.CalculateFactorial());

            #endregion
            //Task_1

            //Eagle eagle1 = new Eagle();
            //eagle1.Eat();
            //Animal animal1 = eagle1;
            //animal1.Eat();
            //Animal animal2 = new Eagle();
            //animal2.Eat();

            //Task_2

            //int num1 = 5;
            //byte num2 = (byte)num1;
            //Console.WriteLine(num2);

            //Task_3

            //int a = 5;
            //object b = a;
            //int c = (int)b;
            //Console.WriteLine(b);

            //Task_4

            //Eagle eagle3 = new Eagle();
            //Animal eagle4 = new Eagle();
            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();
            //Shark shark3 = (Shark)shark2;

            //Animal[] animals = { eagle3, eagle4, shark1, shark2 };
            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Animal shark1 = new Shark();
            Animal eagle1 = new Eagle();

            object[] objects = { 1, 2, "P414", shark1, eagle1 };

            foreach (var item in objects)
            {
                //if(item is Animal)
                //{
                //    ((Animal)item).Name = "Test";
                //    Console.WriteLine(((Animal)item).Name);
                //}
                //else
                //{
                //    Console.WriteLine("Can't casting");
                //}

                Animal animal = item as Animal;

                //var result = animal == null ? "Can't casting" : "Success casting";
                //Console.WriteLine(result);

                bool isCast = animal == null ? true : false;

                if(!isCast)
                {
                    string result = animal.Name ?? "hello";
                    Console.WriteLine(result);
                }

            }
        }
    }
}

