using System;

using R5T.T0132;


namespace R5T.S0038
{
	[DraftFunctionalityMarker]
	public interface ITypeNameOperator : IDraftFunctionalityMarker
	{
		public string GetInterfaceTypeName(string typeNameStem)
        {
			var output = Instances.TypeNameAffixes.InterfacePrefix + typeNameStem;
			return output;
        }
	}
}