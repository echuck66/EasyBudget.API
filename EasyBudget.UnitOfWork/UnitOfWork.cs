using System;
using EasyBudget.Repository;

namespace EasyBudget.UnitOfWork
{
    public class UnitOfWork 
    {
        IEasyBudgetRepository repository;

        public UnitOfWork()
        {
            repository = new EasyBudgetRepository();
        }

        public UnitOfWork(IEasyBudgetRepository repository)
        {
            this.repository = repository;
        }
    }
}
