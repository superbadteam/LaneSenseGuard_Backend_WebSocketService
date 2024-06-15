using BuildingBlock.Core.Application.CQRS;
using LaneSenseGuard.Core.Application.Raspberries.DTOs;

namespace LaneSenseGuard.Core.Application.Raspberries.CQRS.Queries.GetRaspberry;

public record GetRaspberryQuery : IQuery<RaspberryDto>;