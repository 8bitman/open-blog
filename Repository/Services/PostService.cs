using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using X.PagedList;

namespace Repository.Services
{
    public class PostService : BaseService<Post>, IPostService
    {
        public PostService(OpenBlogContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Task<IPagedList<Post>> GetFeed(int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<TR>> GetFeedAs<TR>(int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<Post>> FindByCategory(long category, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<TR>> FindByCategoryAs<TR>(long category, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<Post>> FindByCategory(Category category, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<TR>> FindByCategoryAs<TR>(Category category, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<Post>> FindByAuthor(long author, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<TR>> FindByAuthorAs<TR>(long author, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<Post>> FindByAuthor(User author, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPagedList<TR>> FindByAuthorAs<TR>(User author, int pageIndex = 1, int pageLimit = 10)
        {
            throw new System.NotImplementedException();
        }
    }
}