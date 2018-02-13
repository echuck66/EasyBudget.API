using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBudget.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBudget.API.Controllers
{
    public class ExpenseItemController : Controller
    {
        [HttpGet]
        [Route("api/BudgetCategory/{categoryId}/ExpenseItems")]
        public IEnumerable<ExpenseItem> GetExpenseItems(int categoryId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/ExpenseItem/{id}")]
        public IncomeItem Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/ExpenseItem")]
        public void Post([FromBody]ExpenseItem item)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/ExpenseItem/{id}")]
        public void Put(int id, [FromBody]ExpenseItem item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/ExpenseItem/{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
