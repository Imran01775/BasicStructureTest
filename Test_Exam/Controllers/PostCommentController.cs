using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestExam.Domain.Entities;
using TestExam.Service;

namespace Test_Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCommentController : ControllerBase
    {

        private readonly IPostCommentService _postCommentService;
        public PostCommentController(IPostCommentService postCommentService)
        {
            _postCommentService = postCommentService;
        }
        [HttpGet("test")]
        [ProducesResponseType(typeof(List<PostModel>), 200)]
        public async Task<IActionResult> Test()
        {
            return Ok(await _postCommentService.Test());
        }
    }
}