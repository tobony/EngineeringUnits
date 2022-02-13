﻿using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{



    public class RotationalSpeedUnit : Enumeration
    {

        public static readonly RotationalSpeedUnit SI = new(DurationUnit.Second, "rad/s");
        public static readonly RotationalSpeedUnit RadianPerSecond = new(DurationUnit.Second, "rad/s");


        public static readonly RotationalSpeedUnit Hertz = new(DurationUnit.Second, "Hz", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit Kilohertz = new(PreFix.kilo, Hertz);
        public static readonly RotationalSpeedUnit Megahertz = new(PreFix.mega, Hertz);
        public static readonly RotationalSpeedUnit Gigahertz = new(PreFix.giga, Hertz);
        public static readonly RotationalSpeedUnit Terahertz = new(PreFix.tera, Hertz);

        public static readonly RotationalSpeedUnit PerSecond = new(DurationUnit.Second, "s⁻¹", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit BeatPerMinute = new(DurationUnit.Minute, "bpm", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit CyclePerHour = new(DurationUnit.Hour, "cph", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit CyclePerMinute = new(DurationUnit.Minute, "cpm", (2 * (decimal)Math.PI));




        public RotationalSpeedUnit(DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = duration.Pow(-1) * correction;
            SetNewSymbol(NewSymbol);
        }


        public RotationalSpeedUnit(PreFix SI, RotationalSpeedUnit unit)
        {
            Unit = unit.Unit.Copy() * PrefixSISize(SI);
            SetNewSymbol(SI);
        }


    }




}