namespace DesignPatterns.Interfaces
{
    public interface IProduct
    {
        float Weight { get;}
        string Name { get;}
        decimal Cost { get;}

        float CalculateCallories();
    }
}
