using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Interfaces;

namespace Utility
{
    public class MyLinkedList<T> : IMyLinkedList<T>
    {

        private bool isSort { get; set; } = false;
        private Node<T> head { get; set; }
        public int Count { get; private set; } = 0;
        public T First
        {
            get => GetValue(0);
        }

        public T Last
        {
            get => GetValue(Count-1);
        }

        public T this[int index]
        {
            get { return GetValue(index); }
        }


        public MyLinkedList()
        {
            head = null;
        }


        public T Add(int index, T value)
        {

            if (index < 0) throw new ArgumentOutOfRangeException("Index: " + index);

            if (index > Count) index = Count;


            Node<T> current = head;

            if (Count == 0 || index == 0)
            {
                head = new Node<T>(value, head);
            }
            else
            {
                for (int i = 0; i < index -1 ; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node<T>(value, current.Next);
            }

            Count++;
            return value;
        }

        public T Add(T value)
        {
            return Add(Count, value);
        }

        public int IndexOf(T value) 
        {
            Node<T> current = head;

            for (int i = 0; i < Count; i++)
            {
                if (current.Value.Equals(value)) return i;
                current = current.Next;
            }

            return -1;

        }


        public bool RemoveByIndex(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException("Index: " + index);

            if (Count == 0) return false;

            if (index >= Count) index = Count - 1;

            Node<T> current = head;
            bool result = false;

            if (index == 0)
            {
                result = true;
                head = current.Next;
            }
            else
            {
                for (int i = 0; i < index -1; i++)
                {
                    current = current.Next;
                }

                result = true;
                current.Next = current.Next.Next;
            }

            Count--;
            return result;
        }

        public void Remove(T value)
        {
            int index = IndexOf(value);
            RemoveByIndex(index);
        }

        public void RemoveAfter(T value)
        {
            int index = IndexOf(value) + 1;
            RemoveByIndex(index);
        }

        public void RemoveAllAfter(T value)
        {
            int index = IndexOf(value) + 1;

            while (index < Count)
            {
                RemoveByIndex(index);
            }
        }

        public bool RemoveLast()
        {
            int index = Count - 1;

            return RemoveByIndex(index);
        }

        public bool RemoveFirst()
        {
            int index = 0;

            return RemoveByIndex(index);
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }



        public bool Contains(T value)
        {
            return IndexOf(value) >= 0;
        }

        public T GetValue(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException("Index: " + index);

            //if (Count == 0) return null;

            if (index >= Count) index = Count - 1;

            Node<T> current = head;


            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public Array ToArray() 
        {
            Node<T> current = head;


            T[] array = new T[Count];


            for (int i = 0; i < Count; i++)
            {
                array[i] = current.Value;
                current = current.Next;

            }

            return array;

        }
        public Array ToClonedArray()
        {
            var array = ToArray();
            var result = (T[])array.Clone();
            return result;

        }

        public Array Sort()
        {
            isSort = true;

            var arr = ToArray();
            Array.Sort(arr);

            return arr;
        }


        // Foreach Loop
        public IEnumerator<T> GetEnumerator()
        {
            var arr = new T[Count];

            if (isSort) arr = (T[])Sort();
            else arr = (T[])ToArray();


            return new Enumerator<T>(arr); // Enumerator Class
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
