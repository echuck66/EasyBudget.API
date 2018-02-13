using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBudget.API.Controllers
{
    public class SavingsWithdrawalController : Controller
    {
        [HttpGet]
        [Route("api/SavingsAccount/{accountId}/SavingsWithdrawals")]
        public IEnumerable<SavingsWithdrawal> GetWithdrawals(int accountId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/SavingsWithdrawal/{id}")]
        public SavingsWithdrawal Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/SavingsWithdrawal")]
        public void Post([FromBody]SavingsWithdrawal item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/SavingsWithdrawal/{id}")]
        public void Put(int id, [FromBody]SavingsWithdrawal item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/SavingsWithdrawal/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
