namespace ServerARM.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Context;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SemestrRepository: ISemestrRepository,IDisposable
    {
        private MainContext _context;
        private bool disposed = false;
        public SemestrRepository(MainContext context)
        {
            _context = context;
        }
        public IEnumerable<Semestr> Select()
        {
            return _context.Semestrs.FromSqlRaw("Semestr_Select");
        }

        public void Insert(Semestr entity)
        {
            _context.Semestrs.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var item = _context.Semestrs.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null))
                return;
            _context.Semestrs.Remove(item);
            Save();
        }
        public void Update(Semestr entity)
        {
            _context.Semestrs.Update(entity);
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
