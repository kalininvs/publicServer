namespace ServerARM.Interface
{
    using ServerARM.Models;
    using System.Collections.Generic;

    public interface ISemestrRepository
    {
        IEnumerable<Semestr> Select();
        void Insert(Semestr entity);
        void Delete(int id);
        void Update(Semestr entity);
        void Save();
        void Dispose();
    }
}
