using System;
using DotNetReferenceData.Services.Interface;

namespace DotNetReferenceData.Services;

public class ReferenceDataService : IReferenceDataService
{
    private readonly ICountryRepo countryRepo;
    private readonly IIndustryRepo industryRepo;

    public ReferenceDataService(ICountryRepo countryRepo, IIndustryRepo industryRepo)
    {
        this.countryRepo = countryRepo;
        this.industryRepo = industryRepo;
    }

    public async Task<IEnumerable<RefData>> GetRefDataByType(string refDataType)
    {
        switch (refDataType)
        {
            case "industry":
                return await this.industryRepo.GetAll();
            case "country":
                return await this.countryRepo.GetAll();
            default:
                throw new NotImplementedException();
        }
    }
}
