namespace DesignPatterns.Classes.BehavioralPatterns.Interpreter
{
    class MultiplicationExpression : IAbstractExpression
    {
        private IAbstractExpression _firstVariable;
        private IAbstractExpression _secondVariable;
        public MultiplicationExpression(IAbstractExpression firstVariable, IAbstractExpression secondVariable)
        {
            _firstVariable = firstVariable;
            _secondVariable = secondVariable;
        }
        public int Interpret(Context context) =>
            _firstVariable.Interpret(context) * _secondVariable.Interpret(context);
    }
}
