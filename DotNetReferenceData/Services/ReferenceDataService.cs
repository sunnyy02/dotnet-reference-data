using System;
using DotNetReferenceData.Services.Interface;

namespace DotNetReferenceData.Services;

public class ReferenceDataService : IReferenceDataService
{
    private readonly ICountryRepo countryRepo;
    private readonly IIndustryRepo industryRepo;
    private readonly IServiceProvider _keyedServiceProvider;
    public ReferenceDataService(IServiceProvider keyedServiceProvider)
    {
        this._keyedServiceProvider = keyedServiceProvider;
    }

    public async Task<IEnumerable<RefData>> GetRefDataByType(string refDataType)
    {
        var service = _keyedServiceProvider.GetRequiredKeyedService<IRefdataStrategy>(refDataType);
        return await service.GetRefData();
    }
}
