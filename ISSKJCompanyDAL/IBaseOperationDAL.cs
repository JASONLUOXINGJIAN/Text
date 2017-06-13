using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISSKJCompanyDAL
{
    public interface IBaseOperationDAL<T> : IQuery<T>, IAdd<T>, IRemove<T>, IModified<T> where T : class
    {
        int SavaChange();
    }
    public interface IQuery<T> where T : class
    {
        IEnumerable<T> Find(Expression<Func<T, bool>> whereLambda);
        IEnumerable<T> FindPageing<S>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderbyLambda, out int tatal);
    }
    public interface IAdd<T> where T : class
    {
        T Add(T entity);
    }
    public interface IRemove<T> where T : class
    {
        int Remove(T entity);
    }
    public interface IModified<T> where T : class
    {
        int Modified(T entity);
    }
    public interface ISavaList<T> where T : class
    {
        T SavaList(List<T> list,T model);
    }
}