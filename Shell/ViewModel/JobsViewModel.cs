using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shell.Models
{
    public class JobViewModel
    {
        public dynamic Job { get; set; }
    }

    public class JobsViewModel
    {
        public IEnumerable<dynamic> Jobs { get; set; }
        public int CurrentPage { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}