using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {   public int Number { get; set; }
        public bool IsOccupied { get; set; }
        private List<Dish> order = new List<Dish>();

        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }

        public void Occupy()
        {
            if (IsOccupied)
            {
                Console.WriteLine($"La mesa {Number} se encuentra ocupada");
                return;
            }
                IsOccupied = true;
                Console.WriteLine($"La mesa {Number} se ha ocupado");
        }
        public void Free()
        {
            IsOccupied = false;
            order.Clear();
            Console.WriteLine($"La mesa {Number} ha sido liberada");
        }

        public void AddToOrder(Dish dish)
        {
            if (dish == null)
            {
                Console.WriteLine("No puede agregarse un platillo vacio");
                return;
            }
            
                order.Add(dish);
                Console.WriteLine($"Se ha agregado el platillo {dish.Name} a la orden");
            
        }
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}