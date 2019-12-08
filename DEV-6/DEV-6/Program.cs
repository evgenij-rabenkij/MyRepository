using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

namespace DEV_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            CarInfoDB carInfoDB = NewCarInfoDBCreate();

            int signal = 0;

            while (true)
            {
                Console.Write("Enter command: ");
                string command = Console.ReadLine();
                Invoker invoker = new Invoker();

                switch (command)
                {
                    case "count types":
                        TypesCounter typesCounter = new TypesCounter();
                        CountTypesCommand countTypes = new CountTypesCommand(typesCounter, carInfoDB.CarsInformation);
                        invoker.SetCommand(countTypes);
                        invoker.Run();
                        break;

                    case "count all":
                        AllCounter allCounter = new AllCounter();
                        CountAllCommand countAll = new CountAllCommand(allCounter, carInfoDB.CarsInformation);
                        invoker.SetCommand(countAll);
                        invoker.Run();
                        break;

                    case "average price":
                        AveragePriceCalculator averegePriceCalculator = new AveragePriceCalculator();
                        AveragePriceCommand averagePrice = new AveragePriceCommand(averegePriceCalculator, carInfoDB.CarsInformation);
                        invoker.SetCommand(averagePrice);
                        invoker.Run();
                        break;

                    case "exit":
                        ProgramExit programExit = new ProgramExit();
                        ExitCommand exit = new ExitCommand(programExit);
                        invoker.SetCommand(exit);
                        invoker.Run();
                        break;

                    default:
                        foreach (CarInformation carInfo in carInfoDB.CarsInformation)
                        {
                            if (command.Contains("average price " + carInfo.Type))
                            {
                                AveragePriceOfTypeCalculator averagePriceOfTypeCalculator = new AveragePriceOfTypeCalculator();
                                AveragePriceTypeCommand averagePriceType = new AveragePriceTypeCommand(averagePriceOfTypeCalculator, carInfoDB.CarsInformation, carInfo.Type);
                                invoker.SetCommand(averagePriceType);
                                invoker.Run();
                                signal++;
                                break;
                            }
                        }
                        if (signal == 0)
                        {
                            Console.WriteLine("Incorrect command. Try again.");
                        }
                        signal = 0;
                        break;
                }
            }
        }

        static CarInfoDB NewCarInfoDBCreate()
        {
            CarInfoDB carInfoDB = new CarInfoDB();

            Console.Write("Enter number of positions: ");
            int numberOfPositions = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < numberOfPositions)
            {
                try
                {
                    CarInformation newCarInfo = NewCarInformationInput();
                    CarAvailabilityCheck(newCarInfo, carInfoDB.CarsInformation);
                    carInfoDB.CarsInformation.Add(newCarInfo);
                    i++;
                    Console.WriteLine("Added to DB.");
                }
                catch (CarIsAlreadyAvailableException ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
            }

            return carInfoDB;
        }
        
        static CarInformation NewCarInformationInput()
        {
            Console.WriteLine("Type:");
            string type = Console.ReadLine();
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            Console.WriteLine("Amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price:");
            int price = Convert.ToInt32(Console.ReadLine());

            return new CarInformation(type, model, amount, price);
        }

        static void CarAvailabilityCheck(CarInformation carInformation, List<CarInformation> carsInformation)
        {
            foreach (CarInformation carInfo in carsInformation)
            {
                if (carInformation.Equals(carInfo))
                    throw new CarIsAlreadyAvailableException("Car of this type and model is already available.");
            }
        }

        public static void ResultOutput(object result)//metod for outputting results
        {
            Console.WriteLine(result);
        }
        
    }
}
