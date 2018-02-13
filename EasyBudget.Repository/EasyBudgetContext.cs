﻿//
//  Copyright 2018  CrawfordNET Solutions, LLC
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using EasyBudget.Models.DataModels;
using Microsoft.EntityFrameworkCore;


namespace EasyBudget.Repository
{
    public class EasyBudgetContext : DbContext
    {

        public DbSet<BudgetCategory> BudgetCategory { get; set; }

        public DbSet<CheckingAccount> CheckingAccount { get; set; }

        public DbSet<CheckingDeposit> CheckingDeposit { get; set; }

        public DbSet<CheckingWithdrawal> CheckingWithdrawal { get; set; }

        public DbSet<ExpenseItem> ExpenseItem { get; set; }

        public DbSet<IncomeItem> IncomeItem { get; set; }

        public DbSet<SavingsAccount> SavingsAccount { get; set; }

        public DbSet<SavingsDeposit> SavingsDeposit { get; set; }

        public DbSet<SavingsWithdrawal> SavingsWithdrawal { get; set; }

        public DbSet<BankAccountFundsTransfer> BankAccountFundsTransfer { get; set; }

        public EasyBudgetContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
