using DotNetReferenceData.repo.Interface;
using DotNetReferenceData.Services;
using DotNetReferenceData.Services.Interface;

namespace DotNetReferenceData;

public class CountryRepository : IRepositoryBase<CountryDataDto>
{
    public Task<IEnumerable<CountryDataDto>> GetAll()
    {
        return Task.FromResult(new List<CountryDataDto>
        {
            new CountryDataDto
            {
                Description = "Australia",
                Code = "AUS",
                Id = 1
            }
        }.AsEnumerable());
    }
}