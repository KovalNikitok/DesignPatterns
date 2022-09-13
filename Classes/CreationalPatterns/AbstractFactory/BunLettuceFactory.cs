
namespace DesignPatterns.Classes.AbstractFactory
{
    class BunLettuceFactory : SandwichFactory
    {
        public override Bread CreateBread()
        {
            return new Bun();
        }

        public override Filling CreateFilling()
        {
            return new Lettuce();
        }
    }
}
