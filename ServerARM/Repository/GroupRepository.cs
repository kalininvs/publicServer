namespace ServerARM.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Context;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class GroupRepository : IGroupRepository, IDisposable
    {
        private MainContext _context;
        private bool disposed = false;
        public GroupRepository(MainContext context)
        {
            _context = context;
        }
        public IEnumerable<Group> Select()
        {
            return _context.Groups.FromSqlRaw("Group_Select");
        }
        
        public void Insert(Group entity)
        {
            _context.Groups.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var item = _context.Groups.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null))
                return;
            _context.Groups.Remove(item);
            Save();
        }
        public void Update(Group entity)
        {
            _context.Groups.Update(entity);
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
