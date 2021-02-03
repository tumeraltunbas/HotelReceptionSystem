using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string YearOfBirth { get; set; }
        public string Gender { get; set; }
        public string IdNo{get; set;}
    }
}
