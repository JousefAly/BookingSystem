using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem_DAL.Contracts
{
    public interface IRepository<T>
    {
        public T Create(T _object);
        public bool Delete(T _object);
        public T Update(T _object);
        public IEnumerable<T> GetAll();
        public T GetById(int id);
    }
}
