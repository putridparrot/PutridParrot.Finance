using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PutridParrot.Finance;

namespace Tests.PutridParrot.Finance
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class FunctionTests
    {
        [Test]
        public void AnnualPercentageYield_WithValidInputs()
        {
            // 6% compound monthly, over 12 months
            Assert.AreEqual(6.168, Function.AnnualPercentageYield(0.06, 12) * 100, 0.001);
        }

        [Test]
        public void CompoundInterest_WithValidInputs()
        {
            // principal of 1000, rate per period of 1% per month over 12 monthly periods
            Assert.AreEqual(126.83, Function.CompoundInterest(1000, 0.01, 12), 0.01);
        }

        [Test]
        public void PV_WithValidInputs()
        {
            // principal of 1000, rate per period of 1% per month over 12 monthly periods
            Assert.AreEqual(95.24, Function.Pv(100, 0.05, 1), 0.01);
        }

        [Test]
        public void FV_WithValidInputs()
        {
            // original balance of 1000, rate per period of 0.5% per month over 12 monthly periods
            Assert.AreEqual(1061.68, Function.Fv(1000, 0.005, 12), 0.01);
        }

        [Test]
        public void BondEquivalentYield_WithValidInputs()
        {
            Assert.AreEqual(0.0827, Function.BondEquivalentYield(1000, 980, 90).ToDecimal(), 0.01);
        }
    }
}
