namespace geogo.Interface
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Threading.Tasks;
    using Models;
    public interface Igeogocontext: IDisposable
    {
        Database Database { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        ObjectContext BaseContext { get; }

        #region entities
        DbSet<tbPin> tbPins { get; set; }
        DbSet<tbPinComment> tbPinComments { get; set; }
        DbSet<tbUser> tbUsers { get; set; }
        DbSet<tbUserPin> tbUserPins { get; set; }
        #endregion
    }
}
