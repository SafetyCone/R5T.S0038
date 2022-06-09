using System;


namespace R5T.S0038
{
	public class LibraryGenerator : ILibraryGenerator
	{
		#region Infrastructure

	    public static LibraryGenerator Instance { get; } = new();

	    private LibraryGenerator()
	    {
        }

	    #endregion
	}
}