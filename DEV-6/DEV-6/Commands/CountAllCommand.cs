using System.Collections.Generic;

namespace DEV_6
{
    class CountAllCommand : ICommand
    {
        AllCounter allCounter;
        List<CarInformation> carsInformation;
        public CountAllCommand(AllCounter allCounter, List<CarInformation> carsInformation)
        {
            this.allCounter = allCounter;
            this.carsInformation = carsInformation;
        }
        public void Execute()
        {
            allCounter.CountAll(carsInformation);
        }

        public void Undo()
        {
        }
    }
}
