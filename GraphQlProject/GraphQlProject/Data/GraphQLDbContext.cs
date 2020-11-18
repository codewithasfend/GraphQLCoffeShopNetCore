using GraphQlProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Data
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options)
        {

        }


        public DbSet<Menu> Menus { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
