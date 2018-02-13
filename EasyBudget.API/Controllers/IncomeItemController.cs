using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBudget.API.Controllers
{
    public class IncomeItemController : Controller
    {
        [HttpGet]
        [Route("api/BudgetCategory/{categoryId}/IncomeItems")]
        public IEnumerable<IncomeItem> GetIncomeItems(int categoryId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/IncomeItem/{id}")]
        public IncomeItem Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/IncomeItem")]
        public void Post([FromBody]IncomeItem item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/IncomeItem/{id}")]
        public void Put(int id, [FromBody]IncomeItem item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/IncomeItem/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
