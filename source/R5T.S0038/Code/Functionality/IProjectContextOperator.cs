using System;
using System.IO;

using R5T.T0132;
using R5T.T0139.N006;


namespace R5T.S0038
{
	[FunctionalityMarker]
	public partial interface IProjectContextOperator : IFunctionalityMarker
	{
        public string GetClassesDirectoryPath(IProjectContext projectContext)
        {
            var codeDirectoryPath = this.GetCodeDirectoryPath(projectContext);

            var classesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                codeDirectoryPath,
                @"Classes");

            return classesDirectoryPath;
        }

        public string GetCodeDirectoryPath(IProjectContext projectContext)
        {
            var codeDirectoryPath = projectContext.GetProjectDirectoryRelativeFilePath(
                @"Code");

            return codeDirectoryPath;
        }

        public string GetNamespaceName(IProjectContext projectContext)
        {
            var namespaceName = Instances.ProjectNameOperator.GetDefaultProjectNamespaceName(
                projectContext.GetProjectName());

            return namespaceName;
        }

		public void PerformInitialSetup(
			IProjectContext projectContext,
            string projectDescription)
        {
            var namespaceName = this.GetNamespaceName(projectContext);

            // Create Code directory.
            var codeDirectoryPath = this.GetCodeDirectoryPath(projectContext);

            Instances.FileSystemOperator.CreateDirectory(codeDirectoryPath);

            // Create project plan file.
            var projectPlanFilePath = Instances.PathOperator.GetFilePath(
                projectContext.GetDirectoryPath(),
                "Project Plan.txt");

            var lines = EnumerableHelper.From($"{projectContext.GetProjectName()} - {projectDescription}");

            FileHelper.WriteAllLines_Synchronous(
                projectPlanFilePath,
                lines);

            // Create documentation file.
            var documentationFilePath = Instances.PathOperator.GetFilePath(
                codeDirectoryPath,
                "Documentation.cs");

            Instances.CodeFileGenerator.CreateDocumentationFile(
                documentationFilePath,
                namespaceName,
                projectDescription);
        }
	}
}