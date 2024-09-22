using System;
using DotNetReferenceData.repo.Interface;
using DotNetReferenceData.Services.Interface;

namespace DotNetReferenceData.Services;

public class IndustryTypeStrategy : IRefdataStrategy
{
    private readonly IRepositoryBase<IndustryDataDto> repo;
	public IndustryTypeStrategy(IRepositoryBase<IndustryDataDto> repo)
	{
        this.repo = repo;
	}

    public async Task<IEnumerable<RefData>> GetRefData()
    {
        return await this.repo.GetAll();
    }
}

