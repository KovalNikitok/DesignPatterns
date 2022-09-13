namespace DesignPatterns.Classes.Builder
{
    // Director
    class Baker
    {
        public Bread.Bread Bake(BreadBuilder recipe)
        {
            recipe.CreateBread();
            recipe.SetFlour();
            recipe.SetSalt();
            recipe.SetAdditives();

            return recipe.Bread;
        }
    }
}
