using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentabike
{
    internal class BikeRental
    {

        public List<Bike> OverviewRentals { get; set; }

        public void RegisterRent(Bike bike)
        {
            if (OverviewRentals.Contains(bike))
            {

            } else
            {
                OverviewRentals.Add(bike);
            }
        }

        public void DeregisterRent(Bike bike)
        {
            if (OverviewRentals.Contains(bike))
            {
                OverviewRentals.Remove(bike);
            }
        }

    }
}
