
namespace geogo.service.Interface
{
    using geogo.domain.database;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IDBAccessService
    {
        Task<IList<tbPin>> GetAllPins();
    }
}
