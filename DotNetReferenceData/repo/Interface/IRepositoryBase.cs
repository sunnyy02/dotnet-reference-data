using System;
namespace DotNetReferenceData.repo.Interface;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAll();
}

