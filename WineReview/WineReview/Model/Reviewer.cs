using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineReview.Model
{
    internal class Reviewer : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + ", Email: " + Email + ", Password: " + Password + ", FirstName: " + FirstName +
                ", LastName: " + LastName + " ";
        }


    }
}
