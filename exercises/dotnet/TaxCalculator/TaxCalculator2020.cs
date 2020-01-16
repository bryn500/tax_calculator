using System;

namespace TaxCalculator
{
    public class TaxCalculator2020 : TaxCalculator
    {
        public TaxCalculator2020(bool useFirstYearFeature = false, bool useExpensiveCarFeature= false) : base (useFirstYearFeature, useExpensiveCarFeature)
        {
        }

        public TaxCalculator2020(int year, bool useFirstYearFeature = false, bool useExpensiveCarFeature = false) : base(year, useFirstYearFeature, useExpensiveCarFeature)
        {
        }

        public override int CalculateTax(Vehicle vehicle)
        {
            int cost;

            switch (vehicle.FuelType)
            {
                case FuelType.Petrol:
                    cost = CalculateTaxForPetrol(vehicle);
                    break;
                case FuelType.Diesel:
                    cost = CalculateTaxForDiesel(vehicle);
                    break;
                case FuelType.AlternativeFuel:
                    cost = CalculateTaxForAlt(vehicle);
                    break;
                case FuelType.Electric:
                    cost = CalculateTaxForElectric(vehicle);
                    break;
                default:
                    throw new NotImplementedException($"Unhandled vehicle fuel type {vehicle.FuelType}");
            }

            return cost;
        }

        private int CalculateTaxForPetrol(Vehicle vehicle)
        {
            if (vehicle.DateOfFirstRegistration.Year <= Year - 2)
                return 140;

            if (vehicle.Co2Emissions == 0)
            {
                return 0;
            }
            else if (vehicle.Co2Emissions <= 50)
            {
                return 10;
            }
            else if (vehicle.Co2Emissions <= 75)
            {
                return 25;
            }
            else if (vehicle.Co2Emissions <= 90)
            {
                return 105;
            }
            else if (vehicle.Co2Emissions <= 100)
            {
                return 125;
            }
            else if (vehicle.Co2Emissions <= 110)
            {
                return 145;
            }
            else if (vehicle.Co2Emissions <= 130)
            {
                return 165;
            }
            else if (vehicle.Co2Emissions <= 150)
            {
                return 205;
            }
            else if (vehicle.Co2Emissions <= 170)
            {
                return 515;
            }
            else if (vehicle.Co2Emissions <= 190)
            {
                return 830;
            }
            else if (vehicle.Co2Emissions <= 225)
            {
                return 1240;
            }
            else if (vehicle.Co2Emissions <= 255)
            {
                return 1760;
            }
            else
            {
                return 2070;
            }
        }

        private int CalculateTaxForDiesel(Vehicle vehicle)
        {
            if (vehicle.DateOfFirstRegistration.Year <= Year - 2)
                return 140;

            if (vehicle.Co2Emissions == 0)
            {
                return 0;
            }
            else if (vehicle.Co2Emissions <= 50)
            {
                return 25;
            }
            else if (vehicle.Co2Emissions <= 75)
            {
                return 105;
            }
            else if (vehicle.Co2Emissions <= 90)
            {
                return 125;
            }
            else if (vehicle.Co2Emissions <= 100)
            {
                return 145;
            }
            else if (vehicle.Co2Emissions <= 110)
            {
                return 165;
            }
            else if (vehicle.Co2Emissions <= 130)
            {
                return 205;
            }
            else if (vehicle.Co2Emissions <= 150)
            {
                return 515;
            }
            else if (vehicle.Co2Emissions <= 170)
            {
                return 830;
            }
            else if (vehicle.Co2Emissions <= 190)
            {
                return 1240;
            }
            else if (vehicle.Co2Emissions <= 225)
            {
                return 1760;
            }
            else if (vehicle.Co2Emissions <= 255)
            {
                return 2070;
            }
            else
            {
                return 2070;
            }
        }

        private int CalculateTaxForAlt(Vehicle vehicle)
        {
            if (vehicle.DateOfFirstRegistration.Year <= Year - 2)
                return 130;

            if (vehicle.Co2Emissions == 0)
            {
                return 0;
            }
            else if (vehicle.Co2Emissions <= 50)
            {
                return 0;
            }
            else if (vehicle.Co2Emissions <= 75)
            {
                return 15;
            }
            else if (vehicle.Co2Emissions <= 90)
            {
                return 95;
            }
            else if (vehicle.Co2Emissions <= 100)
            {
                return 115;
            }
            else if (vehicle.Co2Emissions <= 110)
            {
                return 135;
            }
            else if (vehicle.Co2Emissions <= 130)
            {
                return 155;
            }
            else if (vehicle.Co2Emissions <= 150)
            {
                return 195;
            }
            else if (vehicle.Co2Emissions <= 170)
            {
                return 505;
            }
            else if (vehicle.Co2Emissions <= 190)
            {
                return 820;
            }
            else if (vehicle.Co2Emissions <= 225)
            {
                return 1230;
            }
            else if (vehicle.Co2Emissions <= 255)
            {
                return 1750;
            }
            else
            {
                return 2060;
            }
        }

        private int CalculateTaxForElectric(Vehicle vehicle)
        {
            return 0;
        }
    }
}

