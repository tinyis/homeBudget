//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeBudget
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BudgetEntities : DbContext
    {
        public BudgetEntities()
            : base("name=BudgetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoriesExpense> CategoriesExpense { get; set; }
        public virtual DbSet<CategoriesIncome> CategoriesIncome { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<Incomes> Incomes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
