using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyBudget.API.Controllers
{
    public class BudgetCategoryController : Controller
    {
        [HttpGet]
        [Route("api/BudgetCategory")]
        public IEnumerable<BudgetCategory> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/BudgetCategory/{id}")]
        public BudgetCategory Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/BudgetCategory")]
        public void Post([FromBody]BudgetCategory item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/BudgetCategory/{id}")]
        public void Put(int id, [FromBody]BudgetCategory item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/BudgetCategory/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
