using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestExam.Domain.Entities;
using TextExam.Repository;

namespace TestExam.Service.Implementation
{
    public class PostCommentService : IPostCommentService
    {
        private readonly IPostCommentRepository _postCommentRepository;
        public PostCommentService(IPostCommentRepository postCommentRepository)
        {
            _postCommentRepository = postCommentRepository;
        }

        public async Task<List<PostModel>> Test()
        {
            return await _postCommentRepository.Test();
        }
    }
}
