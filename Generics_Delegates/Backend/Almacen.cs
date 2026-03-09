using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class Almacen<T> 
    {
        List<T> _inventory = new List<T> ();

        public void Add(T item)
        {
            _inventory.Add(item);
        }

        public T GetItem(int index)
        {
            return _inventory[index];
        }

        public void ShowInventory()
        {
            foreach (T item in _inventory) 
            { 
                Console.WriteLine(item?.ToString());  
            }
        }
        public void deleteItem(int index)
        {
            if (index >= 0 && index < _inventory.Count)
            {
                _inventory.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
