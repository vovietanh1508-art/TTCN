using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aznews.Models
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {

        }
        public DbSet<tblMenu> Menus { get; set; }
        public DbSet<viewPostMenu> viewPostMenus { get; set; }
    }
}