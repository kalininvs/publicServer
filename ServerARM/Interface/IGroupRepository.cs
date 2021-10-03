namespace ServerARM.Interface
{
    using ServerARM.Models;
    using System.Collections.Generic;
    public interface IGroupRepository
    {
        IEnumerable<Group> Select();
        void Insert(Group entity);
        void Delete(int id);
        void Update(Group entity);
        void Save();
        void Dispose();
    }
}
