using System.Collections.Generic;

namespace DEV_6
{
    class AveragePriceTypeCommand : ICommand
    {
        AveragePriceOfTypeCalculator averagePriceOfTypeCalculator;
        List<CarInformation> carsInformation;
        string type;
        public AveragePriceTypeCommand(AveragePriceOfTypeCalculator averagePriceOfTypeCalculator, List<CarInformation> carsInformation, string type)
        {
            this.averagePriceOfTypeCalculator = averagePriceOfTypeCalculator;
            this.carsInformation = carsInformation;
            this.type = type; 
        }
        public void Execute()
        {
            averagePriceOfTypeCalculator.AveragePriceOfTypeCalculate(carsInformation, type);
        }

        public void Undo()
        {
        }
    }
}
