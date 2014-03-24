using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceStackDiary.Host
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Diary Service", typeof(DiaryService).Assembly) { }

        public override void Configure(Funq.Container container)
        { }
    }
}