using System.Collections.Generic;
using microservice.Models;

namespace microservice.Repository
{
    public class ContactRepository : IContactRepository
    {
       public static List<Contact> ContactList= new List<Contact>();

            public ContactRepository()
            {
               ContactList.Add(new Contact{
                 Company="Goole",
                 FirstName="GG",
                 LastName="US",
                 Id=1001
             });

            }
        public void Add(Contact item)
        {
             ContactList.Add(new Contact{
                 Company="Goole",
                 FirstName="GG",
                 LastName="US",
                 Id=1001
             });
        }

        public IEnumerable<Contact> GetAll()
        {
            return ContactList;
        }

       
    }
    }
