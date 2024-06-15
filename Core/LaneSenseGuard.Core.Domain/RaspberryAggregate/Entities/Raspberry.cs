using BuildingBlock.Core.Domain;

namespace LaneSenseGuard.Core.Domain.RaspberryAggregate.Entities;

public class Raspberry : AggregateRoot
{
    public List<Connection> Connections { get; set; } = [];
}