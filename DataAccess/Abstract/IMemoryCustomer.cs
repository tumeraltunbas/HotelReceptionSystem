using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IMemoryCustomer
    {
        void Register(Customer customer);
        void LogOut(Customer customer);
        void Update(Customer customer);
        void Reservation(Customer customer);
        List<Customer> GetAll();


    }
}
