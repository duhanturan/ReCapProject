using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorsDal : EfEntityRepositoryBase<Color, CarContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Colors
                             on c.CarId equals b.ColorId
                             select new ColorDetailDto { ColorId=b.ColorId,ColorName=b.ColorName};
                return result.ToList();
            }
        }
    }
}
