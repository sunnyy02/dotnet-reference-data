using System;
using DotNetReferenceData.repo.Interface;
using DotNetReferenceData.Services.Interface;

namespace DotNetReferenceData.Services;

public class CountryTypeStrategy : IRefdataStrategy
{
    private readonly IRepositoryBase<CountryDataDto> repo;
	public CountryTypeStrategy(IRepositoryBase<CountryDataDto> repo)
	{
        this.repo = repo;
	}

    public async Task<IEnumerable<RefData>> GetRefData()
    {
        return await this.repo.GetAll();
    }
}

