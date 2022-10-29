using System;
namespace Services.Service.Interfaces
{
    public interface IAccountService
    {
        public string Login(string email, string password, int role);
    }
}

