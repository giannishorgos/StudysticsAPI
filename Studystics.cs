using Microsoft.EntityFrameworkCore;

namespace StudysticsDB.Models
{
    public class MasterProgram
    {
        public int MasterId { get; set; }
        public double Duration { get; set; }
        public string? Name { get; set; }
        public bool Thesis { get; set; }
        public bool Internship { get; set; }
        public float Delivered { get; set; }
        public float Price { get; set; }
        public string? UniversityCode { get; set; }
        public int RequirementId { get; set; }
        public int ApplicationId { get; set; }
    }

    // public class Lessons {}

    // public class Professors {}

    public class StudysticsDB : DbContext
    {
        public StudysticsDB(DbContextOptions options) : base(options) { }
        public DbSet<MasterProgram> Masters { get; set; } = null!;
    }

}
