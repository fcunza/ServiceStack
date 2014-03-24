using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.DataAccess.Entity
{
    public class Diary : Base.Entity
    {
        public int AuthorId { get; set; }

        public User Author { get; set; }
        public IEnumerable<Entry> Entries { get; set; }
    }
}
