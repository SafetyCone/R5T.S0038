using System;


namespace R5T.S0038
{
	public class TypeNameAffixes : ITypeNameAffixes
	{
		#region Infrastructure

	    public static TypeNameAffixes Instance { get; } = new();

	    private TypeNameAffixes()
	    {
	    }

	    #endregion
	}
}