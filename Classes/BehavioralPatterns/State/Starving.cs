namespace DesignPatterns.Classes.BehavioralPatterns.State
{
    class Starving : ISatiate
    {
        public void Satiate(Nurition nurition)
        {
            System.Console.WriteLine("Голодающий накормлен до половинного насыщения.");
            nurition.Feeding = new HalfSaturated();
        }
    }
}
