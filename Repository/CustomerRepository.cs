using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepository
    {
        private static KpopZtationDBEntities db = DatabaseSingleton.GetInstance();

        public static string AddCustomer(string name, string email, string gender, string address, string password)
        {
            Customer newCustomer = CustomerFactory.CreateCustomer(name, email, gender, address, password);
            db.Customers.Add(newCustomer);
            db.SaveChanges();

            return "";
        }
        public static Customer GetCustomerByEmail(string email)
        {
            return (from cust in db.Customers where cust.CustomerEmail.Equals(email) select cust).FirstOrDefault();
        }

        public static Customer GetCustomerByEmailAndPassword(string email, string password)
        {
            return (from cust in db.Customers where cust.CustomerEmail.Equals(email) && cust.CustomerPassword.Equals(password) select cust).FirstOrDefault();
        }
    }
}