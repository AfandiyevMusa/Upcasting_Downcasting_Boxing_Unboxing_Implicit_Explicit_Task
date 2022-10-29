using System;
namespace Upcasting_Downcasting_Boxing_Unboxing_Implicit_Explicit_Task.Models
{
    public class Shark : Fish
    {
        public object TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating!");
        }
    }
}

