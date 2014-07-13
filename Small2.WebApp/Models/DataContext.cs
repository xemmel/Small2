using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Small2.WebApp.Models
{
  public class DataContext : DbContext
  {
    public DbSet<Person> Persons { get; set; }
  }
}