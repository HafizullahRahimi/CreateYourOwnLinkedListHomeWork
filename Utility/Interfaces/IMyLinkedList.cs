using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Interfaces
{
    public interface IMyLinkedList<T> : IEnumerable<T>
    {
        int Count { get; }
        T First { get; }
        T Last { get; }

        T Add(int index, T value); //void AddBefore();
        public T Add(T value); // void AddFirst();

        void Clear();
        bool RemoveByIndex(int index);
        void Remove(T value);
        bool RemoveLast();
        bool RemoveFirst();
        void RemoveAfter(T value);
        void RemoveAllAfter(T value);

        int IndexOf(T value);
        bool Contains(T value);


        T GetValue(int index);

        Array ToArray();
        Array ToClonedArray();
        Array Sort();

        //ForEach


    }
}
