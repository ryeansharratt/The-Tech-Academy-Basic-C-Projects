using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBProject
{
    public class SchoolContext : DbContext //context class, representing a session to query and save data
    {
        public SchoolContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; } //the objects that (once made) can be queried from db 
        public DbSet<Grade> Grades { get; set; }
    }
}
