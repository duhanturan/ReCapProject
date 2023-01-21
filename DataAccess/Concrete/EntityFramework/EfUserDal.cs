using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.UserId equals c.CustomerId
                             select new UserDetailDto { UserId=c.CustomerId,UserName=c.CustomerName};
                return result.ToList();
            }

        }
    }
}
