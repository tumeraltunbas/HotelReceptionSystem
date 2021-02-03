using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class DomesticCustomer:Customer,IEntity
    {
        public string IdSerialNo { get; set; }
    }
}
