namespace ServerARM.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Context;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ItemRepository : IItemRepository, IDisposable
    {
        private MainContext _context;
        private bool disposed = false;
        public ItemRepository(MainContext context)
        {
            _context = context;
        }
        public IEnumerable<Item> Select()
        {
            return _context.Items.FromSqlRaw("Item_Select");
        }

        public void Insert(Item entity)
        {
            _context.Items.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var item = _context.Items.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null))
                return;
            _context.Items.Remove(item);
            Save();
        }
        public void Update(Item entity)
        {
            _context.Items.Update(entity);
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
