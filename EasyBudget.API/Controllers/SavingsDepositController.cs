using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyBudget.API.Controllers
{
    [Route("api/[controller]")]
    public class SavingsDepositController : Controller
    {
        [HttpGet]
        [Route("api/SavingsAccount/{accountId}/SavingsDeposits")]
        public IEnumerable<SavingsDeposit> GetDeposits(int accountId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/SavingsDeposit/{id}")]
        public SavingsDeposit Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/SavingsDeposit")]
        public void Post([FromBody]SavingsDeposit item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/SavingsDeposit/{id}")]
        public void Put(int id, [FromBody]SavingsDeposit item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/SavingsDeposit/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
