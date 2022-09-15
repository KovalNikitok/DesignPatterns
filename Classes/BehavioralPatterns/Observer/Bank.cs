namespace DesignPatterns.Classes.BehavioralPatterns.Observer
{
    class Bank : IObserver
    {
        private Dollar_Ruble_Pair valletPair { get; set; }
        public Bank()
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
                    System.Console.WriteLine($"Покупка доллара в банке стоит {valletPair.Dollar}");
                if (valletPair?.Rubble > 0)
                    System.Console.WriteLine($"Продажа доллара в банке стоит {valletPair.Rubble}");
            }
        }
    }
}
