using System.Collections.Generic;

namespace DEV_6
{
    class AveragePriceOfTypeCalculator//Reciever of command "average price type"
    {
        public void AveragePriceOfTypeCalculate(List<CarInformation> carsInformation, string type)//method for calculating average price of concrete type
        {
            int totalTypePrice = 0;
            int totalAmountType = 0;
            foreach (CarInformation carInfo in carsInformation)
            {
                if (carInfo.Type == type)
                {
                    totalTypePrice += carInfo.Price * carInfo.Amount;
                    totalAmountType += carInfo.Amount;
                }
            }
           
            if (totalTypePrice == 0 || totalAmountType==0)
            {
                Program.ResultOutput("Unknown type or incorrect command. Try again.");
            }
            else
            {
                double averageTypePrice = (double)totalTypePrice / (double)totalAmountType;
                Program.ResultOutput(averageTypePrice);
            }
        }
    }
}
