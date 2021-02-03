using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerManager
    {
        IMemoryCustomer _imemoryCustomer;

        public CustomerManager(IMemoryCustomer memoryCustomer)
        {
               _imemoryCustomer = memoryCustomer;
        }

        public List<Customer> GetAll()
        {
            return _imemoryCustomer.GetAll();
        }
    }
}
