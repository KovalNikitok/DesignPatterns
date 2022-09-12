using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class CucumberFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Cucumber();
        }

        public IProduct CreateProduct(string name, float weight, decimal cost)
        {
            return new Cucumber(name, weight, cost);
        }
    }
}
