namespace ServerARM.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Context;
    using ServerARM.Interface;
    using ServerARM.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StudentGroupRepository: IStudentGroupRepository,IDisposable
    {
        private MainContext _context;
        private bool disposed = false;
        public StudentGroupRepository(MainContext context)
        {
            _context = context;
        }
        public IEnumerable<StudentGroup> Select()
        {
            return _context.StudentGroups.FromSqlRaw("Semestr_Select");
        }

        public void Insert(StudentGroup entity)
        {
            _context.StudentGroups.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var item = _context.StudentGroups.Where(x => x.id == id).FirstOrDefault();
            if (item.Equals(null))
                return;
            _context.StudentGroups.Remove(item);
            Save();
        }
        public void Update(StudentGroup entity)
        {
            _context.StudentGroups.Update(entity);
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
