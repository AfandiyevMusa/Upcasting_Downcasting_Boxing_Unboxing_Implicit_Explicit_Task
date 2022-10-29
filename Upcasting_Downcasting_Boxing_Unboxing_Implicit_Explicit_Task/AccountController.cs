using System;
using Services.Service.Inplementations;

namespace Upcasting_Downcasting_Boxing_Unboxing_Implicit_Explicit_Task
{
    public class AccountController
    {
        public void Login()
        {
            Console.WriteLine("Add email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Add password: ");
            string password = Console.ReadLine();

            int role = 1;

            AccountService account1 = new AccountService();
            Console.WriteLine(account1.Login(email, password, role));
        }
    }
}

