using System.Data.Entity;

namespace management.Models
{
    public class AppDbContext : DbContext
    {
        // ใส่ Connection String ชี้ไปที่ SQL Server ของคุณ
        public AppDbContext() : base(@"Server=ชื่อเครื่องของคุณ;Database=ชื่อฐานข้อมูล;Trusted_Connection=True;")
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}