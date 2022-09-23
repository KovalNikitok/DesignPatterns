namespace DesignPatterns.Classes.BehavioralPatterns.State
{
    class FullySaturated : ISatiate
    {
        public void Satiate(Nurition nurition)
        {
            System.Console.WriteLine("Уже насыщен.");
            // Some method for fully saturated person
        }
    }
}
