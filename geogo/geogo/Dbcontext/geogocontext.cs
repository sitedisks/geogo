namespace geogo.data.Dbcontext
{
    using geogo.data.Interface;
    using geogo.domain.database;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class geogocontext : DbContext, Igeogocontext
    {
        public geogocontext() : base("name=geogocontext") { }

        #region entities
        public virtual DbSet<tbPin> tbPins { get; set; }
        public virtual DbSet<tbPinComment> tbPinComments { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
        public virtual DbSet<tbUserPin> tbUserPins { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbPin>()
                .Property(e => e.ImageUri)
                .IsUnicode(false);

            modelBuilder.Entity<tbPin>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<tbPin>()
                .HasMany(e => e.tbPinComments)
                .WithRequired(e => e.tbPin)
                .HasForeignKey(e => e.PinId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbPin>()
                .HasMany(e => e.tbUserPins)
                .WithRequired(e => e.tbPin)
                .HasForeignKey(e => e.PinId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbPinComment>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<tbUser>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<tbUser>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<tbUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tbUser>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbUser>()
                .Property(e => e.AuthToken)
                .IsUnicode(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbPins)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbPinComments)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbUserPins)
                .WithOptional(e => e.tbUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbUserPin>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);
        }

        public System.Data.Entity.Core.Objects.ObjectContext BaseContext
        {
            get { return ((IObjectContextAdapter)this).ObjectContext; }
        }
    }
}
