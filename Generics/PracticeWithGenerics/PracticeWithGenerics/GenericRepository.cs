using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeWithGenerics.Entities;

namespace PracticeWithGenerics
{
    public interface IRepository<T>
    {
        public void Add(T item);
        public void Remove(T item);
        public void Save();
        public IEnumerable<T> GetAll();
        public T GetById(int id);
    }

    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> _list;

        public GenericRepository()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }
        public void Save()
        {

        }
        public IEnumerable<T> GetAll()
        {
            return _list.AsEnumerable();
        }
        public T GetById(int id)
        {
            foreach(T item in _list)
            {
                if (item.Id == id) { return item; }
            }
            return null;
        }
    }
}
