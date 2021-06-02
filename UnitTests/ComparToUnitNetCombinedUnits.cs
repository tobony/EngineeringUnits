using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;

namespace UnitTests
{
    [TestClass]
    public class ComparToUnitNetCombinedUnits
    {


        [TestMethod]
        public void Energycompare()
        {
            UnitsNet.Energy L1 = new UnitsNet.Energy(56239676, UnitsNet.Units.EnergyUnit.Joule);
            EngineeringUnits.Energy L2 = new EngineeringUnits.Energy(56239676, EngineeringUnits.EnergyUnit.Joule);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.BritishThermalUnit) - L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit), 0.21);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.Calorie) - L1.As(UnitsNet.Units.EnergyUnit.Calorie), 1.9E-09);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.ElectronVolt) - L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt), 0);


            //The %-error is still very small
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.FootPound) - L1.As(UnitsNet.Units.EnergyUnit.FootPound), 550);


            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.Joule) - L1.As(UnitsNet.Units.EnergyUnit.Joule), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.KilowattHour) - L1.As(UnitsNet.Units.EnergyUnit.KilowattHour), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.EnergyUnit.WattHour) - L1.As(UnitsNet.Units.EnergyUnit.WattHour), 0);
        }


        [TestMethod]
        public void SpecificEnergycompare()
        {
            UnitsNet.SpecificEnergy L1 = new UnitsNet.SpecificEnergy(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
            EngineeringUnits.SpecificEnergy L2 = new EngineeringUnits.SpecificEnergy(10, EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram);



            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 1.9E-12);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 0);
        }

        [TestMethod]
        public void SpecificEnergycompare2()
        {
            UnitsNet.SpecificEnergy L1 = new UnitsNet.SpecificEnergy(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
            EngineeringUnits.SpecificEnergy L2 = new EngineeringUnits.SpecificEnergy(1, EngineeringUnits.SpecificEnergyUnit.BtuPerPound);



            //UnitNets and EngineeringUnits does not agree on the exact conversing between JoulePerKilogram -> BtuPerPound
            //That what gives the 'large' different

            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.1);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-5);
            Assert.AreEqual(0, L2.As(EngineeringUnits.SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.1E-05);
        }

    }
}
