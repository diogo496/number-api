using NumberAPI.Models;

namespace NumberAPI.Data
{
    public interface INumItemRepo
    {
        IEnumerable<NumItem> GetAllNumItems();
        void CreateNumItem(NumItem numItem);
        bool SaveChanges();
    }
}
