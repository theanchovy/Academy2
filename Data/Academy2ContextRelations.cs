using Microsoft.EntityFrameworkCore;
using Academy2.Models;

namespace Academy2.Data
{
    public partial class Academy2Context
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DependentDiscipline>(e =>
            {
                e.HasKey(x => new { x.discipline, x.dependent_discipline });
                e.HasOne(x => x.Discipline).WithMany().HasForeignKey(x => x.discipline);
                e.HasOne(x => x.DependentDisciplineNavigation).WithMany()
                    .HasForeignKey(x => x.dependent_discipline)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<RequiredDiscipline>(e =>
            {
                e.HasKey(x => new { x.discipline, x.required_discipline });
                e.HasOne(x => x.Discipline).WithMany().HasForeignKey(x => x.discipline);
                e.HasOne(x => x.RequiredDisciplineNavigation).WithMany()
                    .HasForeignKey(x => x.required_discipline)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
