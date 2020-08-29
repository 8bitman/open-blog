using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using X.PagedList;

namespace Repository.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<T> FindById(long id);
        Task<TR> FindByIdAs<TR>(long id);
        
        Task<List<T>> GetAll();
        Task<List<TR>> GetAllAs<TR>();
        
        Task<IPagedList<T>> Get(int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<TR>> GetAs<TR>(int pageIndex = 1, int pageLimit = 10);
        
        Task Save(T entity);
    }
}