using SocialMediaBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaBackend.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var post = Enumerable.Range(1, 10).Select(x => new Post { 
            
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https://www.glgo.com/test{x}.jpg",
                UserId = x*2

            });

            return post;
        }
    }
}
