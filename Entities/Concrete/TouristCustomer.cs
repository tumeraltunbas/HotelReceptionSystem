using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class TouristCustomer:Customer,IEntity
    {
        public string PassportNumber { get; set; }
    }
}
