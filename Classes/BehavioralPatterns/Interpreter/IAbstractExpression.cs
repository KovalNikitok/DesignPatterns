namespace DesignPatterns.Classes.BehavioralPatterns.Interpreter
{
    interface IAbstractExpression
    {
        int Interpret(Context context);
    }
}
