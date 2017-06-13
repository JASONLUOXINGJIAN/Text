using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISSKJCompanyBLL
{
    public interface IBaseBLL<T> where T :class
    {
        IEnumerable<T> GetList(Expression<Func<T, bool>> whereLambda);
        IEnumerable<T> GetList_page<S>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderbyLambda, out int total);

        T AddInfo(T model);
        int UpdateInfo(T model);
        int DeleteInfo(int[] delbyid);
        List<T> SavaList(Stream file, T model);
    }
}
