using Microsoft.EntityFrameworkCore;
using ToDo.Data.Context;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Models;

namespace ToDo.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ToDoContext _context;
        protected readonly DbSet<T> _dataSet;
        public BaseRepository(ToDoContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }
        public async void Delete(int id)
        {
            var item = await _dataSet.FindAsync(id);
            _dataSet.Remove(item);
            await Task.Delay(1000);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
           return await _dataSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dataSet.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Insert(T item)
        {
            _dataSet.Add(item);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
             var result = this.GetById(item.Id);

            _context.Entry(result).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
    }
}