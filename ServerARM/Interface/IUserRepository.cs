namespace ServerARM.Interface
{
    using ServerARM.Models;
    using System.Collections.Generic;

    public interface IUserRepository
    {
        IEnumerable<User> Select();
        void Insert(User entity);
        void Delete(int id);
        void Update(User entity);
        void Save();
        void Dispose();
    }
}
