using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros.IDAO
{
    public class IHeros<T>
    {
        // Create
        void Add(T entity);

        // Read
        T GetById(string id);
        IEnumerable<T> GetAll();

        // Update
        void Update(T entity);

        // Delete
        void Delete(string id);
    }
}
