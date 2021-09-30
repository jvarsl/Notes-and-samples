using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Test1.Models;

namespace MVC_Test1.Data
{
    public class JokeContext : DbContext
    {
        public JokeContext(DbContextOptions<JokeContext> options) 
            : base(options)
        {

        }
        public DbSet<MVC_Test1.Models.Joke> Joke { get; set; }
    }
}
