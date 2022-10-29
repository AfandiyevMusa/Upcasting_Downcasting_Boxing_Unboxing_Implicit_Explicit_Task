
using System;
namespace Upcasting_Downcasting_Boxing_Unboxing_Implicit_Explicit_Task.Models
{
    public class Eagle : Bird
    {
        public string Color { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eagle eating!");
        }
    }
}

