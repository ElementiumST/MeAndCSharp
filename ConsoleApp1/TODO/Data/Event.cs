using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TODO.Data
{
    class Event : IEnumerable, IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
