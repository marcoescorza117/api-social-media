using Microsoft.EntityFrameworkCore;
using SocialMediaBackend.Core.Data;
using SocialMediaBackend.Core.Entities;
using SocialMediaBackend.Core.Interfaces;
using SocialMediaBackend.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaBackend.Infrastructure.Repositories
{
    public class PostRepository :IPostRepository
    {
        //inyeccioon de dependencias
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            /*var post = Enumerable.Range(1, 10).Select(x => new Post { 
            
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https://www.glgo.com/test{x}.jpg",
                UserId = x*2

            });
            await Task.Delay(10);
            return post;
            */

            var post = await _context.Publicacions.ToListAsync(); //Directamnet a base de datos
            return post;


        }

        
    }
}
