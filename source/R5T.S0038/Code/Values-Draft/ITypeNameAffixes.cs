using System;

using R5T.T0131;


namespace R5T.S0038
{
	[DraftValuesMarker]
	public interface ITypeNameAffixes : IDraftValuesMarker
	{
		public string InterfacePrefix => Instances.Strings.I_UpperCase;
	}
}