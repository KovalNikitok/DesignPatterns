namespace DesignPatterns.Classes.Singleton
{
    class Computer
    {
        private static Computer _instance;
        public string Name { get; private set; }
        private static object sync = new object();
        public static Computer Current(string name)
        {
            if (_instance == null)
            {
                // Thread safe
                lock (sync)
                {
                    if (_instance == null)
                        _instance = new Computer(name);
                }
            }
            return _instance;
        }

        private Computer(string name)
        {
            Name = name;
        }
    }
}
