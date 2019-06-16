using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Model
{
    public class PostData
    {
        public string ContentPath { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public string Title { get; private set; }

        public PostData(string contentPath, string title, DateTime timestamp)
        {
            this.ContentPath = contentPath;
            this.Title = title;
            this.TimeStamp = timestamp;
        }
    }
}
