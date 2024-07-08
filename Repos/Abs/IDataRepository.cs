using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Data
{
    public interface IDataRepository <T>
    {
        List<T> GetAll ();
        T Get (string id);
        void Create (T model);
        void Delete (string id);
        void Update (T model);
    }
}
