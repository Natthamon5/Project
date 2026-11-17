using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace management.Models
{
    public class Appdbmodels
    {
    }

    [Table("Members")] // ชื่อตารางใน SQL Server
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
