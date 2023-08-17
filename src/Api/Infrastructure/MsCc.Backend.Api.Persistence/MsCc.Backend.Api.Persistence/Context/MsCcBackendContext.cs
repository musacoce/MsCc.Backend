
using Microsoft.EntityFrameworkCore;
using MsCc.Backend.Api.Domain.Models;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace MsCc.Backend.Api.Persistence.Context;
public class MsCcBackendContext : DbContext
{
    public const string DEFAULT_SCHEMA = "dbo";

    public MsCcBackendContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<EmailConfirmation> EmailConfirmations { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
