namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; }
        public double Price { get; }
        public bool IsVegetarian { get; }
    }
}