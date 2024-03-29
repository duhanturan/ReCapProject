﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        IDataResult<List<UserDetailDto>> GetUserDetails();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);

    }
}
