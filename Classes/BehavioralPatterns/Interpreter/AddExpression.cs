namespace DesignPatterns.Classes.BehavioralPatterns.Interpreter
{
    class AddExpression : IAbstractExpression
    {
        private IAbstractExpression _firstVariable;
        private IAbstractExpression _secondVariable;
        public AddExpression(IAbstractExpression firstVariable, IAbstractExpression secondVariable)
        {
            _firstVariable = firstVariable;
            _secondVariable = secondVariable;
        }
        public int Interpret(Context context) => 
            _firstVariable.Interpret(context) + _secondVariable.Interpret(context);
    }
}
