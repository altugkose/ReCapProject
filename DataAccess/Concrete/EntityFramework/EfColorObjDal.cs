using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorObjDal : IColorDal
    {
        public void Add(ColorObj entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ColorObj entity)
        {
            throw new NotImplementedException();
        }

        public ColorObj Get(Expression<Func<ColorObj, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ColorObj> GetAll(Expression<Func<ColorObj, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(ColorObj entity)
        {
            throw new NotImplementedException();
        }
    }
}
