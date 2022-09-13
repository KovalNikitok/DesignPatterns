using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class PotatoFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Potato();
        }

        public IProduct CreateProduct(string name, float weight, decimal cost)
        {
            return new Potato(name, weight, cost);
        }
    }
}
