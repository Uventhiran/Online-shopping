namespace OnlineShopping.Business
{
    using OnlineShopping.Common.Interfaces;
    using OnlineShopping.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class LoginBusiness : ILoginBusiness
    {      
        public LoginBusiness()
        {           
        }

        public Task<string> LoginUser(UserModel userModel)
        {
           var Result = "success";
           return Task.FromResult(Result);
        }
    }
}
