using Microsoft.EntityFrameworkCore;

namespace PrescriptionApp.Models
{
    public class PrescriptionContext : DbContext
    {
        public PrescriptionContext(DbContextOptions<PrescriptionContext> options)
            : base(options) { }

        public DbSet<PrescriptionModel> Prescriptions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrescriptionApp.Models.PrescriptionModel>().HasData(
                new PrescriptionModel {
                    PrescriptionId = 1,
                    MedicationName = "Atorvastatin",
                    FillStatus = "New",
                    Cost = 19.99,
                    RequestTime = new DateTime(2025, 9, 10, 10, 30, 0)
                },
                new PrescriptionModel {
                    PrescriptionId = 2,
                    MedicationName = "Metformin",
                    FillStatus = "Filled",
                    Cost = 9.49,
                    RequestTime = new DateTime(2025, 9, 11, 14, 15, 0)
                }
            );
        }
    }
}
