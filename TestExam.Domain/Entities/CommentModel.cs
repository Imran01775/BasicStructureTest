using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestExam.Domain.Entities
{
    [Table("PostCommentDetails")]
    public class CommentModel
    {
        public int Id { set; get; }
        public string Comment { set; get; }
        public int PostId { set; get; }
        public DateTime CreateDate { set; get; }
        public DateTime UpdateOn { set; get; }
        public bool IsActive { set; get; }
    }
}
