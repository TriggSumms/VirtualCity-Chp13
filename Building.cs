using System;

namespace Planner
{
    public class Building
    {
        //Invoking Process's:
        public void BuildingRollCall()
        {
            Console.WriteLine($"The address of this Building is: {_address}");
            Console.WriteLine("---------*-------------------------------------------*-----------");
            Console.WriteLine($"Designed by: {_designer}");
            Console.WriteLine($"Constructed on ...{_dateConstructed}");
            Console.WriteLine($"The Investor(s) are... {_owner}");
            Console.WriteLine($"{Volume} ...a whopping cubic meters of space");
        }






        // Private Properties
        private string _designer { get; set; }

        private DateTime _dateConstructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        // Public Properties
        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string address) => address = _address;
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string investor)
        {
            investor = _owner;
        }

    }

}