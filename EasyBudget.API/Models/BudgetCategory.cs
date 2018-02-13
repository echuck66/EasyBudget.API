using System;
using System.Collections.Generic;
using EasyBudget.Models;

namespace EasyBudget.API.Models
{
    /// <summary>
    /// Budget category model to return to REST clients
    /// Object contains a collection of links to related objects and actions
    /// </summary>
    public class BudgetCategory
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string description { get; set; }

        public decimal budgetAmount { get; set; }

        public bool systemCategory { get; set; }

        public bool userSelected { get; set; }

        public AppIcon categoryIcon { get; set; }

        public BudgetCategoryType categoryType { get; set; }

        public ICollection<Link> links { get; set; }

        public BudgetCategory()
        {
            links = new List<Link>();
        }

        public BudgetCategory(EasyBudget.Models.DataModels.BudgetCategory category)
        {
            links = new List<Link>();

        }


    }
}
