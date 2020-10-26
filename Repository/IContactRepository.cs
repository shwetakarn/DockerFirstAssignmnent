using System.Collections.Generic;
using microservice.Models;

namespace microservice.Repository
{
    public interface IContactRepository
    {
          IEnumerable<Contact> GetAll();
         void Add(Contact item);
    }
}