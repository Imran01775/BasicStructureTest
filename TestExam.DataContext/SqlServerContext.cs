using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestExam.Domain.Entities;

namespace TestExam.DataContext
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {

        }
        public DbSet<PostModel> PostModel { set; get; }
        public DbSet<CommentModel> CommentModel { set; get; }
        public DbSet<UsersModel> UsersModel { set; get; }
        public DbSet<CommentListDislikeModel> CommentListDislikeModel { set; get; }

    }
}
