namespace ServerARM.Interface
{
    using ServerARM.Models;
    using System.Collections.Generic;

    public interface IItemSemestrRepository
    {
        IEnumerable<ItemSemestr> Select();
        void Insert(ItemSemestr entity);
        void Delete(int id);
        void Update(ItemSemestr entity);
        void Save();
        void Dispose();
    }
}
