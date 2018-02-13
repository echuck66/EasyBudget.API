using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyBudget.API.Controllers
{
    public class SavingsAccountController : Controller
    {
        [HttpGet]
        [Route("api/SavingsAccount/{id}")]
        public SavingsAccount Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/SavingsAccount")]
        public void Post([FromBody]SavingsAccount item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/SavingsAccount/{id}")]
        public void Put(int id, [FromBody]SavingsAccount item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/SavingsAccount/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
