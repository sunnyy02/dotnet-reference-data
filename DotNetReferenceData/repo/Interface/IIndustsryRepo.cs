using System;
namespace DotNetReferenceData.Services.Interface;

public interface IIndustryRepo
{
    Task<IEnumerable<IndustryDataDto>> GetAll();
}
