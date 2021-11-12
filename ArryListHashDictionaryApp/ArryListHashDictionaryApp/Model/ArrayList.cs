using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryListHashDictionaryApp.Model
{
    class ArrayList
    {
        ArrayList arrayList = new ArrayList();

        public void Add(int aList)
        {
            arrayList.Add(aList);
        }
        public void Delete(int index)
        {
            arrayList.RemoveAt(index - 1);
        }

        private void RemoveAt(int v)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            foreach(int i in arrayList)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(" ");
        }

        public void Update(int value,int index)
        {
            arrayList.RemoveAt(index - 1);
            arrayList.Insert(index - 1, value);
        }

        private void Insert(int v, int value)
        {
            throw new NotImplementedException();
        }
    }
}
