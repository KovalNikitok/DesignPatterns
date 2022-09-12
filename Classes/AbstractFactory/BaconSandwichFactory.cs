namespace DesignPatterns.Classes.AbstractFactory
{
    class BaconSandwichFactory : SandwichFactory
    {
        public override Bread CreateBread()
        {
            return new BreadSlice();
        }

        public override Filling CreateFilling()
        {
            return new Bacon();
        }
    }
}
