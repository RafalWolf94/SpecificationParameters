using System;
using System.Data.Entity;
using System.Linq;
using SpecificationParameters.Interface;

namespace SpecificationParameters.Service
{
    public static class SpecificationApply<TContext,TEntity> where TEntity : class where TContext : DbContext
    {
        public static IQueryable<TEntity> ApplySpecification(TContext context, ISpecification<TEntity> spec)
            => SpecificationEvaluator<TEntity>.GetQuery(context.Set<TEntity>().AsQueryable(), spec);
    }
}