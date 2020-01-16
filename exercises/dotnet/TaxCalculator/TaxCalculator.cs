using System;

namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        protected int Year { get; }

        protected bool UseFirstYearFeature { get; }
        protected bool UseExpensiveCarFeature { get; }

        public abstract int CalculateTax(Vehicle vehicle);

        protected TaxCalculator(bool useFirstYearFeature, bool useExpensiveCarFeature) : this(DateTime.Now.Year, useFirstYearFeature, useExpensiveCarFeature)
        {

        }

        protected TaxCalculator(int year, bool useFirstYearFeature, bool useExpensiveCarFeature)
        {
            Year = year;
            UseFirstYearFeature = useFirstYearFeature;
            UseExpensiveCarFeature = useExpensiveCarFeature;
        }
    }
}
