using Entity = Diary.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.DataAccess.DataContext
{
    public class DiaryContext : DbContext
    {
        public DiaryContext()
            : base("name=Diary")
        { }
        public DbSet<Entity.User> Users { get; set; }
        public DbSet<Entity.Entry> Entries { get; set; }
        public DbSet<Entity.Diary> Diaries { get; set; }
    }
}
