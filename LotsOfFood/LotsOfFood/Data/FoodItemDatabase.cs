using LotsOfFood.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LotsOfFood.Data
{
    // stores information about the food options
    internal class FoodItemDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public FoodItemDatabase(String dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<FoodItem>();
        }
        public Task<List<FoodItem>> GetItemsAsync()
        {
            return _database.Table<FoodItem>().ToListAsync();
        }
        public Task<List<FoodItem>> GetItemsNotDoneAsync()
        {
            return _database.QueryAsync<FoodItem>("SELECT * FROM [FoodItem] WHERE [Done] = 0");
        }
        public Task<FoodItem> GetItemAsync(int id)
        {
            return _database.Table<FoodItem>().Where(i => i.ItemID == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveItemAsync(FoodItem item)
        {
            if (item.ItemID != 0)
            {
                return _database.UpdateAsync(item);
            }
            else
            {
                return _database.InsertAsync(item);
            }
        }
        public Task<int> DeleteItemAsync(FoodItem item)
        {
            return _database.DeleteAsync(item);
        }


    }
}