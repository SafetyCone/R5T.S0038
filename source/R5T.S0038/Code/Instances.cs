using System;

using R5T.B0003;
using R5T.B0007;
using R5T.D0082.T001;
using R5T.S0036.F001;
using R5T.T0037;
using R5T.T0040;
using R5T.T0041;
using R5T.T0044;
using R5T.T0062;
using R5T.T0070;
using R5T.T0110;
using R5T.T0112;
using R5T.T0115;
using R5T.Z0000;
using R5T.Z0004;
using R5T.Z0006;
using R5T.Z0007;

using ISyntaxGenerator_Base = R5T.B0006.ISyntaxGenerator;
using ISyntaxGenerator_Simple = R5T.F0004.ISyntaxGenerator;
using ISyntaxGenerator_ParseSimple = R5T.F0005.ISyntaxParser;
using ITypeNameOperator_Base = R5T.B0001.ITypeNameOperator;


namespace R5T.S0038
{
    public static class Instances
    {
        public static F0014.IClassGenerator ClassGenerator { get; } = F0014.ClassGenerator.Instance;
        public static ICodeFileGenerator CodeFileGenerator { get; } = S0038.CodeFileGenerator.Instance;
        public static ICodeFileName CodeFileName { get; } = T0037.CodeFileName.Instance;
        public static ICodeFileContextProvider CodeFileContextProvider { get; } = S0038.CodeFileContextProvider.Instance;
        public static ICompilationUnitGenerator CompilationUnitGenerator { get; } = S0038.CompilationUnitGenerator.Instance;
        public static IExample Example { get; } = Z0004.Example.Instance;
        public static IFileSystemOperator FileSystemOperator { get; } = T0044.FileSystemOperator.Instance;
        public static IGitHubRepositorySpecificationGenerator GitHubRepositorySpecificationGenerator { get; } = D0082.T001.GitHubRepositorySpecificationGenerator.Instance;
        public static IHost Host { get; } = T0070.Host.Instance;
        public static IIndentationGenerator IndentationGenerator { get; } = B0007.IndentationGenerator.Instance;
        public static ILibraryGenerator LibraryGenerator { get; } = S0038.LibraryGenerator.Instance;
        public static ILibraryNameOperator LibraryNameOperator { get; } = T0110.LibraryNameOperator.Instance;
        public static INamespacedTypeNameOperator NamespacedTypeNameOperator { get; } = B0003.NamespacedTypeNameOperator.Instance;
        public static INamespacedTypeNames NamespacedTypeNames { get; } = Z0006.NamespacedTypeNames.Instance;
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static IProjectContextOperator ProjectContextOperator { get; } = S0038.ProjectContextOperator.Instance;
        public static IProjectDescriptionGenerator ProjectDescriptionGenerator { get; } = T0115.ProjectDescriptionGenerator.Instance;
        public static IProjectDirectoryRelativePath ProjectDirectoryRelativePath { get; } = Z0007.ProjectDirectoryRelativePath.Instance;
        public static IProjectIdentityStrings ProjectIdentityStrings { get; } = S0038.ProjectIdentityStrings.Instance;
        public static IProjectNameOperator ProjectNameOperator { get; } = T0112.ProjectNameOperator.Instance;
        public static IProjectPath ProjectPath { get; } = T0040.ProjectPath.Instance;
        public static IProjectPathsOperator ProjectPathsOperator { get; } = S0038.ProjectPathsOperator.Instance;
        public static IRemoteRepositoryFunctionality RemoteRepositoryFunctionality { get; } = S0038.RemoteRepositoryFunctionality.Instance;
        public static IServiceAction ServiceAction { get; } = T0062.ServiceAction.Instance;
        public static ISolutionNameOperator SolutionNameOperator { get; } = T0112.SolutionNameOperator.Instance;
        public static ISpacingGenerator SpacingGenerator { get; } = B0007.SpacingGenerator.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
        public static ISyntaxGenerator SyntaxGenerator { get; } = S0038.SyntaxGenerator.Instance;
        public static ISyntaxGenerator_Base SyntaxGenerator_Base { get; } = B0006.SyntaxGenerator.Instance;
        public static ISyntaxGenerator_ParseSimple SyntaxGenerator_ParseSimple { get; } = F0005.SyntaxParser.Instance;
        public static ISyntaxGenerator_Simple SyntaxGenerator_Simple { get; } = F0004.SyntaxGenerator.Instance;
        public static ISyntaxTextValues SyntaxTextValues { get; } = S0038.SyntaxTextValues.Instance;
        public static ITypeNameAffixes TypeNameAffixes { get; } = S0038.TypeNameAffixes.Instance;
        public static ITypeNameOperator TypeNameOperator { get; } = S0038.TypeNameOperator.Instance;
        public static ITypeNameOperator_Base TypeNameOperator_Base { get; } = B0001.TypeNameOperator.Instance;
    }
}