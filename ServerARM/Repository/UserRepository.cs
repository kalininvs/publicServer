namespace ServerARM.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Context;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class UserRepository:IUserRepository,IDisposable
    {
        private MainContext _context;
        private bool disposed = false;
        public UserRepository(MainContext context)
        {
            _context = context;
        }
        public IEnumerable<User> Select()
        {
            return _context.Users.FromSqlRaw("Semestr_Select");
        }

        public void Insert(User entity)
        {
            _context.Users.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var item = _context.Users.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null))
                return;
            _context.Users.Remove(item);
            Save();
        }
        public void Update(User entity)
        {
            _context.Users.Update(entity);
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
