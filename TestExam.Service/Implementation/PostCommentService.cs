using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExam.Domain.Entities;
using TestExam.Service.CustomException;
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
            var responseData = await _postCommentRepository.Test();

            if(!responseData.Any())
                throw new CustomHttpException(204, "No data Found");

            return responseData;
        }
    }
}
