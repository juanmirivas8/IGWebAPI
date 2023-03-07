using IGWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IGWebAPI;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base(options) { }
    
    public DbSet<RolEntity> Roles { get; set; }
}