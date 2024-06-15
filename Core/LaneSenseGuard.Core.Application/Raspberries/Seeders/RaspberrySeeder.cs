using BuildingBlock.Core.Application;
using BuildingBlock.Core.Domain.Repositories;
using BuildingBlock.Core.Domain.Shared.Services;
using LaneSenseGuard.Core.Domain.RaspberryAggregate.Entities;
using Microsoft.Extensions.Logging;

namespace LaneSenseGuard.Core.Application.Raspberries.Seeders;

public class RaspberrySeeder : IDataSeeder
{
    private readonly ILogger<RaspberrySeeder> _logger;
    private readonly IOperationRepository<Raspberry> _raspberryOperationRepository;
    private readonly IReadOnlyRepository<Raspberry> _raspberryReadOnlyRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RaspberrySeeder(IOperationRepository<Raspberry> raspberryOperationRepository, IUnitOfWork unitOfWork,
        ILogger<RaspberrySeeder> logger, IReadOnlyRepository<Raspberry> raspberryReadOnlyRepository)
    {
        _raspberryOperationRepository = raspberryOperationRepository;
        _unitOfWork = unitOfWork;
        _logger = logger;
        _raspberryReadOnlyRepository = raspberryReadOnlyRepository;
    }

    public async Task SeedDataAsync()
    {
        if (await _raspberryReadOnlyRepository.CheckIfExistAsync())
        {
            _logger.LogInformation("Raspberry data already seeded!");
            return;
        }

        _logger.LogInformation("Start seeding raspberry data...");


        var raspberry = new Raspberry();

        await _raspberryOperationRepository.AddAsync(raspberry);

        await _unitOfWork.SaveChangesAsync();
    }

    public int ExecutionOrder => 1;
}