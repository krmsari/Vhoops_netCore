﻿using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract.Firebase
{

    public interface IFirebaseUserDal : IEntityRepository<User>
    {
        
        Task<IResult> CreateUser(User entity);

        Task<IResult> UploadProfileImage(string profileImage);

        Task<IResult> UpdateProfileImage(Object profileImage);

        Task<IDataResult<String>> GetProfileImage();

        Task<IDataResult<User>> GetByUserName(string userName);

        Task<IDataResult<User>> GetByEmail(string email);
       

    }
}
