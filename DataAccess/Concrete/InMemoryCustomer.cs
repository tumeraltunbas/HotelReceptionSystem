using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCustomer : IMemoryCustomer
    {
        List<Customer> _customers;            
        public InMemoryCustomer()
        {
            _customers = new List<Customer> {

            new DomesticCustomer { IdNo = "15489632159", IdSerialNo="1D84F9" ,FirstName = "Joe", LastName = "Goldberg", Gender = "Male", YearOfBirth = "1993", City = "New York" },
            new DomesticCustomer { IdNo = "22569853674",IdSerialNo="1D9B3V" ,FirstName = "Will", LastName = "Bettelheim", Gender = "Male", YearOfBirth = "1995", City = "Los Angeles" },
            new DomesticCustomer { IdNo = "32048309872", IdSerialNo="G15B68",FirstName = "Love", LastName = "Quinn", Gender = "Female", YearOfBirth = "1994", City = "San Fransisco" },
            new TouristCustomer { IdNo = "28021394209",PassportNumber = "2874569", FirstName = "Forty", LastName = "Quinn", Gender = "Male", YearOfBirth = "1999", City = "London"},
            new TouristCustomer {IdNo = "18610846108", PassportNumber = "5985345", FirstName = "Tumer", LastName = "Altunbas", Gender = "Male", YearOfBirth = "2002", City = "İstanbul" },
            
            };
        }


        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void LogOut(Customer customer)
        {
           Customer customerToDelete = _customers.SingleOrDefault(c => c.IdNo == customer.IdNo);
            _customers.Remove(customerToDelete);
        }

        public void Register(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Reservation(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " is booked for the person");
        }

        public void Update(Customer customer)
        {
            Customer customerToUpdate = _customers.SingleOrDefault(c => c.IdNo == customer.IdNo);
            customer.FirstName = customerToUpdate.FirstName;
            customer.LastName = customerToUpdate.LastName;
            customer.City = customerToUpdate.City;
            customer.Gender = customerToUpdate.Gender;
            customer.YearOfBirth = customerToUpdate.YearOfBirth;

        }
    }
}
