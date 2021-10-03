namespace ServerARM.Interface
{
    using ServerARM.Models;
    using System.Collections.Generic;

    public interface IItemRepository
    {
        IEnumerable<Item> Select();
        void Insert(Item entity);
        void Delete(int id);
        void Update(Item entity);
        void Save();
        void Dispose();
    }
}
