namespace DesignPatterns.Classes.BehavioralPatterns.Command
{
    class AirConditionerLaunchCommand : ICommand
    {
        private AirConditioner _airConditioner;
        public AirConditionerLaunchCommand(AirConditioner conditioner)
        {
            _airConditioner = conditioner;
        }
        
        public void ExecuteCommand()
        {
            _airConditioner.StartConditioning();
        }

        public void UndoCommand()
        {
            _airConditioner.StopConditioning();
        }
    }
}
