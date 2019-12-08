using System.Collections.Generic;

namespace DEV_6
{
    class TypesCounter//Reciever of command "count types"
    {
        public void TypesCount(List<CarInformation> carsInformation)//method for coounting amount of unique types in DB
        {
            int typesAmount = 0;
            int helper = 0;
           
            for (int i = 0; i < carsInformation.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (carsInformation[i].Type != carsInformation[j].Type)
                    {
                        helper++;
                    }
                }
                if (helper == i)
                {
                    typesAmount++;
                }
                helper = 0;
            }

            Program.ResultOutput(typesAmount);
        }
    }
}
