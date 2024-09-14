using DotNetReferenceData.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetReferenceData.Controllers;

[ApiController]
[Route("[controller]")]
public class RefDataController : ControllerBase
{
    private readonly IReferenceDataService refDataService;

    public RefDataController(IReferenceDataService refDataService)
    {
        this.refDataService = refDataService;
    }

    [HttpGet(Name = "GetRefData")]
    public async Task<IEnumerable<RefData>> GetRefData(string refDataType)
    {
        return await this.refDataService.GetRefDataByType(refDataType);
    }
}

