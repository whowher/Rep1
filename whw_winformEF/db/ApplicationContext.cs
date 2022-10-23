using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Configuration;
using whw_WPF_EF_.db;

public class ApplicationContext : DbContext
{ 

    public DbSet<User> Users => Set<User>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["ConnectionSQLite"].ToString());
    }
}
