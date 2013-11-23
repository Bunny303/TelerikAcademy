using System;
using System.Linq;
using System.Text;

namespace GenericList
{
    public class GenericList<T>
    {
        //Define fields
        private T[] list;
        public int Position { get; private set; }

        //Define constructor
        public GenericList(int maxSize)
        {
            if (maxSize > 0)
            {
                this.list = new T[maxSize];
            }
            else
            {
                throw new IndexOutOfRangeException ("Size of the array have to be positive!"); 
            }
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }

            set
            {
                list[index] = value;
            }
        }

        // Adding element
        public void AddElement(T element)
        {
            if (Position >= list.Length)
            {
                // 6.Auto-grow functionality - Double length array and adding element
                T[] newList = new T[this.list.Length * 2];
                Array.Copy(list, newList, this.list.Length);
                Position++;
                newList[this.list.Length] = element;
                this.list = newList;
            }
            else
            {
                list[Position] = element;
                Position++;
            }
        }

        // Accessing element by index
        public T ReadElement(uint index)
        {
            T value;
            if (index < this.list.Length)
            {
                value = list[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
            return value;
        }

        // Removing element by index
        public void RemoveElement(int index)
        {
            if (index < this.list.Length)
            {
                T[] newList = new T[list.Length - 1];
                Array.Copy(this.list, newList, index);
                Array.Copy(this.list, index + 1, newList, index, newList.Length - index);
                this.list = newList;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
        }

        // Inserting element at given position
        public void InsertElement(int index, T element)
        {
            if (index < this.list.Length)
            {
                T[] newList = new T[list.Length + 1];
                Array.Copy(this.list, newList, index);
                newList[index] = element;
                Array.Copy(this.list, index, newList, index + 1, this.list.Length - index);
                this.list = newList;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
        }
        // Clearing the list
        public void ClearList()
        {
            list = new T[list.Length];
        }

        // Finding element by its value, return -1 if the element isn't found
        public int FindElemenetByValue(T value)
        {
            int indexFound = -1;

            for (int i = 0; i < list.Length; i++)
            {

                if (value.Equals(this.list[i]))
                {
                    indexFound = i;
                    break;
                }
            }

            return indexFound;
        }
                
        // To string
        public override string ToString()
        {
            StringBuilder printList = new StringBuilder();
            foreach (var item in list)
            {
                printList.AppendFormat("{0} ", item);
            }
            return printList.ToString();
        }
    }
}
