using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;

namespace Repository.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(OpenBlogContext context, IMapper mapper) : base(context, mapper) { }
    }
}