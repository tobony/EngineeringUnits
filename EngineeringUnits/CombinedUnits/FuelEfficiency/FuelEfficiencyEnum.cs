﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class FuelEfficiencyUnit : Enumeration
    {

        public static readonly FuelEfficiencyUnit SI = new(LengthUnit.SI, VolumeUnit.SI);
        public static readonly FuelEfficiencyUnit KilometerPerLiter = new(LengthUnit.Kilometer, VolumeUnit.Liter);
        //public static readonly FuelEfficiencyUnit LiterPer100Kilometers = new FuelEfficiencyUnit(LengthUnit.Kilometer, VolumeUnit.Liter);
        public static readonly FuelEfficiencyUnit MilePerUkGallon = new(LengthUnit.Mile, VolumeUnit.ImperialGallon, "mpg (imp.)");
        public static readonly FuelEfficiencyUnit MilePerUsGallon = new(LengthUnit.Mile, VolumeUnit.UsGallon, "mpg (U.S.)");


        public FuelEfficiencyUnit(LengthUnit Length, VolumeUnit volume, string NewSymbol = "Empty")
        {
            Unit = Length / volume;
            SetNewSymbol(NewSymbol, $"{Length}/{volume}");
        }

    

    }




}