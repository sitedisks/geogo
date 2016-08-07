
namespace geogo.service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using geogo.Models;
    public interface IDBAccessService
    {
        Task<IList<tbPin>> GetAllPins();
    }
}
