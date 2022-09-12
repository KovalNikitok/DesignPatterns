using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class BananaFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Banana();
        }

        public IProduct CreateProduct(string name, float weight, decimal cost)
        {
            return new Banana(name, weight, cost);
        }
    }
}
