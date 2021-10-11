using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpecificationParameters.Interface
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; set; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; set; }
        Expression<Func<T, object>> OrderByDescending { get; set; }
        int Take { get; set; }
    }
}