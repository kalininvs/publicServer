namespace ServerARM.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Context;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RoleRepository :IRoleRepository,IDisposable
    {
        private MainContext _context;
        private bool disposed = false;
        public RoleRepository(MainContext context)
        {
            _context = context;
        }
        public IEnumerable<Role> Select()
        {
            return _context.Roles.FromSqlRaw("Role_Select");
        }

        public void Insert(Role entity)
        {
            _context.Roles.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var item = _context.Roles.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null))
                return;
            _context.Roles.Remove(item);
            Save();
        }
        public void Update(Role entity)
        {
            _context.Roles.Update(entity);
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
