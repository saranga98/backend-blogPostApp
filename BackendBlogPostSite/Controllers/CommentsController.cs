using BackendBlogPostSite.Data;
using BackendBlogPostSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackendBlogPostSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly BlogContext _context;

        public CommentsController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet("{postId}")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComments(int postId)
        {
            return await _context.Comments.Where(c => c.PostId == postId).ToListAsync();
        }

        [HttpPost("{postId}")]
        public async Task<ActionResult<Comment>> PostComment(int postId, CommentDto commentDto)
        {
            var comment = new Comment
            {
                PostId = postId,
                Name = commentDto.Name,
                Content = commentDto.Content
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComments", new { postId = comment.PostId }, comment);
        }
    }

}
