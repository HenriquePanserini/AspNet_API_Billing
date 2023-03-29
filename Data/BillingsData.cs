using Microsoft.EntityFrameworkCore;
using AspNet_API_App.Models;

namespace AspNet_API_App.Data;

public class BillingsData : DbContext {
    public BillingsData(DbContextOptions<BillingsData> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Billing> Billings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
    }
}