using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        // 👉 Agregar un platillo
        public void AddDish(Dish dish)
        {
            if (dish == null)
            {
                Console.WriteLine("No se puede agregar un platillo nulo");
                return;
            }

            dishes.Add(dish);
            Console.WriteLine($"'{dish.Name}' ha sido agregado al menú.");
        }

        // 👉 Eliminar un platillo
        public void RemoveDish(Dish dish)
        {
            if (dishes.Contains(dish))
            {
                dishes.Remove(dish);
                Console.WriteLine($"El platillo '{dish.Name}' fue removido");
            }
            else
            {
                Console.WriteLine("El platillo no fue encontrado");
            }
        }

        // 👉 Buscar un platillo por nombre
        public Dish GetDishByName(string name)
        {
            foreach (var dish in dishes)
            {
                if (dish.Name == name)
                {
                    return dish; // se encontró
                }
            }
            return null; // si no lo encuentra
        }
    }
}