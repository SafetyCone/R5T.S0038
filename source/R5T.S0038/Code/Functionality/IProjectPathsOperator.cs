using System;

using R5T.T0132;


namespace R5T.S0038
{
	[FunctionalityMarker]
	public interface IProjectPathsOperator : IFunctionalityMarker
	{
		public string GetProjectDirectoryPath(
			string projectFilePath)
        {
			var output = Instances.PathOperator.GetDirectoryPathOfFilePath(projectFilePath);
			return output;
		}

		public string GetProjectDirectoryRelativeDirectoryPath(
			string projectFilePath,
			string projectDirectoryRelativeDirectoryPath)
        {
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var directoryPath = Instances.PathOperator.GetDirectoryPath(
				projectDirectoryPath,
				projectDirectoryRelativeDirectoryPath);

			return directoryPath;
		}
	}
}