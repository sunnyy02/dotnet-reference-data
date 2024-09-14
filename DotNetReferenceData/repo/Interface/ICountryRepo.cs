using System;
namespace DotNetReferenceData.Services.Interface;

public interface ICountryRepo
{
    Task<IEnumerable<CountryDataDto>> GetAll();
}

