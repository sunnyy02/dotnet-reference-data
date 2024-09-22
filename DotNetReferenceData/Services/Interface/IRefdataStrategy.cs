using System;
namespace DotNetReferenceData.Services.Interface;

public interface IRefdataStrategy
{
    Task<IEnumerable<RefData>> GetRefData();
}

