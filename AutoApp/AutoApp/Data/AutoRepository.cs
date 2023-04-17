using AutoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoApp.Data
{
    public class AutoRepository : IRepository<Auto>
    {
        private readonly AutoDbContext _dbContext;
        public AutoRepository(AutoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int id)
        {
            var auto = _dbContext.Autos.SingleOrDefault(r => r.ID == id);
            _dbContext.Autos.Remove(auto!);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Auto> GetAll()
        {
            return _dbContext.Autos.Include(a => a.Merk).OrderBy(a => a.Nickname).ToList();
        }

        public Auto GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Auto obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Auto obj)
        {
            throw new NotImplementedException();
        }
    }
}
