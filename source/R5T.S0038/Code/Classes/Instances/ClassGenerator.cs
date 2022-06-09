using System;


namespace R5T.S0038
{
	public class ClassGenerator : IClassGenerator
	{
		#region Infrastructure

	    public static ClassGenerator Instance { get; } = new();

	    private ClassGenerator()
	    {
	    }

	    #endregion
	}
}