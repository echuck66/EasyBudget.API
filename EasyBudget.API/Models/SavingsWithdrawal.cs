using System;
using System.Collections.Generic;
using EasyBudget.Models.DataModels;

namespace EasyBudget.API.Models
{
    /// <summary>
    /// Savings withdrawal model to return to REST clients
    /// Object contains a collection of links to related objects and actions
    /// </summary>
    public class SavingsWithdrawal
    {
        public int id { get; set; }

        public DateTime transactionDate { get; set; }

        public decimal transactionAmount { get; set; }

        public string description { get; set; }

        public string notation { get; set; }

        public bool reconciled { get; set; }

        public ICollection<Link> links { get; set; }

        public SavingsWithdrawal()
        {
            this.links = new List<Link>();
        }

        public SavingsWithdrawal(EasyBudget.Models.DataModels.SavingsWithdrawal withdrawal)
        {
            this.links = new List<Link>();
        }
    }
}
