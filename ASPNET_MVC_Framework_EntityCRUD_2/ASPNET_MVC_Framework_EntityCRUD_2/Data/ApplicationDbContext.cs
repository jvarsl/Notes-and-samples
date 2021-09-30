using System.Data.Entity;
using ASPNET_MVC_Framework_EntityCRUD_2.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASPNET_MVC_Framework_EntityCRUD_2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Joke> Jokes { get; set; }
        public DbSet<ReminderTasks> ReminderTasks { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}