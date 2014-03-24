using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.DataAccess.Entity
{
    public class Entry : Base.Entity
    {
        public int DiaryId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Message { get; set; }

        public Diary Diary { get; set; }
    }
}
