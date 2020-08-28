using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        // Public Properties
        public string Name { get; set; }

        public string Mayor { get; set; }

        public string YearEstablished { get; set; }

     private List<Building> Buildings { get; set; }

        // A "constructor" is a special method that is run when a class is instantiated
        //  Meaning when some other code says "new BikeStore()" the BikeStore constructor is executed
        public void AddBuilding(Building aBuilding)
        {
            Buildings.Add(aBuilding);
        }

        public City()
        {
            
            //  to the Inventory and SalesHistory properties
            
            Buildings = new List<Building>();
        }
    }
}