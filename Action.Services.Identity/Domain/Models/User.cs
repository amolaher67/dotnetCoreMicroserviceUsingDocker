using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Action.Common.Exceptions;
using Action.Services.Identity.Domain.Services;

namespace Action.Services.Identity.Domain.Models
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Name { get; protected set; }
        public string Salt { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected User()
        {

        }

        public User(string email, string password, string name)
        {
            //validate Input
            if (string.IsNullOrEmpty(email))
            {
                throw new ActionException("Empty_User_Email", "User Email can not be empty");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ActionException("Empty_User_name", "User name can not be empty");
            }

            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Name = name;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password, IEncrypter encrypter)
        {
            //validate Input
            if (string.IsNullOrEmpty(password))
            {
                throw new ActionException("Empty_User_password", "User password can not be empty");
            }

            Salt = encrypter.GetSalt(password);
            password = encrypter.GetHash(password, salt: Salt);
        }

        public bool ValidatePassword(string password, IEncrypter encrypter)
            => password.Equals(encrypter.GetHash(password, salt: Salt));

    }
}
