using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Interface;

public interface IRepository<T>
{
    List<T> GetAll();
    T? Get(Expression<Func<T, bool>> predicate);
    T Create(T entity);
    T Update(T entity);
    T Delete(T entity);
}