using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;

namespace Repository.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(OpenBlogContext context, IMapper mapper) : base(context, mapper) { }

        public override Task Save(Category entity)
        {
            if(string.IsNullOrEmpty(entity.Uri))
                entity.Uri = entity.Name;
            
            return base.Save(entity);
        }
    }
}