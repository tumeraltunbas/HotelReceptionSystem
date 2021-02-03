using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Collections.Generic;
using System;

namespace ConsoleSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerManager customerManager = new CustomerManager(new InMemoryCustomer());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.FirstName+ " "+ customer.LastName + " " + customer.City + " "+ customer.Gender);
            }
            Customer customer1 = new TouristCustomer { IdNo = "46094050268", PassportNumber = "9620486", FirstName = "Emma", LastName = "Rodriguez", Gender = "Female", YearOfBirth = "1985", City = "Roma"};
            IMemoryCustomer memoryCustomer = new InMemoryCustomer();
            memoryCustomer.Reservation(customer1);



        }
    }
}
