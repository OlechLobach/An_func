using System;
using System.Collections.Generic;

namespace Backpack
{
    public class Backpack
    {
        private string _color;
        private string _brand;
        private string _material;
        private double _weight;
        private double _volume;
        private List<Item> _items = new List<Item>();
        private double _currentVolume;

        public event EventHandler<Item> ItemAdded;

        public Backpack(string color, string brand, string material, double weight, double volume)
        {
            _color = color;
            _brand = brand;
            _material = material;
            _weight = weight;
            _volume = volume;
            _currentVolume = 0;
        }

        public void AddItem(Item item)
        {
            if (_currentVolume + item.Volume <= _volume)
            {
                _items.Add(item);
                _currentVolume += item.Volume;
                ItemAdded?.Invoke(this, item);
            }
            else
            {
                throw new InvalidOperationException("Exceeded backpack volume");
            }
        }

        public void FillBackpack(string color, string brand, string material, double weight, double volume)
        {
            _color = color;
            _brand = brand;
            _material = material;
            _weight = weight;
            _volume = volume;
            _currentVolume = 0;
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Backpack backpack = new Backpack("Black", "Nike", "Nylon", 1.5, 20);

            backpack.ItemAdded += (sender, item) =>
            {
                Console.WriteLine($"Item added to backpack: {item.Name}");
            };

            try
            {
                backpack.AddItem(new Item("Book", 2.0));
                backpack.AddItem(new Item("Laptop", 3.0));
                backpack.AddItem(new Item("Water bottle", 0.5));
                backpack.AddItem(new Item("Jacket", 1.5));
                backpack.AddItem(new Item("Snacks", 0.5));
                backpack.AddItem(new Item("Notebook", 1.0));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}