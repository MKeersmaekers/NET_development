using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentabike
{
    public class Material
    {
        private string serialNumber;
        private string description;

        public string SerialNumber
        {
            get { return serialNumber; } set { serialNumber = value; }
        }

        public string Description
        {
            get { return description; } set { description = value; }
        }

        public Material(string serialNumber, string description)
        {
            SerialNumber = serialNumber;
            Description = description;
        }

        public virtual int ReturnRentalPrice()
        {
            return 100;
        }
    }

    public class Bike : Material
    {
        public Bike(string serialNumber, string description) : base(serialNumber, description)
        {
        }

        public int Code
        {
            get { return Code; }
            set
            {
                if (value >= 100 & Code <= 999)
                {
                    Code = value;
                }
            }
        }

        public override int ReturnRentalPrice()
        {
            return 100 + (100/100*20);
        }

        public override string ToString()
        {
            return SerialNumber + " " + Description + " " + Code + " " + ReturnRentalPrice();
        }
    }
}
