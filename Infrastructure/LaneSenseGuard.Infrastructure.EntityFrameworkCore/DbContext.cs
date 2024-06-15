using BuildingBlock.Core.Application;
using BuildingBlock.Infrastructure.EntityFrameworkCore;
using LaneSenseGuard.Core.Domain.RaspberryAggregate.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LaneSenseGuard.Infrastructure.EntityFrameworkCore;

public class DbContext : BaseDbContext
{
    public DbContext(DbContextOptions options, ICurrentUser currentUser, IMediator mediator) : base(options, currentUser, mediator)
    {
    }
    public DbSet<Raspberry> Raspberries { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
    }
}