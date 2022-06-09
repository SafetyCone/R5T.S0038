using System;


namespace R5T.S0038
{
	public class NamespaceGenerator : INamespaceGenerator
	{
		#region Infrastructure

	    public static NamespaceGenerator Instance { get; } = new();

	    private NamespaceGenerator()
	    {
	    }

	    #endregion
	}
}