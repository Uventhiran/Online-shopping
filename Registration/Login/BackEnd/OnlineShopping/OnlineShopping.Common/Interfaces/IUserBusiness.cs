using OnlineShopping.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Common.Interfaces
{
    public interface IUserBusiness
    {
        AuthenticateResponseModel Authenticate(AuthenticateRequestModel model);
    }
}
