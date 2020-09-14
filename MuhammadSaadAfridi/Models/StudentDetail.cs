using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MuhammadSaadAfridi.Models
{
    public class StudentDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public string Sex { get; set; }
        public float GPA { get; set; }
    }
    public class StudentDetailDBContext : DbContext
    {
        public DbSet<StudentDetail> Students { get; set; }
    }
}