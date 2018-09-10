using Phamarcy.Domain.Entities.Data;
using System.Data.Entity;

namespace Phamarcy.Infrastructure.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            #region Confugura��es
            
            modelBuilder.Entity<Addresses>().ToTable("Addresses");
            modelBuilder.Entity<Customers>().ToTable("Customers");
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<ItemsOrdered>().ToTable("ItemsOrdered");
            modelBuilder.Entity<Medication>().ToTable("Medication");
            modelBuilder.Entity<PaymentMethods>().ToTable("PaymentMethods");
            modelBuilder.Entity<PharmaceuticalCompanies>().ToTable("PharmaceuticalCompanies");
            modelBuilder.Entity<PrescriptionItems>().ToTable("PrescriptionItems");
            modelBuilder.Entity<Prescriptions>().ToTable("Prescriptions");
            modelBuilder.Entity<PrescriptionStatus>().ToTable("PrescriptionStatus");
            #endregion
            
            base.OnModelCreating(modelBuilder);
        }

        #region BdSet
        public DbSet<Addresses> Addresses { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<ItemsOrdered> ItemsOrdered { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<PaymentMethods> PaymentMethods { get; set; }
        public DbSet<PharmaceuticalCompanies> PharmaceuticalCompanies { get; set; }
        public DbSet<PrescriptionItems> PrescriptionItems { get; set; }
        public DbSet<Prescriptions> Prescriptions { get; set; }
        public DbSet<PrescriptionStatus> PrescriptionStatus { get; set; }
        #endregion
    }
}
