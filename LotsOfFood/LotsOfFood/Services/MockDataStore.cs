using LotsOfFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsOfFood.Services
{
    public class MockDataStore : IDataStore<FoodItem>
    {
        readonly List<FoodItem> items;

        public MockDataStore()
        {
            items = new List<FoodItem>()
            {
                new FoodItem { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new FoodItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new FoodItem { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new FoodItem { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new FoodItem { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new FoodItem { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(FoodItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(FoodItem item)
        {
            var oldItem = items.Where((FoodItem arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((FoodItem arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<FoodItem> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<FoodItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}