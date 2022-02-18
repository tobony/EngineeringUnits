
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class CoefficientOfThermalExpansion : BaseUnit
    {

        public CoefficientOfThermalExpansion() { }
        public CoefficientOfThermalExpansion(decimal value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(double value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(int value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(UnknownUnit value) : base(value) { }

        public static CoefficientOfThermalExpansion From(double value, CoefficientOfThermalExpansionUnit unit) => new(value, unit);
        public double As(CoefficientOfThermalExpansionUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public CoefficientOfThermalExpansion ToUnit(CoefficientOfThermalExpansionUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static CoefficientOfThermalExpansion Zero => new(0, CoefficientOfThermalExpansionUnit.SI);

        public static implicit operator CoefficientOfThermalExpansion(UnknownUnit Unit) => new(Unit);

        public static implicit operator CoefficientOfThermalExpansion(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<CoefficientOfThermalExpansionUnit>(_unit);
	}
}

