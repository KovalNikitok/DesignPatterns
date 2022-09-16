namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    class AirConditioner
    {
        public AirConditioner()
        {
            TemperatureCDeegrees = 18;
            InclinationAngle = 60;
        }

        // Some method for start air conditioner
        public void StartConditioning() 
        {
            System.Console.WriteLine($"Air conditioner works with {TemperatureCDeegrees} temp and at {InclinationAngle} inclination angle.");
        }

        public void StopConditioning() 
        {
            System.Console.WriteLine("Air conditioner stop works.");
        }

        private float TemperatureCDeegrees { get; set; }
        private int InclinationAngle { get; set; }
        public void ChangeTemperature(float deltaTemperature)
        {
            if (TemperatureCDeegrees < 40 && TemperatureCDeegrees > -10)
                TemperatureCDeegrees += deltaTemperature;
        }

        public void ChangeInclinationAngle(int deltaAngle)
        {
            if (!CheckInclinationAgle(InclinationAngle))
                return;

            int newInclinationAngle = InclinationAngle + deltaAngle;
            if (CheckInclinationAgle(newInclinationAngle))
            {
                InclinationAngle = newInclinationAngle;
                ChangeInclinationAngle();
            }

        }

        // Method for change inclination angle
        private void ChangeInclinationAngle()
        {
            // Shift the tilt angle to value of InclinationAngle

        }
        private bool CheckInclinationAgle(int inclinationAngle) => inclinationAngle > 15 && inclinationAngle < 165;
    }
}
