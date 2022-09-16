namespace DesignPatterns.Classes.BehavioralPatterns.TemplateMethod
{
    abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExam();
            GetDocument();
        }

        public abstract void Enter();
        public abstract void Study();
        public abstract void PassExam();
        public virtual void GetDocument()
        {
            System.Console.WriteLine("Получение документа об окончании обучения.");
        }
    }
}
