using DotNetReferenceData.repo.Interface;
using DotNetReferenceData.Services;
using DotNetReferenceData.Services.Interface;

namespace DotNetReferenceData;

public class IndustryRepository : IRepositoryBase<IndustryDataDto>
{
    public Task<IEnumerable<IndustryDataDto>> GetAll()
    {
        return Task.FromResult(new List<IndustryDataDto>
        {
            new IndustryDataDto
            {
                Description = "Information Tech",
                Code = "IT",
                Id = 1
            }
        }.AsEnumerable());
    }
}