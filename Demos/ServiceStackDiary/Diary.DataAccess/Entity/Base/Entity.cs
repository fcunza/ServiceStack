using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.DataAccess.Entity.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public Entity()
        {
            IsDeleted = false;
        }
    }
}