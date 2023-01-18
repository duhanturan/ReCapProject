using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
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
    public class EfBrandsDal : EfEntityRepositoryBase<Brand, CarContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new BrandDetailDto { BrandId=b.BrandId, BrandName=b.BrandName};
                return result.ToList();
            }
        }
    }
}
