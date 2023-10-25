using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTry
{
    public class MyList<T>

    {
        private List<T> _data;

        public MyList()
        {
            _data = new List<T>();
        }

        public void AddData(T addData)
        {
            _data.Add(addData);
        }

        public T GetIndex(int index)
        {
            return _data[index];
        }
    }
}
