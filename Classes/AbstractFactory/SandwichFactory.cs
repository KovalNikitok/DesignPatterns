namespace DesignPatterns.Classes.AbstractFactory
{
    abstract class SandwichFactory
    {
        public abstract Bread CreateBread();
        public abstract Filling CreateFilling();
    }
}
