using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASPNETMVC.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string DateTime { get; set; }

    }
}