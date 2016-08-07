namespace geogo.Service
{
    using geogo.Dbcontext;
    using geogo.Interface;
    using geogo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public class geogoDbService: IgeogoDbService
    {
        Igeogocontext _db = new geogocontext();
        public async Task<IList<tbPin>> ConnectionTest()
        {
            IList<tbPin> list = new List<tbPin>();
            try
            {
                list = await _db.tbPins.ToListAsync();

            }
            catch (Exception ex)
            {
                var tt = ex.Message;
            }

            return list;
        }

        public async Task<tbUser> UserTest()
        {
            tbUser user = new tbUser();

            try
            {
                user = await _db.tbUsers.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                var dd = ex.Message;
            }


            return user;
        }
    }
}
