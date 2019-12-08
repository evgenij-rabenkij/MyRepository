using System.Collections.Generic;

namespace DEV_6
{
    class AllCounter//Reciever of command "count all"
    {
        public void CountAll(List<CarInformation> carsInformation)//method for counting total amount of cars in DB
        {
            int totalAmount = 0;
            
            foreach (CarInformation carInfo in carsInformation)
            {
                totalAmount += carInfo.Amount;
            }

            Program.ResultOutput(totalAmount);
        }
    }
}
