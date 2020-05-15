using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestExam.Domain.Entities
{
    [Table("CommentLIkeDislike")]
    public class CommentListDislikeModel
    {
        public int Id { set; get; }
        public int CommentId { set; get; }
        public int Like { set; get; }
        public int Dislike { set; get; }
        public DateTime CreateDate { set; get; }
        public int UserId { set; get; }
    }
}
