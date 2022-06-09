using System;


namespace R5T.S0038
{
	public class ProjectPathsOperator : IProjectPathsOperator
	{
		#region Infrastructure

		public static ProjectPathsOperator Instance { get; } = new();

		private ProjectPathsOperator()
		{
		}

		#endregion
	}
}