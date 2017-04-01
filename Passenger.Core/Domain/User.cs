using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class User
    {
        public Guid Id { get; protected set; }

        public string Email { get; protected set; }

        public string Password { get; protected set; }

        public string Salt { get; protected set; }

        public string Username { get; protected set; }

        public string FullName { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        protected User()
        {

        }

        public User( string Email, string Password, string Salt, string Username )
        {
            Id = Guid.NewGuid();
            this.Email = Email;
            this.Password = Password;
            this.Salt = Salt;
            this.Username = Username;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
