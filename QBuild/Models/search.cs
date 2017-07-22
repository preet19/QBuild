namespace QBuild.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class search : DbContext
    {
        public search()
            : base("name=search")
        {
        }

        public virtual DbSet<bom> boms { get; set; }
        public virtual DbSet<part> parts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bom>()
                .Property(e => e.PARENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<bom>()
                .Property(e => e.COMPONENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<part>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<part>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<part>()
                .Property(e => e.ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<part>()
                .Property(e => e.PART_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<part>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<part>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);
        }
    }
}
