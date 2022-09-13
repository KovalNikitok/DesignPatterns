namespace DesignPatterns.Classes.Builder.Bread
{
    class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }

        public override string ToString() => $"Bread with {Flour?.Sort}, {Salt?.Gramms} gramms of salt and {Additives?.Name ?? "without"} additives";
    }
}
