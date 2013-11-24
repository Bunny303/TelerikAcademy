using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Library;

namespace _02.CreateDAO
{
    public static class DAO
    {
        public static string InsertCustomer(string customerID, string companyName)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                Customer customer = new Customer
                {
                    CustomerID = customerID,
                    CompanyName = companyName
                };

                db.Customers.Add(customer);
                if (IsThereSameCustomer(customerID))
                {
                    string result = "The customer is already in the DB";
                    return result;
                }
                else
                {
                    db.SaveChanges();
                    string result = "The customer is inserted";
                    return result;
                }
            }
        }

        public static string ModifyCustomer(string customerID, string companyName, string contactName = null, string contactTitle = null,
                                        string address = null, string city = null, string region = null, string postalCode = null,
                                        string country = null, string phone = null, string fax = null)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                Customer customer = db.Customers.First(x => x.CustomerID == customerID);

                customer.CompanyName = companyName ?? customer.CompanyName;
                customer.ContactName = contactName ?? customer.ContactName;
                customer.ContactTitle = contactTitle ?? customer.ContactTitle;
                customer.Address = address ?? customer.Address;
                customer.City = city ?? customer.City;
                customer.Region = region ?? customer.Region;
                customer.PostalCode = postalCode ?? customer.PostalCode;
                customer.Country = country ?? customer.Country;
                customer.Phone = phone ?? customer.Phone;
                customer.Fax = fax ?? customer.Fax;

                if (IsThereSameCustomer(customerID))
                {
                    db.SaveChanges();
                    string result = "The customer is modified";
                    return result;
                }
                else
                {
                    string result = "There isn't cutomer with this id";
                    return result;
                }
            }
        }

        public static string DeleteCustomer(string customerID)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                Customer customer = db.Customers.First(x => x.CustomerID == customerID);

                db.Customers.Remove(customer);

                if (IsThereSameCustomer(customerID))
                {
                    db.SaveChanges();
                    string result = "The customer is deleted";
                    return result;
                }
                else
                {
                    string result = "There isn't cutomer with this id";
                    return result;
                }
            }
        }

        private static bool IsThereSameCustomer(string id)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                bool result = db.Customers.Any(x => x.CustomerID == id);
                return result;
            }
        }
    }
}
