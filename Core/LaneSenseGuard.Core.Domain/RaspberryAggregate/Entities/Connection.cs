using BuildingBlock.Core.Domain;

namespace LaneSenseGuard.Core.Domain.RaspberryAggregate.Entities;

public class Connection : Entity
{
    public Raspberry Raspberry { get; set; } = null!;
}