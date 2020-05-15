using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestExam.Domain.Entities
{
    [Table("Users")]
    public class UsersModel
    {
        public int Id { set; get; }
        public string UserName { set; get; }
        public int UserType { set; get; }
        public DateTime CreateDate { set; get; }
        public bool IsActive { set; get; }
    }
}
