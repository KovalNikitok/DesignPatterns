namespace DesignPatterns.Classes.BehavioralPatterns.State
{
    class Nurition
    {
        public ISatiate Feeding { get; set; }
        public Nurition()
        {
            Feeding = new Starving();
        }
        
        public void Feed() => Feeding.Satiate(this);
    }
}
