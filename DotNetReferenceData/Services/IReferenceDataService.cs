namespace DotNetReferenceData.Services;

public interface IReferenceDataService
{
    Task<IEnumerable<RefData>> GetRefDataByType(string refDataType);
}