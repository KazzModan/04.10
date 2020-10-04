using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    interface IMyCollection<T>
    {
        int Count { get; }
        int Capacity { get; }
        void Clear();
        bool Contains(T value);
        void RemoveAt(T item);
        void Insert(T item,int index);
        void Add(T item);

    }
}
