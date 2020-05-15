using System;
using System.Collections.Generic;
using System.Text;

namespace TestExam.Domain.ViewModel
{
    public class PostCommentViewModel
    {
        public List<PostViewModel> PostViewModel { set; get; }
    }
    public class PostViewModel
    {
        public string Post { set; get; }
        public string UserType { set; get; }
        public DateTime PostDate { set; get; }
        public int TotalComment { set; get; }
    }
    public class CommentViewModel
    {

        public string Comment { set; get; }
        public string UserName { set; get; }
        public DateTime CommentDate { set; get; }
        public int TotalCommentLike { set; get; }
        public int TotalCommentDislike { set; get; }

    }
}
