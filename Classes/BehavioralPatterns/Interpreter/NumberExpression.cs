namespace DesignPatterns.Classes.BehavioralPatterns.Interpreter
{
    class NumberExpression : IAbstractExpression
    {
        private string _numberKey;
        public NumberExpression(string variableKey)
        {
            _numberKey = variableKey;
        }
        public int Interpret(Context context) => context.GetVariable(_numberKey);
    }
}
