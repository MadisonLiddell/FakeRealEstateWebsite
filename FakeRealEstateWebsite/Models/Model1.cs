namespace FakeRealEstateWebsite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<agent> agents { get; set; }
        public virtual DbSet<assistant> assistants { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<office> offices { get; set; }
        public virtual DbSet<property> properties { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<team> teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<agent>()
                .Property(e => e.agent_fname)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.agent_lname)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.agent_address)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.agent_city)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.agent_state)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.agent_zipcode)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .HasMany(e => e.teams)
                .WithRequired(e => e.agent)
                .HasForeignKey(e => e.fk_agent_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<assistant>()
                .Property(e => e.assist_fname)
                .IsUnicode(false);

            modelBuilder.Entity<assistant>()
                .Property(e => e.assist_lname)
                .IsUnicode(false);

            modelBuilder.Entity<assistant>()
                .Property(e => e.assist_address)
                .IsUnicode(false);

            modelBuilder.Entity<assistant>()
                .Property(e => e.assist_city)
                .IsUnicode(false);

            modelBuilder.Entity<assistant>()
                .Property(e => e.assist_state)
                .IsUnicode(false);

            modelBuilder.Entity<assistant>()
                .HasMany(e => e.teams)
                .WithRequired(e => e.assistant)
                .HasForeignKey(e => e.fk_assist_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .Property(e => e.client_fname)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.client_lname)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.client_address)
                .IsUnicode(false);

            modelBuilder.Entity<office>()
                .Property(e => e.off_address)
                .IsUnicode(false);

            modelBuilder.Entity<office>()
                .Property(e => e.off_city)
                .IsUnicode(false);

            modelBuilder.Entity<office>()
                .Property(e => e.off_state)
                .IsUnicode(false);

            modelBuilder.Entity<office>()
                .HasMany(e => e.agents)
                .WithOptional(e => e.office)
                .HasForeignKey(e => e.fk_off_code);

            modelBuilder.Entity<property>()
                .Property(e => e.prop_type)
                .IsUnicode(false);

            modelBuilder.Entity<property>()
                .Property(e => e.prop_address)
                .IsUnicode(false);

            modelBuilder.Entity<property>()
                .Property(e => e.prop_owner_fname)
                .IsUnicode(false);

            modelBuilder.Entity<property>()
                .Property(e => e.prop_owner_lname)
                .IsUnicode(false);

            modelBuilder.Entity<property>()
                .Property(e => e.prop_city)
                .IsUnicode(false);

            modelBuilder.Entity<property>()
                .Property(e => e.prop_state)
                .IsUnicode(false);

            modelBuilder.Entity<property>()
                .HasOptional(e => e.status)
                .WithRequired(e => e.property);

            modelBuilder.Entity<status>()
                .Property(e => e.stat_current)
                .IsUnicode(false);
        }
    }
}
