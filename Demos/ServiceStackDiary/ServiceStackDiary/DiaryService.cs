using Diary.DataAccess.Entity;
using ServiceStack;
using ServiceStackDiary.BusinessLogic;
using ServiceStackDiary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceStackDiary
{
    public class DiaryService : IService
    {
        DiaryLogic _business;

        public DiaryService()
        {
            _business = new DiaryLogic();
        }

        public object Post(RegisterUser request)
        {
            try
            {
                _business.RegisterUser(new User
                {
                    Code = request.Name.Substring(0, 3),
                    Name = request.Name,
                    Alias = request.Alias
                });                
            }
            catch (Exception ex)
            {
                return new RegisterUserResponse { Status = false, Message = ex.Message };
            }
            return new RegisterUserResponse { Status = true };
        }

        //public object Get(RegisterUser request)
        //{
        //    try
        //    {
        //        _business.RegisterUser(new User
        //        {
        //            Code = request.Name.Substring(0, 3),
        //            Name = request.Name,
        //            Alias = request.Alias
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return new RegisterUserResponse { Status = false, Message = ex.Message };
        //    }
        //    return new RegisterUserResponse { Status = true };
        //}
    }
}