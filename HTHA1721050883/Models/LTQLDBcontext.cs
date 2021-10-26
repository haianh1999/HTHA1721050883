using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HTHA1721050883.Models
{
    public partial class LTQLDBcontext : DbContext
    {
        internal object Person;

        public LTQLDBcontext()
            : base("name=LTQLDBcontext1")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public object People { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
