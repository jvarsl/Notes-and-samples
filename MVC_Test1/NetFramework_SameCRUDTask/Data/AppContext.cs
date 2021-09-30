using Microsoft.EntityFrameworkCore;
using NetFramework_SameCRUDTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFramework_SameCRUDTask.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public virtual DbSet<Joke> Jokes { get; set; }
    }
}