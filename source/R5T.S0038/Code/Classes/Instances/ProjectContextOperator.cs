using System;


namespace R5T.S0038
{
	public class ProjectContextOperator : IProjectContextOperator
	{
		#region Infrastructure

	    public static ProjectContextOperator Instance { get; } = new();

	    private ProjectContextOperator()
	    {
        }

	    #endregion
	}
}