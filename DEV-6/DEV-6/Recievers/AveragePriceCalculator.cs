using System.Collections.Generic;

namespace DEV_6
{
    class AveragePriceCalculator//Reciever of command "averege price"
    {
        public void AveragePriceCalculate(List<CarInformation> carsInformation)//method for calculating average price of all cars in DB
        {
            int totalPrice = 0;
            int totalAmount = 0;
           
            foreach (CarInformation carInfo in carsInformation)
            {
                totalPrice += carInfo.Price*carInfo.Amount;
                totalAmount += carInfo.Amount;
            }
            
            if (totalAmount != 0)
            {
                double averagePrice = (double)totalPrice / (double)totalAmount;
                Program.ResultOutput(averagePrice);
            }
            else
            {
                Program.ResultOutput("Impossible to calculate.");
            }
        }
    }
}
