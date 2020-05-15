using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestExam.Domain.Entities;

namespace TestExam.Service
{
    public interface IPostCommentService
    {
        Task<List<PostModel>> Test();
    }
}
