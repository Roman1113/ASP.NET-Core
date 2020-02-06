using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class BlogModel
    {
        public int id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string preview { get; set; }
        public string fullPost { get; set; }
        public string img { get; set; }
    }
}
