using System.Collections.Generic;

namespace DesignPatterns.Classes.BehavioralPatterns.Interpreter
{
    class Context
    {
        private Dictionary<string, int> _variables { get; set; }
        public Context()
        {
            _variables = new Dictionary<string, int>();
        }

        public int GetVariable(string key) => _variables[key];

        public void SetVariable(string key, int value)
        {
            if (_variables.ContainsKey(key))
            {
                _variables[key] = value;
                return;
            }
            _variables.Add(key, value);
        }
    }
}
