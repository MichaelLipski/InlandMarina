using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarina.Data
{
    public static class AuthenticationManager
    {
        public static CustomerDTO Authenticate (string username, string password)
        {
            CustomerDTO dto = null;
            MarinaEntities db = new MarinaEntities();
            Authentication auth = db.Authentications.
                SingleOrDefault(a => a.Username == username && a.Password == password);
            if (auth != null) // authentication passed
            {
                dto = new CustomerDTO
                {
                    ID = auth.Customer.ID,
                    FullName = auth.Customer.FirstName + " " + auth.Customer.LastName
                };
            }

            return dto;
        }
        /// <summary>
        /// finds authentication record for customer with given ID
        /// </summary>
        /// <param name="customerId">customer ID to find</param>
        /// <returns>authentication record or null if not found</returns>
        public static Authentication Find(int customerId)
        {
            MarinaEntities db = new MarinaEntities(); // context object
            Authentication auth = db.Authentications.
                SingleOrDefault(a => a.CustomerId == customerId);
            return auth;
        }

        /// <summary>
        /// add authentication record to the table
        /// </summary>
        /// <param name="auth">record to add</param>
        public static void Add(Authentication auth)
        {
            MarinaEntities db = new MarinaEntities();
            db.Authentications.Add(auth); // then add record to Authentication
            db.SaveChanges();
        }

        /// <summary>
        /// update authentication record
        /// </summary>
        /// <param name="auth">new data for update</param>
        public static void Update(Authentication auth)
        {
            MarinaEntities db = new MarinaEntities();
            // find the existing record in the context based on ID
            Authentication authFromContext = db.Authentications.
                SingleOrDefault(a => a.Id == auth.Id);
            // replace old values with new values
            authFromContext.Username = auth.Username;
            authFromContext.Password = auth.Password;
            authFromContext.Customer.FirstName = auth.Customer.FirstName;
            authFromContext.Customer.LastName = auth.Customer.LastName;
            authFromContext.Customer.Phone = auth.Customer.Phone;
            authFromContext.Customer.City = auth.Customer.City;
            db.SaveChanges();
        }
    }
}
