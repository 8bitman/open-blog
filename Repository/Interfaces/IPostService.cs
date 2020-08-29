using System.Threading.Tasks;
using Domain.Entities;
using X.PagedList;

namespace Repository.Interfaces
{
    public interface IPostService : IBaseService<Post>
    {
        Task<IPagedList<Post>> GetFeed(int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<TR>> GetFeedAs<TR>(int pageIndex = 1, int pageLimit = 10);
        
        Task<IPagedList<Post>> FindByCategory(long category, int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<TR>> FindByCategoryAs<TR>(long category, int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<Post>> FindByCategory(Category category, int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<TR>> FindByCategoryAs<TR>(Category category, int pageIndex = 1, int pageLimit = 10);
        
        Task<IPagedList<Post>> FindByAuthor(long author, int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<TR>> FindByAuthorAs<TR>(long author, int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<Post>> FindByAuthor(User author, int pageIndex = 1, int pageLimit = 10);
        Task<IPagedList<TR>> FindByAuthorAs<TR>(User author, int pageIndex = 1, int pageLimit = 10);
    }
}