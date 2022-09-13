namespace DesignPatterns.Classes.AbstractFactory
{
    class Sandwich
    {
        private Bread _bread;
        private Filling _filling;

        public Sandwich(SandwichFactory factory)
        {
            _bread = factory.CreateBread();
            _filling = factory.CreateFilling();
        }

        public void SandwichWith()
        {
            _bread.BreadType();
            _filling.FllingType();
        }
    }
}
