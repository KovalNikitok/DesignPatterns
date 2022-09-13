using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class Cucumber : IProduct
    {
        public float Weight { get; private set; }
        public string Name { get; private set; }
        public decimal Cost { get; private set; }

        public Cucumber() { }

        public Cucumber(string name, float weight, decimal cost)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException($"\"{nameof(name)}\" не может быть пустым или содержать только пробел.", nameof(name));
            }
            Name = name;
            Weight = weight;
            Cost = cost;
        }

        public float CalculateCallories()
        {
            return Weight * 20;
        }
    }
}
