using System.Collections.Generic;

namespace DEV_6
{
    class AveragePriceCommand : ICommand
    {
        AveragePriceCalculator averegePriceCalculator;
        List<CarInformation> carsInformation;
        public AveragePriceCommand(AveragePriceCalculator averegePriceCalculator, List<CarInformation> carsInformation)
        {
            this.averegePriceCalculator = averegePriceCalculator;
            this.carsInformation = carsInformation;
        }
        public void Execute()
        {
            averegePriceCalculator.AveragePriceCalculate(carsInformation);
        }

        public void Undo()
        {
        }
    }
}
