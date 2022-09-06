using AppCustoViagem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace AppCustoViagem.Helper
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);

            _conn.CreateTableAsync<Pedagio>().Wait();

        }


        public void insert(Pedagio p)
        {

        }
        public void update(Pedagio p)
        {

        }

        public Task<List<Pedagio>> getAll()
        {
            return _conn.Table<Pedagio>().ToListAsync();
        }

        public Task<int> delete(int id)
        {
            return _conn.Table<Pedagio>().DeleteAsync(i => i.Id == id);
        }
    }
}
