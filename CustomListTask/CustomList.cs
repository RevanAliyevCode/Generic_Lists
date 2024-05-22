using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTask
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;

        private T[] array;
        private readonly int initalCapacity = 4;

        public int Count { get => count; }
        public int Capacity { get => capacity; }

        public CustomList()
        {
            array = [];
        }

        public void Add(T item)
        {
            if (capacity == count)
            {
                Array.Resize(ref array, capacity == 0 ? initalCapacity : array.Length * 2);
                capacity = array.Length;
            }
            array[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(array, item);

            if (index != -1)
            {
                for (int i = index; i < count; i++)
                    array[i] = array[i + 1];
                count--;
            }
        }

        public void GetAll()
        {
            for (int i = 0; i < count; i++) Console.WriteLine(array[i]);
        }

        public bool Contains(T item)
        {
            int index = Array.IndexOf(array, item);
            return index != -1;
        }

        public bool Any() => count != 0;

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                array[i] = default;
            }
            count = 0;
        }

        public T? FirstOrDefault() => count != 0 ? array[0] : default;

        public T? ElementAtOrDefault(int index) => count > index ? array[index] : default;

        public T? LastOrDefault() => count != 0 ? array[count - 1] : default;
    }
}
