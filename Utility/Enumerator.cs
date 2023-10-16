using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Enumerator<T> : IEnumerator<T>
    {
        public T[] list;
        int position = -1;

        public Enumerator(T[] list)
        {
            this.list = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < list.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {

            get
            {
                try
                {
                    return list[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        {

        }

    }
}
