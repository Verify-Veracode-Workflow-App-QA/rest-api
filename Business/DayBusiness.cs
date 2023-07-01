﻿using Entities.DTO.Request.Day;
using Microsoft.Extensions.Logging;
using Persistence.Interfaces;

namespace Business;
public class DayBusiness : IBusiness<DayDTO, DayEntity>
{
    private readonly IMapper _mapper;
    private readonly ILogger<DayBusiness> _logger;
    private readonly IGenericRepository<DayEntity> _repository;
    public DayBusiness(IMapper mapper,
        ILogger<DayBusiness> logger,
        IGenericRepository<DayEntity> repository)
    {
        _mapper = mapper;
        _logger = logger;
        _repository = repository;
    }

    public Task<DayEntity> Add(DayDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task<DayEntity> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DayEntity> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DayEntity> Update(int id, DayDTO entity)
    {
        throw new NotImplementedException();
    }
}
