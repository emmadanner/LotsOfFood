using LotsOfFood.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LotsOfFood.Data
{
    // stores information about the user's previous orders
    internal class OrderDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public OrderDatabase(String dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<Order>();
        }
        public Task<List<Order>> GetItemsAsync()
        {
            return _database.Table<Order>().ToListAsync();
        }
        public Task<List<Order>> GetItemsNotDoneAsync()
        {
            return _database.QueryAsync<Order>("SELECT * FROM [Order] WHERE [InOrder] = 0");
        }
        public Task<Order> GetItemAsync(int id)
        {
            return _database.Table<Order>().Where(i => i.OrderID == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveItemAsync(Order item)
        {
            if (item.OrderID != 0)
            {
                return _database.UpdateAsync(item);
            }
            else
            {
                return _database.InsertAsync(item);
            }
        }
        public Task<int> DeleteItemAsync(Order item)
        {
            return _database.DeleteAsync(item);
        }
    }
}