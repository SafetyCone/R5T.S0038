using System;


namespace R5T.S0038
{
	public class TypeNameOperator : ITypeNameOperator
	{
		#region Infrastructure

	    public static TypeNameOperator Instance { get; } = new();

	    private TypeNameOperator()
	    {
	    }

	    #endregion
	}
}