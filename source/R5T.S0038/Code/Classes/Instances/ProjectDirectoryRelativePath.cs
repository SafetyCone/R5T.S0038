using System;


namespace R5T.S0038
{
	public class ProjectDirectoryRelativePath : IProjectDirectoryRelativePath
	{
		#region Infrastructure

	    public static ProjectDirectoryRelativePath Instance { get; } = new();

	    private ProjectDirectoryRelativePath()
	    {
        }

	    #endregion
	}
}