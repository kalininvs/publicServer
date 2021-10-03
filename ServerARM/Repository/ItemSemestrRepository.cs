namespace ServerARM.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Context;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ItemSemestrRepository: IItemSemestrRepository,IDisposable
    {
        private MainContext _context;
        private bool disposed = false;
        public ItemSemestrRepository(MainContext context)
        {
            _context = context;
        }
        public IEnumerable<ItemSemestr> Select()
        {
            return _context.ItemSemestrs.FromSqlRaw("ItemSemestr_Select");
        }

        public void Insert(ItemSemestr entity)
        {
            _context.ItemSemestrs.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var item = _context.ItemSemestrs.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null))
                return;
            _context.ItemSemestrs.Remove(item);
            Save();
        }
        public void Update(ItemSemestr entity)
        {
            _context.ItemSemestrs.Update(entity);
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
