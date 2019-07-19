namespace BCTwo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRent : DbContext
    {
        public CRent()
            : base("name=CRentt")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Member> Member { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
