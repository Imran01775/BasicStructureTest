using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using TestExam.DataContext;
using TestExam.Domain.Entities;

namespace TextExam.Repository.Implementation
{
    public class PostCommentRepository : IPostCommentRepository
    {
        private readonly SqlServerContext _sqlServerContext;
        public PostCommentRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext ?? throw new ArgumentNullException(nameof(sqlServerContext));

        }


        public async Task<List<PostModel>> Test()
        {
           
            var response = await _sqlServerContext.PostModel.ToListAsync();
            return response;
        }
    }
}
