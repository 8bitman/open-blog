using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using Repository.Interfaces;
using X.PagedList;

namespace Repository.Services
{
    public abstract class BaseService<T> : IBaseService<T>, IDisposable where T : BaseEntity
    {
        protected readonly OpenBlogContext Context;
        protected readonly IMapper Mapper;
        protected readonly DbSet<T> Set;

        protected BaseService(OpenBlogContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
            Set = Context.Set<T>();
        }
        
        public virtual void Dispose()
        {
            Context?.Dispose();
        }

        public virtual Task<T> FindById(long id) => Set.FindAsync(id).AsTask();

        public virtual Task<TR> FindByIdAs<TR>(long id) => throw new NotImplementedException();

        public virtual Task<List<T>> GetAll() => Set.ToListAsync();

        public virtual Task<List<TR>> GetAllAs<TR>() => throw new NotImplementedException();

        public virtual Task<IPagedList<T>> Get(int pageIndex = 1, int pageLimit = 10)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IPagedList<TR>> GetAs<TR>(int pageIndex = 1, int pageLimit = 10)
        {
            throw new NotImplementedException();
        }

        public virtual async Task Save(T entity)
        {
            if (entity.IsNew)
            {
                entity.CreatedDate = DateTime.Now;
                await Set.AddAsync(entity);
            }
            else
            {
                entity.UpdatedDate = DateTime.Now;
                var oldEntity = await Set.FindAsync(entity.Id);

                var properties = oldEntity.GetType().GetProperties().Where(t => t.PropertyType.IsSimpleType() && CanFieldBeEdited(t)).ToList();
                
                foreach (var property in properties)
                {
                    var oldEntityProperty = property;
                    var oldValue = oldEntityProperty.GetValue(oldEntity);

                    var newEntityProperty = entity.GetType().GetProperty(property.Name);
                    var newValue = newEntityProperty?.GetValue(entity);
                    
                    if (oldValue?.GetHashCode() != newValue?.GetHashCode())
                    {
                        oldEntityProperty.SetValue(oldEntity, newValue);
                    }
                }
            }

            await Context.SaveChangesAsync();
        }
        private static bool CanFieldBeEdited(MemberInfo propertyInfo)
        {
            var fieldsThatCantBeEdited = new[]
            {
                nameof(BaseEntity.CreatedDate)
            };

            return !fieldsThatCantBeEdited.Contains(propertyInfo.Name);
        }
    }
}