using System.Collections.Generic;

namespace DEV_6
{
    class CountTypesCommand : ICommand
    {
        TypesCounter typesCounter;
        List<CarInformation> carsInformation;
        public CountTypesCommand(TypesCounter typesCounter, List<CarInformation> carsInformation)
        {
            this.typesCounter = typesCounter;
            this.carsInformation = carsInformation;
        }
        public void Execute()
        {
            typesCounter.TypesCount(carsInformation);
        }

        public void Undo()
        {
        }
    }
}
