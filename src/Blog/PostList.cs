using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog
{
    public static class PostList
    {

        public static IList<PostData> GetMostRecentPosts(int count)
        {
            return _posts.OrderByDescending(p => p.TimeStamp).Take(count).ToList();
        }

        private static readonly string CONTENT_BASE_PATH = "posts/content/";
        private static List<PostData> _posts = new List<PostData>()
        {

            new PostData(
                CONTENT_BASE_PATH + "creating-static-website-using-blazor-and-azure.md",
                "Creating static website using blazor and azure",
                new DateTime(2019, 6, 15, 22, 11, 0, DateTimeKind.Utc)
            ),
            new PostData(
                CONTENT_BASE_PATH + "creating-markdown-blog-in-blazor.md",
                "Creating a markdown blog in blazor",
                new DateTime(2019, 6, 16, 3, 9, 0, DateTimeKind.Utc)
            ),
            new PostData(
                CONTENT_BASE_PATH + "create-pwa-with-blazor.md",
                "Transform a blazor app into a PWA",
                new DateTime(2019, 6, 16, 18, 37, 0, DateTimeKind.Utc)
            ),
        };

    }
}
