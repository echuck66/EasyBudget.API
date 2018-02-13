using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBudget.API.Controllers
{
    public class CheckingAccountController : Controller
    {
        [HttpGet]
        [Route("api/CheckingAccount/{id}")]
        public CheckingAccount Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/CheckingAccount")]
        public void Post([FromBody]CheckingAccount item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/CheckingAccount/{id}")]
        public void Put(int id, [FromBody]CheckingAccount item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/CheckingAccount/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
