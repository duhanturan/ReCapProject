﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.UserId equals c.CustomerId
                             select new CustomerDetailDto { CustomerId = c.CustomerId, CustomerName = c.CustomerName };
                return result.ToList();
            }

        }
    }
}
