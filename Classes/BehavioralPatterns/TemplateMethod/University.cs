using System;

namespace DesignPatterns.Classes.BehavioralPatterns.TemplateMethod
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Поступление в ВУЗ.");
        }
        public override void Study()
        {
            Console.WriteLine("Обучение в вузе, производственная практика.");
        }
        public override void PassExam()
        {
            Console.WriteLine("Защита дипломной работы.");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получение диплома.");
        }
    }
}
