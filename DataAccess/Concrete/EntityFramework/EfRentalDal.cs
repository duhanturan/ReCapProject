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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            
                using (CarContext context = new CarContext())
                {
                    var result = from c in context.Cars
                                 join r in context.Rentals
                                 on c.CarId equals r.Id
                                 select new RentalDetailDto { CarId=r.CarId };
                    return result.ToList();
                }
            
        }
    }
}
