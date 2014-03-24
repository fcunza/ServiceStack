using Diary.DataAccess.DataContext;
using Diary.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceStackDiary.BusinessLogic
{
    public class DiaryLogic
    {
        DiaryContext _context;

        public DiaryLogic()
        {
            _context = new DiaryContext();
        }

        public void RegisterUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}