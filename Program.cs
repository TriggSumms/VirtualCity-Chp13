using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Name of the city.
            The mayor of the city.
            Year the city was established.
            A collection of all of the buildings in the city.
            A method to add a building to the city. */
            City megalopolis = new City();
            megalopolis.Name = "Megaopolis";
            megalopolis.Mayor = "Lil wayne";
            megalopolis.YearEstablished = "1837";

            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Stories = 130;
            FiveOneTwoEigth.Width = 42;
            FiveOneTwoEigth.Depth = 65;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("lil babi");

            Building NationsBar = new Building("51st Avenue ");
            NationsBar.Stories = 1;
            NationsBar.Width = 50;
            NationsBar.Depth = 52;
            NationsBar.Construct();
            NationsBar.Purchase("Montucky Kurt");

            Building ShortStackPancakes = new Building("612 fifth Avenue");
            ShortStackPancakes.Stories = 5000;
            ShortStackPancakes.Width = 4999;
            ShortStackPancakes.Depth = 4999;
            ShortStackPancakes.Construct();
            ShortStackPancakes.Purchase("Syrup Dranker Man");

            Building CandyShop = new Building("Pepppermint Pati Lane");
            CandyShop.Stories = 15;
            CandyShop.Width = 100000;
            CandyShop.Depth = 1000000;
            CandyShop.Construct();
            CandyShop.Purchase("Shoe Shine McCalister");

            // Console.WriteLine("Full Building List");
            // Planner.BuildingRollCall();

            foreach (Building Building in megalopolis.Buildings)
            {
                //Console.WriteLine("RollCall: ");
                building.BuildingRollCall();
                //City.BuildingRollCall();
            }
        }
    }
}