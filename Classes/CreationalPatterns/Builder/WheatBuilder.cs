
namespace DesignPatterns.Classes.Builder
{
    class WheatBuilder : BreadBuilder
    {
        public override void SetAdditives() { }

        public override void SetFlour()
        {
            Bread.Flour = new Bread.Flour() { Sort = "1'st flour sort" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Bread.Salt() { Gramms = 5.0f };
        }
    }
}
