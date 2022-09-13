namespace DesignPatterns.Classes.BehavioralPatterns.Strategy
{
    class Dancer
    {
        public string Name { get; private set; }
        public IDance Dance { private get; set; }
        public Dancer(string dancerName, IDance dance)
        {
            Name = dancerName;
            Dance = dance;
        }



        public void Dancing() => Dance.Dance();
    }
}
