using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class MyList<T> : IMyCollection<T>, IMyList<T>, IEnumerable
    {
        public T[] items;

        public T this[int index] { get => items[index]; set => items[index]=value; }

        public int Count => this.Count;

        public int Capacity => this.Capacity;

        public void Add(T item)
        {
            if (items == null)
            {
                Array.Resize(ref items, 1);
                items[0] = item;
            }
            else
            {
                Array.Resize(ref items, items.Length + 1);
                items[items.Length-1] = item;
            }

        }

        public void Clear()
        {
            Array.Clear(items, 0, items.Length);
        }

        public bool Contains(T value)
        {
            if (Array.BinarySearch(items, value) >= 0)
                return true;
            return false;
        }

        public IEnumerator GetEnumerator()   
        {
            return items.GetEnumerator();
        }

        public int IndexOf(T item)
        {

            return Array.IndexOf(items, item);
        }

        public void Insert(T item, int index)
        {
            T[] newArr = new T[items.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = items[i];
            }
            newArr[index] = item;
            for (int i = index + 1; i < items.Length; i++)
            {
                newArr[i] = items[i - 1];
            }
            Array.Resize(ref items, items.Length + 1);
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = newArr[i];
            }
        }

        private void Insert(int index, T item)
        {
            T[] newArr = new T[items.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = items[i];
            }
            newArr[index] = item;
            for (int i = index + 1; i < items.Length; i++)
            {
                newArr[i] = items[i - 1];
            }
            Array.Resize(ref items, items.Length + 1);
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = newArr[i];
            }
        }

        public void RemoveAt(T item)
        {
            T[] newArr = new T[items.Length - 1];
            for (int i = 0; i < Array.BinarySearch(items, item); i++)
            {
                newArr[i] = items[i];
            }
            for (int i = Array.BinarySearch(items, item) + 1; i < items.Length; i++)
            {
                newArr[i - 1] = items[i];
            }
            Array.Resize(ref items, items.Length - 1);
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = newArr[i];
            }
           
        }

        public void RemoveAt(int index)
        {
            if(items.Length==1)
            {
                Array.Resize(ref items, 0);
                return;
            }    
            T[] newArr = new T[items.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = items[i];
            }
            for (int i = index + 1; i < items.Length; i++)
            {
                newArr[i-1] = items[i];
            }
            Array.Resize(ref items, items.Length - 1);
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = newArr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
