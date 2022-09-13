namespace DesignPatterns.Classes.Builder
{
    class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            Bread.Additives = new Bread.Additives() { Name = "High thickener" };
        }

        public override void SetFlour()
        {
            Bread.Flour = new Bread.Flour() { Sort = "High rye sort"};
        }

        public override void SetSalt()
        {
            Bread.Salt = new Bread.Salt() { Gramms = 10.0f };
        }
    }
}
