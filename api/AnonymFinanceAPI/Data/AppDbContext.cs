using System;
using AnonymFinance.Models;
using Microsoft.EntityFrameworkCore;

namespace AnonymFinanceAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<ExpenseCategory> ExpenseCategories => Set<ExpenseCategory>();
    public DbSet<Expense> Expenses => Set<Expense>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ExpenseCategory>()
        .HasIndex(ec => ec.UserHash);

        modelBuilder.Entity<ExpenseCategory>()
        .HasIndex(ec => new {ec.Name, ec.UserHash})
        .IsUnique();

        modelBuilder.Entity<Expense>()
        .HasIndex(e => e.UserHash);
    }
}
