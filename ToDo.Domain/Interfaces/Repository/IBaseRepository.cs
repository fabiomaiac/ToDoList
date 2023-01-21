using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity 
    {
        public void Insert(T item);
        public void Delete(int id);
        public void Update(T item);
        public Task<List<T>> GetAll();
        public Task<T> GetById(int id);
    }
}