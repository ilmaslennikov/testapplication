using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DomainModel;

namespace MVCApplicationDAL.Implementation
{
    /// <summary>
    /// Контекст для работы с базой данных
    /// </summary>
    public class MVCApplicationDbContext: DbContext
    {
        public MVCApplicationDbContext()
            : base("MVCApplicationDbContext")
        {
        }

        public IDbSet<MenuItem> MenuItems { get; set; }

        public IDbSet<Beacon> Beacons { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
