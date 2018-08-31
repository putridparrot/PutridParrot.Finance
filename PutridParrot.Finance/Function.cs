using System;

namespace PutridParrot.Finance
{
    public static class Function
    {
        /// <summary>
        /// APY = ((1 + r/n)^n) - 1
        /// 
        /// http://financeformulas.net/Annual_Percentage_Yield.html
        /// </summary>
        /// <param name="annualInterestRate"></param>
        /// <param name="numberOfTimesComounded"></param>
        /// <returns></returns>
        public static double AnnualPercentageYield(double annualInterestRate, int numberOfTimesComounded)
        {
            return Math.Pow(1 + annualInterestRate / numberOfTimesComounded, numberOfTimesComounded) - 1;
        }

        public static double CompoundInterest(double principalAmount, double ratePerPeriod, int numberOfPeriods)
        {
            return principalAmount * (Math.Pow(1 + ratePerPeriod, numberOfPeriods) - 1);
        }

        /// <summary>
        /// PV or Present Value
        /// </summary>
        /// <param name="cashflowAtPeriod1"></param>
        /// <param name="rateOfReturn"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        public static double Pv(double cashflowAtPeriod1, double rateOfReturn, int numberOfPeriods)
        {
            return cashflowAtPeriod1 / Math.Pow(1 + rateOfReturn, numberOfPeriods);
        }

        /// <summary>
        /// FV or Future Value
        /// </summary>
        /// <param name="cashflowAtPeriod0"></param>
        /// <param name="rateOfReturn"></param>
        /// <param name="numberOfPeriogs"></param>
        /// <returns></returns>
        public static double Fv(double cashflowAtPeriod0, double rateOfReturn, int numberOfPeriogs)
        {
            return cashflowAtPeriod0 * Math.Pow(1 + rateOfReturn, numberOfPeriogs);
        }

        public static Percentage BondEquivalentYield(double faceValue, double price, int daysToMaturity)
        {
            return Percentage.FromDecimal(((faceValue - price) / price) * 365.0 / daysToMaturity);
        }
    }
}
