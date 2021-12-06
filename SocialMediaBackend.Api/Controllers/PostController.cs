using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMediaBackend.Core.Interfaces;
using SocialMediaBackend.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaBackend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IPostRepository _postRespository;
        public PostController(IPostRepository postRespository)
        {
            _postRespository = postRespository;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var posts = await _postRespository.GetPosts();
            return Ok(posts); 
        }
    }
}
