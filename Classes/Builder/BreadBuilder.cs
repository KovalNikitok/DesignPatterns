
namespace DesignPatterns.Classes.Builder
{
    abstract class BreadBuilder
    {
        public Bread.Bread Bread { get; private set; }
        public void CreateBread()
        {
            Bread = new Bread.Bread();
        }
        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }
}
