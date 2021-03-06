﻿
namespace geogo.service.Service
{
    using geogo.data.Interface;
    using geogo.domain.database;
    using geogo.service.Interface;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public class DBAccessService: IDBAccessService
    {
        private readonly Igeogocontext _db;

        public DBAccessService(Igeogocontext db) {
            _db = db;
        }

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
