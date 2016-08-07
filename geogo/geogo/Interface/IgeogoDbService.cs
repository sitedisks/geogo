namespace geogo.Interface
{
    using geogo.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IgeogoDbService
    {
        Task<IList<tbPin>> ConnectionTest();
        Task<tbUser> UserTest();
    }
}
