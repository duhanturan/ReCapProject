using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
       
        List<CustomerDetailDto> GetCustomerDetails();
    }
}
