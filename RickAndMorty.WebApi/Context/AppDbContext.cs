﻿using Microsoft.EntityFrameworkCore;
using RickAndMorty.WebApi.Models;
using System.Reflection;

namespace RickAndMorty.WebApi.Context;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
