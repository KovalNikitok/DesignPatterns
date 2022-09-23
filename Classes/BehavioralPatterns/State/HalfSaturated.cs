namespace DesignPatterns.Classes.BehavioralPatterns.State
{
    class HalfSaturated : ISatiate
    {
        public void Satiate(Nurition nurition)
        {
            System.Console.WriteLine("Наелся до полного насыщения.");
            nurition.Feeding = new FullySaturated();
        }
    }
}
