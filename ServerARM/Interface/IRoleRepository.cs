namespace ServerARM.Interface
{
    using ServerARM.Models;
    using System.Collections.Generic;

    public interface IRoleRepository
    {
        IEnumerable<Role> Select();
        void Insert(Role entity);
        void Delete(int id);
        void Update(Role entity);
        void Save();
        void Dispose();
    }
}
