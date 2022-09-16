using System;

namespace DesignPatterns.Classes.BehavioralPatterns.TemplateMethod
{
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Поступление в школу.");
        }
        public override void Study()
        {
            Console.WriteLine("Обучение в школе.");
        }
        public override void PassExam()
        {
            Console.WriteLine("Сдача ЕГЭ.");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получение аттестата.");
        }
    }
}
