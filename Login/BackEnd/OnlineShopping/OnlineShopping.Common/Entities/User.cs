using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OnlineShopping.Common.Entities
{
    public class User : BaseEntity
    {
      

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
