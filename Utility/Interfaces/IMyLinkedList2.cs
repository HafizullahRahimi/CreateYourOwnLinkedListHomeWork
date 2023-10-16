using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Interfaces
{
    public interface IMyLinkedList2<T> : ICollection<T>
    {
        //int Count { get; }
        //void Remove(T value);
        //public T Add(T value); 
        //void Clear();
        //bool Contains(T value);
        T First { get; }
        T Last { get; }

        void Add(int index, T value); 

        bool RemoveByIndex(int index);
        bool RemoveLast();
        bool RemoveFirst();
        void RemoveAfter(T value);
        void RemoveAllAfter(T value);

        int IndexOf(T value);
        T GetValue(int index);



        //Array ToArray(); private
        Array ToClonedArray();
        Array Sort();

        //ForEach


    }
}

