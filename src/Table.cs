using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}