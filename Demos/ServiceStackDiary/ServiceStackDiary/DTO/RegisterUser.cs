using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceStackDiary.DTO
{
    [Route("/RegisterUser")]
    [Route("/RegisterUser/{Name}/{Alias}")]
    public class RegisterUser
    {
        public string Name { get; set; }
        public string Alias { get; set; }
    }
}