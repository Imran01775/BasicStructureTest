using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestExam.Domain.Entities;

namespace TextExam.Repository
{
    public interface IPostCommentRepository
    {
        Task<List<PostModel>> Test();
    }
}
