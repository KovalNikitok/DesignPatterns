namespace DesignPatterns.Classes.BehavioralPatterns.Observer
{
    class Broker : IObserver
    {
        private Dollar_Ruble_Pair valletPair { get; set; }
        public Broker()
        {
            valletPair = new Dollar_Ruble_Pair();
        }
        public void Update(object data)
        {
            if (data is Dollar_Ruble_Pair pair)
            {
                valletPair.Dollar = pair?.Dollar ?? 0;
                valletPair.Rubble = pair?.Rubble ?? 0;

                if (valletPair?.Dollar > 0)
                    System.Console.WriteLine($"Покупка доллара у брокера стоит {valletPair.Dollar + 3}");
                if (valletPair?.Rubble > 0)
                    System.Console.WriteLine($"Продажа доллара у брокера стоит {valletPair.Rubble + 1}");
            }
        }
    }
}
