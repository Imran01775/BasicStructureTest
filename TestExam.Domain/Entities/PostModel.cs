using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestExam.Domain.Entities
{
    [Table("PostDetails")]
    public class PostModel
    {
        public int Id { set; get; }
        public string Post { set; get; }
        public DateTime CreateDate { set; get; }
        public DateTime UpdateDate { set; get; }
        public int UserId { set; get; }
        public bool IsActive { set; get; }
    }
}
