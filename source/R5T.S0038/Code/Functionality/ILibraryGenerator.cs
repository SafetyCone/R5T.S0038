using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0133;
using R5T.T0139.N004;
using R5T.T0139.N005;
using R5T.T0139.N006;

using N001 = R5T.T0139.N001;


namespace R5T.S0038
{
	[FunctionalityMarker]
	public partial interface ILibraryGenerator : IFunctionalityMarker
	{
        /// <summary>
        /// Creates a basic types library with:
        /// * Library project.
        /// * Construction console project.
        /// </summary>
        /// <returns></returns>
        public async Task CreateBasicTypesLibrary(
            string libraryName,
            string libraryDescription,
            bool isPrivate,
            string repositoriesDirectoryPath,
            N001.ICodeFileContextProvider codeFileContextProvider,
            ILocalRepositoryContextProvider localRepositoryContextProvider,
            IProjectContextProvider projectContextProvider,
            ISolutionContextProvider solutionContextProvider)
        {
            var repositoryName = Instances.LibraryNameOperator.GetRepositoryName(libraryName);
            // TODO, make into a functionality.
            var repositoryDescription = libraryDescription;

            var librarySolutionName = Instances.LibraryNameOperator.GetSolutionName(libraryName);

            var solutionNameStem = Instances.LibraryNameOperator.GetSolutionNameStem(libraryName);

            var constructionSolutionName = Instances.SolutionNameOperator.GetConstructionSolutionName(solutionNameStem);

            var libraryProjectName = Instances.LibraryNameOperator.GetProjectName(libraryName);

            var projectNameStem = Instances.LibraryNameOperator.GetProjectNameStem(libraryName);

            var constructionProjectName = Instances.ProjectNameOperator.GetConstructionProjectName(projectNameStem);

            await localRepositoryContextProvider.For_ByRepositoriesDirectoryPath(
                repositoryName,
                repositoriesDirectoryPath,
                async localRepositoryContext =>
                {
                    //// Delete library if it exists.
                    //await localRepositoryContext.DeleteBothLocalAndRemote();

                    // Safety check.
                    await localRepositoryContext.VerifyDoesNotExist();

                    await localRepositoryContext.CreateAndClone(
                        repositoryDescription,
                        isPrivate);

                    string libraryProjectFilePath = null;

                    // Create the library solution.
                    // Get the library solution file path.
                    var librarySolutionFilePath = localRepositoryContext.GetSourceSolutionFilePath(
                        librarySolutionName);

                    await solutionContextProvider.For(
                        librarySolutionFilePath,
                        async solutionContext =>
                        {
                            // Create the solution file.
                            await solutionContext.VisualStudioSolutionFileOperator.Create(solutionContext.SolutionFilePath);

                            // Create the library project.
                            await projectContextProvider.For(
                                libraryProjectName,
                                solutionContext.SolutionDirectoryPath(),
                                async projectContext =>
                                {
                                    await projectContext.VisualStudioProjectFileOperator.Create(
                                        projectContext.ProjectFilePath,
                                        D0079.VisualStudioProjectType.ClassLibrary);

                                    await solutionContext.AddProjectReference(
                                        projectContext.ProjectFilePath);

                                    libraryProjectFilePath = projectContext.ProjectFilePath;

                                    /// Create project internals.
                                    var namespaceName = Instances.ProjectContextOperator.GetNamespaceName(projectContext);
                                    var projectDescription = Instances.ProjectDescriptionGenerator.GetProjectDescription(
                                        libraryDescription);

                                    Instances.ProjectContextOperator.PerformInitialSetup(
                                        projectContext,
                                        projectDescription);

                                    // Delete the existing Class1.cs file.
                                    var initialClass1FilePath = projectContext.GetProjectDirectoryRelativeFilePath(
                                        @"Class1.cs");

                                    Instances.FileSystemOperator.DeleteFile(initialClass1FilePath);

                                    // Create classes directory.
                                    var classesDirectoryPath = Instances.ProjectContextOperator.GetClassesDirectoryPath(projectContext);

                                    Instances.FileSystemOperator.CreateDirectory(classesDirectoryPath);

                                    // Create initial class1 code file.
                                    var class1FilePath = Instances.PathOperator.GetFilePath(
                                        classesDirectoryPath,
                                        "Class1.cs");

                                    var codeFileContext = await codeFileContextProvider.GetCodeFileContext_WithoutProjectAndSolutionSearch(
                                        class1FilePath);

                                    var class1 = Instances.CompilationUnitGenerator.CreatePublicClass(
                                        namespaceName,
                                        "Class1",
                                        out var classAnnotation);

                                    var compilationRequirements = CompilationRequirements.From(class1);

                                    await codeFileContext.WriteCompilation(compilationRequirements);
                                });
                        });

                    // Create the construction solution.
                    // Get the library solution file path.
                    var constructionSolutionFilePath = localRepositoryContext.GetSourceSolutionFilePath(
                        constructionSolutionName);

                    await solutionContextProvider.For(
                        constructionSolutionFilePath,
                        async solutionContext =>
                        {
                            // Create the solution file.
                            await solutionContext.VisualStudioSolutionFileOperator.Create(solutionContext.SolutionFilePath);

                            // Create the construction console project.
                            await projectContextProvider.For(
                                constructionProjectName,
                                solutionContext.SolutionDirectoryPath(),
                                async projectContext =>
                                {
                                    await projectContext.VisualStudioProjectFileOperator.Create(
                                        projectContext.ProjectFilePath,
                                        D0079.VisualStudioProjectType.Console);

                                    await solutionContext.AddProjectReference(
                                        projectContext.ProjectFilePath);

                                    // Add the library project.
                                    await projectContext.AddProjectReference(libraryProjectFilePath);

                                    /// Create project internals.
                                    var namespaceName = Instances.ProjectContextOperator.GetNamespaceName(projectContext);
                                    var projectDescription = Instances.ProjectDescriptionGenerator.GetProjectDescription(
                                        libraryDescription);

                                    Instances.ProjectContextOperator.PerformInitialSetup(
                                        projectContext,
                                        projectDescription);

                                    // Delete the existing Program.cs file.
                                    var initialProgramFilePath = projectContext.GetProjectDirectoryRelativeFilePath(
                                        @"Program.cs");

                                    Instances.FileSystemOperator.DeleteFile(initialProgramFilePath);

                                    var codeDirectoryPath = Instances.ProjectContextOperator.GetCodeDirectoryPath(projectContext);

                                    // Create the new program file.
                                    var programFilePath = Instances.PathOperator.GetFilePath(
                                        codeDirectoryPath,
                                        "Program.cs");

                                    Instances.CodeFileGenerator.CreateProgramFile(
                                        programFilePath,
                                        namespaceName);

                                    // Create Instances file.
                                    var instancesFilePath = Instances.PathOperator.GetFilePath(
                                        codeDirectoryPath,
                                        "Instances.cs");

                                    Instances.CodeFileGenerator.CreateInstancesFile(
                                        instancesFilePath,
                                        namespaceName);
                                });

                            // Add the library project.
                            await solutionContext.AddProjectReference(libraryProjectFilePath);
                        });
                });
        }
    }
}