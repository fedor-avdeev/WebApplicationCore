using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCore.Models
{
    public class WebApplicationCoreContext : DbContext
    {
        public WebApplicationCoreContext (DbContextOptions<WebApplicationCoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationCore.Models.Movie> Movie { get; set; }
    }
}
