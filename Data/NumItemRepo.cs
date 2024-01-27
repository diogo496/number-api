using NumberAPI.Models;

namespace NumberAPI.Data
{
    public class NumItemRepo : INumItemRepo
    {
        private readonly AppDbContext _context;

        public NumItemRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateNumItem(NumItem numItem)
        {
            Random random = new Random();
            numItem.Id = random.Next(1, 1000000);
            _context.NumItems.Add(numItem);
        }

        public IEnumerable<NumItem> GetAllNumItems()
        {
            return _context.NumItems.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
