using Diary.DataAccess.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.DataAccess.Entity
{
    public class User : LookupEntity
    {
        public string Alias { get; set; }
    }
}
