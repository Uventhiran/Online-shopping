using OnlineShopping.Common.Entities;
using OnlineShopping.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business
{
    public class RegistrationBusiness
    {
        private readonly IAsyncRepository<User> _registrationRepository;
        public RegistrationBusiness(IAsyncRepository<User> registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public async Task<User> AddRegistrationAsync(User user)
        {
            return await _registrationRepository.AddAsync(user);
        }
    }
}
