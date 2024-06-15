using AutoMapper;
using LaneSenseGuard.Core.Application.Raspberries.DTOs;
using LaneSenseGuard.Core.Domain.RaspberryAggregate.Entities;

namespace LaneSenseGuard.Infrastructure.EntityFrameworkCore.Mappers;

public class RaspberryMapper : Profile
{
    public RaspberryMapper()
    {
        CreateMap<Raspberry, RaspberryDto>();
    }
}