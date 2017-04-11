﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MobileTest
{
    public class MobileDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public MobileDatabase (string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Cliente>().Wait();
        }

        public Task<List<Cliente>> GetClientsAsync()
        {
            return _database.Table<Cliente>().ToListAsync();
        }

        public Task<Cliente> GetClienteByCodigo( int conseccutivocompania, string codigo)
        {
            return _database.Table<Cliente>().Where(i => i.ConsecutivoCompania == conseccutivocompania).Where(c => c.Codigo== codigo).FirstOrDefaultAsync();
        }
    }
}
