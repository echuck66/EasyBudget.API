using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBudget.API.Controllers
{
    public class CheckingWithdrawalController : Controller
    {
        [HttpGet]
        [Route("api/CheckingAccount/{accountId}/CheckingWithdrawals")]
        public IEnumerable<CheckingWithdrawal> GetWithdrawals(int accountId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/CheckingWithdrawal/{id}")]
        public CheckingWithdrawal Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/CheckingWithdrawal")]
        public void Post([FromBody]CheckingWithdrawal item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/CheckingWithdrawal/{id}")]
        public void Put(int id, [FromBody]CheckingWithdrawal item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/CheckingWithdrawal/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
