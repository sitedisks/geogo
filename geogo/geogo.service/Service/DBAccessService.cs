
namespace geogo.service.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using geogo.Models;
    using geogo.Dbcontext;
    public class DBAccessService: IDBAccessService
    {
        Igeogocontext _db = new geogocontext();
        public async Task<IList<tbPin>> GetAllPins() {
            IList<tbPin> list = new List<tbPin>();

            try {
                list = await _db.tbPins.ToListAsync();
            }
            catch (Exception ex) {
            
            }

            return list;
        }
    }
}
