using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CustomerHandler
    {
        public static string RegisterCustomer(string name, string email, string gender, string address, string password)
        {
            if (CustomerRepository.GetCustomerByEmail(email) != null)
            {
                return "Email must be unique!";
            }

            return CustomerRepository.AddCustomer(name, email, gender, address, password);
        }

        public static string LoginCustomer(string email, string password)
        {
            if (CustomerRepository.GetCustomerByEmailAndPassword(email, password) == null)
            {
                return "Incorrect password!";
            }
            else
            {
                return "";
            }
        }
    }
}