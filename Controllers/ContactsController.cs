using microservice.Models;
using microservice.Repository;
using Microsoft.AspNetCore.Mvc;

namespace microservice.Controllers
{
  
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        IContactRepository _repo;
             public ContactsController(IContactRepository repo)
             {

                    this._repo=repo;
             }

            [HttpPost("Create")]
             public IActionResult CreateContact([FromBody]Contact obj)
             {
            if (obj is null)
            {
                throw new System.ArgumentNullException(nameof(obj));
            }

            this._repo.Add(obj);
                return Ok(obj);
             }


            [HttpGet("Fetch")]
             public IActionResult ContactList()
             {

               return Ok( this._repo.GetAll());

             }
    }
}