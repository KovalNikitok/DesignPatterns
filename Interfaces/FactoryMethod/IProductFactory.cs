namespace DesignPatterns.Interfaces
{
    public interface IProductFactory
    {
        public IProduct CreateProduct();

        public IProduct CreateProduct(string name, float weight, decimal cost);
    }
}
