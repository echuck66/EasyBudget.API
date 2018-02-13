using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBudget.API.Controllers
{
    public class CheckingDepositController : Controller
    {
        [HttpGet]
        [Route("api/CheckingAccount/{accountId}/CheckingDeposits")]
        public IEnumerable<CheckingDeposit> GetDeposits(int accountId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/CheckingDeposit/{id}")]
        public CheckingDeposit Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/CheckingDeposit")]
        public void Post([FromBody]CheckingDeposit item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/CheckingDeposit/{id}")]
        public void Put(int id, [FromBody]CheckingDeposit item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/CheckingDeposit/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
