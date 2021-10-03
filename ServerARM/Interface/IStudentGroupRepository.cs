namespace ServerARM.Interface
{
    using ServerARM.Models;
    using System.Collections.Generic;
    public interface IStudentGroupRepository
    {
        IEnumerable<StudentGroup> Select();
        void Insert(StudentGroup entity);
        void Delete(int id);
        void Update(StudentGroup entity);
        void Save();
        void Dispose();
    }
}
