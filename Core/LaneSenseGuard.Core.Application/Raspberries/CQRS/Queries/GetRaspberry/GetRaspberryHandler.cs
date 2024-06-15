using AutoMapper;
using BuildingBlock.Core.Application.CQRS;
using BuildingBlock.Core.Domain.Repositories;
using LaneSenseGuard.Core.Application.Raspberries.DTOs;
using LaneSenseGuard.Core.Domain.RaspberryAggregate.Entities;

namespace LaneSenseGuard.Core.Application.Raspberries.CQRS.Queries.GetRaspberry;

public class GetRaspberryHandler : IQueryHandler<GetRaspberryQuery, RaspberryDto>
{
    private readonly IMapper _mapper;
    private readonly IReadOnlyRepository<Raspberry> _readOnlyRepository;

    public GetRaspberryHandler(IReadOnlyRepository<Raspberry> readOnlyRepository, IMapper mapper)
    {
        _readOnlyRepository = readOnlyRepository;
        _mapper = mapper;
    }

    public async Task<RaspberryDto> Handle(GetRaspberryQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<RaspberryDto>(await _readOnlyRepository.GetAnyAsync());
    }
}