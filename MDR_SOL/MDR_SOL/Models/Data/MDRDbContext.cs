using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDR_SOL.Models.Data
{
  public class MDRDbContext:DbContext
  {
    public MDRDbContext(DbContextOptions<MDRDbContext>options):base(options)
    {

    }

    public DbSet<Owner> Owner { get; set; }
    public DbSet<Building> Building { get; set; }

  }
}
