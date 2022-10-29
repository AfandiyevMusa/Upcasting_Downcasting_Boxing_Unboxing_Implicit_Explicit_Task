using System;
using Services.Enums;
using Services.Helpers.Constants;
using Services.Service.Interfaces;

namespace Services.Service.Inplementations
{
    public class AccountService : IAccountService
    {
        public string Login(string email, string password, int role)
        {
            if (email == AccountConstants.Email && password == AccountConstants.Password)
            {
                if (CheckRoles(role))
                {
                    return AccountConstants.Logged;
                }
                else
                {
                    return AccountConstants.NoAuthorize;
                }
            }
            return AccountConstants.Failed;
        }

        private bool CheckRoles(int role)
        {
            //First Way

            //switch (role)
            //{
            //    case (int)Roles.SuperAdmin:
            //        return true;
            //    default:
            //        return false;
            //}

            //Second Way

            if (role == (int)Roles.SuperAdmin)
                return true;
            return false;

        }
    }
}

