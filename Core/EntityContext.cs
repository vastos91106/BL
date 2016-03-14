using System.Data.Entity;
using Core.Entities;

namespace Core
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("BLConnection")
        {
        }


        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<ByPassList> ByPassLists { get; set; }

        public virtual DbSet<ByPassState> ByPassStates { get; set; }

        public virtual DbSet<ByPassStateStep> ByPassStateSteps { get; set; }
    }
}
