using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YeahModels.Models;

namespace YeahModels.Data
{
    public class ApplicationDbContext : DbContext
    {
		public DbSet<Person> People { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
		{

		}

		public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			foreach (var entity in this.ChangeTracker.Entries().Where(x => x.Entity is IBaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified)).Select(x => x.Entity as IBaseEntity))
			{
				// TODO set created and modified dates
			}

			return await base.SaveChangesAsync(cancellationToken);
		}
    }
}
