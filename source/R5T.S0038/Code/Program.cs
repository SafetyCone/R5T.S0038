using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.D0079;
using R5T.D0088;
using R5T.D0090;
using R5T.D0101;
using R5T.T0133;
using R5T.T0134;

using Contexts = R5T.T0139;

using N001 = R5T.T0139.N001;
using N002 = R5T.T0139.N002;
using N003 = R5T.T0139.N003;
using N004 = R5T.T0139.N004;
using N005 = R5T.T0139.N005;
using N006 = R5T.T0139.N006;
using N007 = R5T.T0139.N007;


namespace R5T.S0038
{
    partial class Program : ProgramAsAServiceBase
    {
        #region Static
        
        static async Task Main()
        {
            //OverridableProcessStartTimeProvider.Override("20211214 - 163052");
            //OverridableProcessStartTimeProvider.DoNotOverride();
        
            await Instances.Host.NewBuilder()
                .UseProgramAsAService<Program, T0075.IHostBuilder>()
                .UseHostStartup<HostStartup, T0075.IHostBuilder>(Instances.ServiceAction.AddHostStartupAction())
                .Build()
                .SerializeConfigurationAudit()
                .SerializeServiceCollectionAudit()
                .RunAsync();
        }

        #endregion

        private IProjectRepository ProjectRepository { get; }

        private N001.ICodeFileContextProvider CodeFileContextProvider_N001 { get; }
        private N003.ILocalRepositoryContextProvider LocalRepositoryContextProvider_N003 { get; }
        private N004.ILocalRepositoryContextProvider LocalRepositoryContextProvider_N004 { get; }
        private N006.IProjectContextProvider ProjectContextProvider_N006 { get; }
        private N007.IProjectContextProvider ProjectContextProvider_N007 { get; }
        private N002.IRemoteRepositoryContextProvider RemoteRepositoryContextProvider_N002 { get; }
        private N005.ISolutionContextProvider SolutionContextProvider_N005 { get; }

        
        public Program(IServiceProvider serviceProvider,
            IProjectRepository projectRepository,

            N001.ICodeFileContextProvider codeFileContextProvider_N001,
            N003.ILocalRepositoryContextProvider localRepositoryContextProvider_N003,
            N004.ILocalRepositoryContextProvider localRepositoryContextProvider_N004,
            N006.IProjectContextProvider projectContextProvider_N006,
            N007.IProjectContextProvider projectContextProvider_N007,
            N002.IRemoteRepositoryContextProvider remoteRepositoryContextProvider_N002,
            N005.ISolutionContextProvider solutionContextProvider_N005)
            : base(serviceProvider)
        {
            this.ProjectRepository = projectRepository;

            this.CodeFileContextProvider_N001 = codeFileContextProvider_N001;
            this.LocalRepositoryContextProvider_N003 = localRepositoryContextProvider_N003;
            this.LocalRepositoryContextProvider_N004 = localRepositoryContextProvider_N004;
            this.ProjectContextProvider_N006 = projectContextProvider_N006;
            this.ProjectContextProvider_N007 = projectContextProvider_N007;
            this.RemoteRepositoryContextProvider_N002 = remoteRepositoryContextProvider_N002;
            this.SolutionContextProvider_N005 = solutionContextProvider_N005;
        }

        protected override Task ServiceMain(CancellationToken stoppingToken)
        {
            //return this.RunOperation();
            return this.RunMethod();
        }

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0051 // Remove unused private members

        private Task RunOperation()
        {
            return Task.CompletedTask;
        }

        private Task RunMethod()
        {
            return this.CreateBasicTypesLibrary();

            //return this.CreateRepository();
            //return this.DeleteRepository();
            //return this.TestLocalRepository();
            //return this.CreateAndCloneRepository();
            //return this.DeleteRepositoryBothLocalAndRemote();
            //return this.CreateSolution();
            //return this.CreateProjectInSolution();
            //return this.DeleteProjectAndRemoveFromSolution();
            //return this.CreateInterface();
            //return this.CreateClass();
            //return this.CreatePublicStaticClass();
            //return this.CreateDraftFunctionalityInterface();
            //return this.CreateDraftFunctionalityInstanceInfrastructureClass();

            //// Not used, see R5t.S0042.
            //return this.CreateFunctionalityInstance();
            //return this.CreateDraftFunctionalityInstance();
            //return this.CreateValuesInstance();
            //return this.CreateDraftValuesInstance();
            //return this.CreateExplorationsInstance();
            //return this.CreateDraftExplorationsInstance();
            //return this.CreateExperimentsInstance();
            //return this.CreateDraftExperimentsInstance();
            //return this.CreateDemonstrationsInstance();
            //return this.CreateDraftDemonstrationsInstance();
        }

        //private async Task WriteCodeElement()
        //{

        //}

        private async Task CreateDraftExplorationsInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0007\source\R5T.F0007\R5T.F0007.csproj";
            var namespaceName = "R5T.S0038";
            var draftExplorationsNameStems = new[]
            {
                "ProjectIdentityStrings",
            };

            /// Run.
            var markerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftExplorationsMarkerAttribute;

            var markerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftExplorationsMarkerInterface;

            var markersProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0141);

            var interfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Explorations_Draft_Interfaces_Directory);

            var classesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Explorations_Draft_Classes_Directory);

            foreach (var nameStem in draftExplorationsNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    nameStem,
                    classesDirectoryPath,
                    interfacesDirectoryPath,
                    markerAttributeNamespacedTypeName,
                    markerInterfaceNamespacedTypeName,
                    markersProjectPath,
                    markersProjectPath);
            }
        }

        private async Task CreateDraftExperimentsInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0038\source\R5T.S0038\R5T.S0038.csproj";
            var namespaceName = "R5T.S0038";
            var draftExperimentsNameStems = new[]
            {
                "ProjectIdentityStrings",
            };

            /// Run.
            var markerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftExperimentsMarkerAttribute;

            var markerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftExperimentsMarkerInterface;

            var markersProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0141);

            var interfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Experiments_Draft_Interfaces_Directory);

            var classesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Experiments_Draft_Classes_Directory);

            foreach (var nameStem in draftExperimentsNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    nameStem,
                    classesDirectoryPath,
                    interfacesDirectoryPath,
                    markerAttributeNamespacedTypeName,
                    markerInterfaceNamespacedTypeName,
                    markersProjectPath,
                    markersProjectPath);
            }
        }

        private async Task CreateDraftDemonstrationsInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0038\source\R5T.S0038\R5T.S0038.csproj";
            var namespaceName = "R5T.S0038";
            var draftDemonstrationsNameStems = new[]
            {
                "ProjectIdentityStrings",
            };

            /// Run.
            var markerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftDemonstrationsMarkerAttribute;

            var markerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftDemonstrationsMarkerInterface;

            var markersProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0141);

            var interfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Demonstrations_Draft_Interfaces_Directory);

            var classesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Demonstrations_Draft_Classes_Directory);

            foreach (var nameStem in draftDemonstrationsNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    nameStem,
                    classesDirectoryPath,
                    interfacesDirectoryPath,
                    markerAttributeNamespacedTypeName,
                    markerInterfaceNamespacedTypeName,
                    markersProjectPath,
                    markersProjectPath);
            }
        }

        private async Task CreateExplorationsInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0002\source\R5T.Q0002\R5T.Q0002.csproj";
            var namespaceName = "R5T.Q0002";
            var explorationsNameStems = new[]
            {
                "LibGit2SharpExplorations",
            };

            /// Run.
            var markerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.ExplorationsMarkerAttribute;

            var markerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.ExplorationsMarkerInterface;

            var markersProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0141);

            var interfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Explorations_Interfaces_Directory);

            var classesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Explorations_Classes_Directory);

            foreach (var nameStem in explorationsNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    nameStem,
                    classesDirectoryPath,
                    interfacesDirectoryPath,
                    markerAttributeNamespacedTypeName,
                    markerInterfaceNamespacedTypeName,
                    markersProjectPath,
                    markersProjectPath);
            }
        }

        private async Task CreateExperimentsInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0038\source\R5T.S0038\R5T.S0038.csproj";
            var namespaceName = "R5T.S0038";
            var experimentsNameStems = new[]
            {
                "ProjectIdentityStrings",
            };

            /// Run.
            var markerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.ExperimentsMarkerAttribute;

            var markerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.ExperimentsMarkerInterface;

            var markersProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0141);

            var interfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Experiments_Interfaces_Directory);

            var classesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Experiments_Classes_Directory);

            foreach (var nameStem in experimentsNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    nameStem,
                    classesDirectoryPath,
                    interfacesDirectoryPath,
                    markerAttributeNamespacedTypeName,
                    markerInterfaceNamespacedTypeName,
                    markersProjectPath,
                    markersProjectPath);
            }
        }

        private async Task CreateDemonstrationsInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0001\source\R5T.Q0001\R5T.Q0001.csproj";
            var namespaceName = "R5T.Q0001";
            var demonstrationsNameStems = new[]
            {
                "SyntaxGenerationDemonstrations",
            };

            /// Run.
            var markerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DemonstrationsMarkerAttribute;

            var markerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DemonstrationsMarkerInterface;

            var markersProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0141);

            var interfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Demonstrations_Interfaces_Directory);

            var classesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Demonstrations_Classes_Directory);

            foreach (var nameStem in demonstrationsNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    nameStem,
                    classesDirectoryPath,
                    interfacesDirectoryPath,
                    markerAttributeNamespacedTypeName,
                    markerInterfaceNamespacedTypeName,
                    markersProjectPath,
                    markersProjectPath);
            }
        }

        private async Task CreateValuesInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0002\source\R5T.Z0002\R5T.Z0002.csproj";
            var namespaceName = "R5T.Z0002";
            var valuesNameStems = new[]
            {
                "TabCounts",
            };

            /// Run.
            var valuesMarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.ValuesMarkerAttribute;

            var valuesMarkerAttributeProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0131);

            var valuesMarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.ValuesMarkerInterface;

            var valuesMarkerInterfaceProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0131);

            var valuesInterfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Values_Interfaces_Directory);

            var valuesClassesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Values_Classes_Directory);

            foreach (var valuesNameStem in valuesNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    valuesNameStem,
                    valuesClassesDirectoryPath,
                    valuesInterfacesDirectoryPath,
                    valuesMarkerAttributeNamespacedTypeName,
                    valuesMarkerInterfaceNamespacedTypeName,
                    valuesMarkerAttributeProjectPath,
                    valuesMarkerInterfaceProjectPath);
            }
        }

        private async Task CreateDraftValuesInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0038\source\R5T.S0038\R5T.S0038.csproj";
            var namespaceName = "R5T.S0038";
            var draftValuesNameStems = new[]
            {
                "TypeNameAffixes",
            };

            /// Run.
            var draftValuesMarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftValuesMarkerAttribute;

            var draftValuesMarkerAttributeProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0131);

            var draftValuesMarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftValuesMarkerInterface;

            var draftValuesMarkerInterfaceProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0131);

            var draftValuesInterfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Values_Draft_Interfaces_Directory);

            var draftValuesClassesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Values_Draft_Classes_Directory);

            foreach (var draftValuesNameStem in draftValuesNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    draftValuesNameStem,
                    draftValuesClassesDirectoryPath,
                    draftValuesInterfacesDirectoryPath,
                    draftValuesMarkerAttributeNamespacedTypeName,
                    draftValuesMarkerInterfaceNamespacedTypeName,
                    draftValuesMarkerAttributeProjectPath,
                    draftValuesMarkerInterfaceProjectPath);
            }
        }

        private async Task CreateFunctionalityInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0023\source\R5T.F0023\R5T.F0023.csproj";
            var namespaceName = "R5T.F0023";
            var functionalityNameStems = new[]
            {
                "SyntaxParser",
            };

            /// Run.
            var functionalityMarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.FunctionalityMarkerAttribute;

            var functionalityMarkerAttributeProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0132);

            var functionalityMarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.FunctionalityMarkerInterface;

            var functionalityMarkerInterfaceProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0132);

            var functionalityInterfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Functionality_Interfaces_Directory);

            var functionalityClassesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Functionality_Classes_Directory);

            foreach (var functionalityNameStem in functionalityNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    functionalityNameStem,
                    functionalityClassesDirectoryPath,
                    functionalityInterfacesDirectoryPath,
                    functionalityMarkerAttributeNamespacedTypeName,
                    functionalityMarkerInterfaceNamespacedTypeName,
                    functionalityMarkerAttributeProjectPath,
                    functionalityMarkerInterfaceProjectPath);
            }
        }

        private async Task CreateDraftFunctionalityInstance()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0013\source\R5T.F0013\R5T.F0013.csproj";
            var namespaceName = "R5T.F0013";
            var draftFunctionalityNameStems = new[]
            {
                "SyntaxNodeOperator",
            };

            /// Run.
            var draftFunctionalityMarkerAttributeNamespacedTypeName = Instances.NamespacedTypeNames.DraftFunctionalityMarkerAttribute;

            var draftFunctionalityMarkerAttributeProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0132);

            var draftFunctionalityMarkerInterfaceNamespacedTypeName = Instances.NamespacedTypeNames.DraftFunctionalityMarkerInterface;

            var draftFunctionalityMarkerInterfaceProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0132);

            var draftFunctionalityInterfacesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Functionality_Draft_Interfaces_Directory);

            var draftFunctionalityClassesDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryRelativeDirectoryPath(
                projectFilePath,
                Instances.ProjectDirectoryRelativePath.Functionality_Draft_Classes_Directory);

            foreach (var draftFunctionalityNameStem in draftFunctionalityNameStems)
            {
                await this.CreateInstanceTypesPair(
                    namespaceName,
                    draftFunctionalityNameStem,
                    draftFunctionalityClassesDirectoryPath,
                    draftFunctionalityInterfacesDirectoryPath,
                    draftFunctionalityMarkerAttributeNamespacedTypeName,
                    draftFunctionalityMarkerInterfaceNamespacedTypeName,
                    draftFunctionalityMarkerAttributeProjectPath,
                    draftFunctionalityMarkerInterfaceProjectPath);
            }
        }

        private async Task DeleteProjectAndRemoveFromSolution()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Example\source\R5T.Example\R5T.Example.csproj";

            /// Run.
            await this.ProjectContextProvider_N007.In(
                projectFilePath,
                async projectContext =>
                {
                    projectContext.DeleteProjectDirectory_OkIfNotExist();

                    foreach (var solutionFilePath in projectContext.SolutionFilePaths)
                    {
                        await projectContext.VisualStudioSolutionFileOperator.RemoveProjectReference(
                            solutionFilePath,
                            projectContext.ProjectContext_N006.ProjectFilePath);
                    }
                });
        }

        private async Task CreateProjectInSolution()
        {
            /// Inputs.
            var projectName = Instances.Example.ProjectName;
            var projectType = VisualStudioProjectType.Console;

            var solutionFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Example\source\R5T.Example.sln";

            /// Run.
            await this.SolutionContextProvider_N005.In(
                solutionFilePath,
                async solutionContext =>
                {
                    await this.ProjectContextProvider_N006.For(
                        projectName,
                        solutionContext.SolutionDirectoryPath(),
                        async projectContext =>
                        {
                            await projectContext.VisualStudioProjectFileOperator.Create(
                                projectContext.ProjectFilePath,
                                projectType);

                            await solutionContext.AddProjectReference(
                                projectContext.ProjectFilePath);
                        });
                });
        }

        private async Task CreateSolution()
        {
            /// Inputs.
            var libraryName = Instances.Example.LibraryName;

            var repositoriesDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\";

            /// Run.
            var repositoryName = Instances.LibraryNameOperator.GetRepositoryName(libraryName);
            var solutionName = Instances.LibraryNameOperator.GetSolutionName(libraryName);

            await this.LocalRepositoryContextProvider_N004.For_ByRepositoriesDirectoryPath(
                repositoryName,
                repositoriesDirectoryPath,
                async localRepositoryContext =>
                {
                    // Get the source solution file path.
                    var solutionFilePath = localRepositoryContext.GetSourceSolutionFilePath(
                        solutionName);

                    // In a solution context-for.
                    await this.SolutionContextProvider_N005.For(
                        solutionFilePath,
                        async solutionContext =>
                        {
                            Console.WriteLine($"Solution directory exists: {solutionContext.SolutionDirectoryExists()}");
                            Console.WriteLine($"Solution file exists: {solutionContext.SolutionFileExists()}");

                            // Create the solution file.
                            await solutionContext.VisualStudioSolutionFileOperator.Create(solutionContext.SolutionFilePath);

                            Console.WriteLine($"Solution directory exists: {solutionContext.SolutionDirectoryExists()}");
                            Console.WriteLine($"Solution file exists: {solutionContext.SolutionFileExists()}");
                        });
                });
        }

        private async Task DeleteRepositoryBothLocalAndRemote()
        {
            /// Inputs.
            var repositoryName = Instances.Example.RepositoryName;

            var repositoriesDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\";

            /// Run.
            await this.LocalRepositoryContextProvider_N004.For_ByRepositoriesDirectoryPath(
                repositoryName,
                repositoriesDirectoryPath,
                async localRepositoryContext =>
                {
                    await localRepositoryContext.DeleteBothLocalAndRemote();
                });
        }

        private async Task CreateAndCloneRepository()
        {
            /// Inputs.
            var repositoryName = Instances.Example.RepositoryName;
            var repositoryDescription = Instances.Example.RepositoryDescription;
            var isPrivate = true;

            var repositoriesDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\";

            /// Run.
            await this.LocalRepositoryContextProvider_N004.For_ByRepositoriesDirectoryPath(
                repositoryName,
                repositoriesDirectoryPath,
                async localRepositoryContext =>
                {
                    await localRepositoryContext.CreateAndClone(
                        repositoryDescription,
                        isPrivate);
                });
        }

        private async Task TestLocalRepository()
        {
            /// Inputs.
            var filePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0038\source\R5T.S0038\Code\Program.cs";

            /// Run.
            await this.LocalRepositoryContextProvider_N003.ForFileIn(
                filePath,
                async localRepositoryContext =>
                {
                    var url = await localRepositoryContext.GitOperator.GetRemoteUrl(localRepositoryContext.DirectoryPath);

                    Console.WriteLine(url);
                });
        }

        private async Task DeleteRepository()
        {
            /// Inputs.
            var repositoryName = Instances.Example.RepositoryName;

            /// Run.
            await this.RemoteRepositoryContextProvider_N002.For(
                repositoryName,
                async remoteRepositoryContext =>
                {
                    await Instances.RemoteRepositoryFunctionality.ReportIfRepositoryExists(
                        remoteRepositoryContext,
                        repositoryName);

                    await Instances.RemoteRepositoryFunctionality.VerifyRemoteRepositoryExists(remoteRepositoryContext);

                    await remoteRepositoryContext.DeleteRemoteRepository();

                    await Instances.RemoteRepositoryFunctionality.ReportIfRepositoryExists(
                        remoteRepositoryContext,
                        repositoryName);
                });
        }

        private async Task CreateRepository()
        {
            /// Inputs.
            var repositoryName = Instances.Example.RepositoryName;
            var repositoryDescription = Instances.Example.RepositoryDescription;
            var isPrivate = false;

            /// Run.
            await this.RemoteRepositoryContextProvider_N002.For(
                repositoryName,
                async repositoryContext =>
                {
                    await Instances.RemoteRepositoryFunctionality.ReportIfRepositoryExists(
                        repositoryContext,
                        repositoryName);

                    await Instances.RemoteRepositoryFunctionality.VerifyRemoteRepositoryDoesNotExist(repositoryContext);

                    await Instances.RemoteRepositoryFunctionality.CreateRepository_NonIdempotent(
                        repositoryContext,
                        repositoryName,
                        repositoryDescription,
                        isPrivate);

                    await Instances.RemoteRepositoryFunctionality.ReportIfRepositoryExists(
                        repositoryContext,
                        repositoryName);
                });
        }

        //private Task CreateDraftFunctionalityType()
        //{
        //    var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0041\source\R5T.S0041\R5T.S0041.csproj";

        //    var draftFunctionalityInterfacesDirectoryProjectDirectoryRelativePath = @"Code\Functionality-Draft\Interfaces";
        //    var draftFunctionalityClassesDirectoryProjectDirectoryRelativePath = @"Code\Functionality-Draft\Classes";
        //}

        private async Task CreateClass()
        {
            var namespaceName = "Namespace1";
            var className = "Class1";

            var @class = Instances.ClassGenerator.CreateClass(
                namespaceName,
                className,
                out _);

            var codeFileContext = await this.CodeFileContextProvider_N001.GetCodeFileContext_WithoutProjectAndSolutionSearch(
                @"C:\Temp\Code.cs");

            await codeFileContext.WriteCompilation(@class);
        }

        private async Task CreatePublicStaticClass()
        {
            var namespaceName = "Namespace1";
            var className = "Class1";

            var @class = Instances.ClassGenerator.CreatePublicStaticClass(
                namespaceName,
                className,
                out _);

            @class.NamespaceNames.EnsureHas(
                "System");

            var namespaceSpacing = Instances.SpacingGenerator.TwoBlankLines();

            @class = @class.Modify(
                xNamespace => xNamespace.WithLeadingTrivia(namespaceSpacing));

            var codeFileContext = await this.CodeFileContextProvider_N001.GetCodeFileContext_WithoutProjectAndSolutionSearch(
                @"C:\Temp\Code.cs");

            await codeFileContext.WriteCompilation(@class);
        }

        private async Task CreateInterface()
        {
            var compilationRequirements = Instances.CompilationUnitGenerator.CreateServiceDefinitionInterface();

            var codeFileContextProvider = this.ServiceProvider.GetRequiredService<Contexts.N001.ICodeFileContextProvider>();

            var codeFileContext = await codeFileContextProvider.GetCodeFileContext_WithoutProjectAndSolutionSearch(
                @"C:\Temp\Code.cs");

            await codeFileContext.WriteCompilation(compilationRequirements);
        }

        private async Task CreateDraftFunctionalityInterface()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0038\source\R5T.S0038\R5T.S0038.csproj";
            var namespaceName = "R5T.S0038";
            var draftFunctionalityNameStem = "TestOperator";


            /// Run.
            var projectDirectoryPath = Instances.PathOperator.GetDirectoryPathOfFilePath(projectFilePath);

            var draftFunctionalityInterfacesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                @"Code\Functionality-Draft\Interfaces");


            var draftFunctionalityInterfaceName = "I" + draftFunctionalityNameStem;
            //var draftFunctionalityClassName = draftFunctionalityNameStem;

            var draftFunctionalityInterfaceCodeFileName = Instances.CodeFileName.GetCSharpFileNameForTypeName(draftFunctionalityInterfaceName);
            var draftFunctionalityInterfaceCodeFilePath = Instances.PathOperator.GetFilePath(
                draftFunctionalityInterfacesDirectoryPath,
                draftFunctionalityInterfaceCodeFileName);

            Console.WriteLine(draftFunctionalityInterfaceCodeFilePath);

            var draftFunctionalityMarkerAttributeNamespacedTypeName = "R5T.T0132.DraftFunctionalityMarkerAttribute";
            var draftFunctionalityMarkerAttributeTypeName = Instances.NamespacedTypeNameOperator.GetTypeName(draftFunctionalityMarkerAttributeNamespacedTypeName);
            var draftFunctionalityMarkerAttributeName = Instances.TypeNameOperator_Base.GetEnsuredNonAttributeSuffixedTypeName(draftFunctionalityMarkerAttributeTypeName);
            var draftFunctionalityMarkerAttributeNamespaceName = Instances.NamespacedTypeNameOperator.GetNamespaceName(draftFunctionalityMarkerAttributeNamespacedTypeName);

            var draftFunctionalityMarkerAttributeProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0132);

            var draftFunctionalityMarkerInterfaceNamespacedTypeName = "R5T.T0132.IDraftFunctionalityMarker";
            var draftFunctionalityMarkerInterfaceNamespaceName = Instances.NamespacedTypeNameOperator.GetNamespaceName(draftFunctionalityMarkerInterfaceNamespacedTypeName);
            var draftFunctionalityMarkerInterfaceTypeName = Instances.NamespacedTypeNameOperator.GetTypeName(draftFunctionalityMarkerInterfaceNamespacedTypeName);

            var draftFunctionalityMarkerInterfaceProjectPath = await this.ProjectRepository.GetFilePathForProjectIdentityString(
                Instances.ProjectIdentityStrings.R5T_T0132);

            var compilationUnit = Instances.SyntaxGenerator.CompilationUnit();

            var usingSystemNamespace = Instances.SyntaxGenerator.UsingSystemNamespace();

            // TODO: should be a functionality.
            ISyntaxNodeAnnotation<UsingDirectiveSyntax> usingDirectiveAnnotation;
            (compilationUnit, usingDirectiveAnnotation) = compilationUnit.AddUsingDirective(usingSystemNamespace);

            var @namespace = Instances.SyntaxGenerator_Base.Namespace(namespaceName);

            ISyntaxNodeAnnotation<NamespaceDeclarationSyntax> namespaceAnnotation;
            (compilationUnit, namespaceAnnotation) = compilationUnit.AddNamespace(@namespace);

            var namespaceSpacing = Instances.SpacingGenerator.TwoBlankLines();

            compilationUnit = namespaceAnnotation.Modify(
                compilationUnit,
                @namespace => @namespace.WithLeadingTrivia(namespaceSpacing));

            var @interface = Instances.SyntaxGenerator_Base.Interface(draftFunctionalityInterfaceName);

            //compilationUnit = namespaceAnnotation.Modify(
            //    compilationUnit,
            //    @namespace => @namespace.AddMembers(@interface));

            ISyntaxNodeAnnotation<InterfaceDeclarationSyntax> interfaceAnnotation;
            (compilationUnit, interfaceAnnotation) = namespaceAnnotation.AddMemberWithResult(
                compilationUnit,
                @interface);

            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface => @interface
                    .MakePublic().DiscardAnnotation());

            var attribute = Instances.SyntaxGenerator_Base.Attribute(draftFunctionalityMarkerAttributeName);

            var baseType = Instances.SyntaxGenerator_Simple.SimpleBaseType(draftFunctionalityMarkerInterfaceTypeName);

            ISyntaxNodeAnnotation<AttributeSyntax> attributeAnnotation = SyntaxNodeAnnotation.Initialize<AttributeSyntax>();
            ISyntaxNodeAnnotation<SimpleBaseTypeSyntax> baseTypeAnnotation = SyntaxNodeAnnotation.Initialize<SimpleBaseTypeSyntax>();
            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface =>
                {
                    (@interface, attributeAnnotation) = @interface.AddAttribute(attribute);

                    baseType = baseType.Annotate(out baseTypeAnnotation);

                    @interface = @interface.WithBaseList(
                        Instances.SyntaxGenerator_Simple.BaseListSyntax(baseType)
                            .NormalizeWhitespace());

                    return @interface;
                });

            // Indentation.
            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface => @interface
                    .PrependNewLine()
                    .Indent(
                        Instances.IndentationGenerator.ForInterface()));

            var compilationRequirements = CompilationRequirements.From(compilationUnit)
                .AddNamespaceName(draftFunctionalityMarkerAttributeNamespaceName)
                .AddNamespaceName(draftFunctionalityMarkerInterfaceNamespaceName)
                .AddProjectReferenceFilePath(draftFunctionalityMarkerAttributeProjectPath)
                .AddProjectReferenceFilePath(draftFunctionalityMarkerInterfaceProjectPath)
                ;

            var codeFileContextProvider = this.ServiceProvider.GetRequiredService<Contexts.N001.ICodeFileContextProvider>();

            var codeFileContext = await codeFileContextProvider.GetCodeFileContext_WithoutProjectAndSolutionSearch(
                draftFunctionalityInterfaceCodeFilePath);

            await codeFileContext.WriteCompilation(compilationRequirements);
        }

        private Task CreateDraftFunctionalityInstanceInfrastructureClass()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0038\source\R5T.S0038\R5T.S0038.csproj";
            var namespaceName = "R5T.S0038";
            var draftFunctionalityNameStem = "TestOperator";

            /// Run.
            var projectDirectoryPath = Instances.PathOperator.GetDirectoryPathOfFilePath(projectFilePath);

            var draftFunctionalityClassesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                @"Code\Functionality-Draft\Classes");

            return this.CreateInstanceInfrastructureClass(
                namespaceName,
                draftFunctionalityNameStem,
                draftFunctionalityClassesDirectoryPath);
        }

        private async Task CreateInstanceInfrastructureClass(
            string namespaceName,
            string instanceTypeNameStem,
            string classesDirectoryPath)
        {
            /// Run.
            var classTypeName = instanceTypeNameStem;
            var baseInterfaceTypeName = "I" + instanceTypeNameStem;

            var classCodeFileName = Instances.CodeFileName.GetCSharpFileNameForTypeName(classTypeName);
            var classCodeFilePath = Instances.PathOperator.GetFilePath(
                classesDirectoryPath,
                classCodeFileName);

            Console.WriteLine(classCodeFilePath);

            var compilationUnit = Instances.SyntaxGenerator.CompilationUnit();

            var usingSystemNamespace = Instances.SyntaxGenerator.UsingSystemNamespace();

            // TODO: should be a functionality.
            ISyntaxNodeAnnotation<UsingDirectiveSyntax> usingDirectiveAnnotation;
            (compilationUnit, usingDirectiveAnnotation) = compilationUnit.AddUsingDirective(usingSystemNamespace);

            var @namespace = Instances.SyntaxGenerator_Base.Namespace(namespaceName);

            ISyntaxNodeAnnotation<NamespaceDeclarationSyntax> namespaceAnnotation;
            (compilationUnit, namespaceAnnotation) = compilationUnit.AddNamespace(@namespace);

            var namespaceSpacing = Instances.SpacingGenerator.TwoBlankLines();

            compilationUnit = namespaceAnnotation.Modify(
                compilationUnit,
                @namespace => @namespace.WithLeadingTrivia(namespaceSpacing));

            var @class = Instances.SyntaxGenerator_ParseSimple.ParseClass(
$@"public class {classTypeName} : {baseInterfaceTypeName}
{{
    #region Infrastructure

    public static {classTypeName} Instance {{ get; }} = new();

    private {classTypeName}()
    {{
    }}

    #endregion
}}");

            ISyntaxNodeAnnotation<ClassDeclarationSyntax> classAnnotation;
            (compilationUnit, classAnnotation) = namespaceAnnotation.AddMemberWithResult(
                compilationUnit,
                @class);

            // Indentation.
            compilationUnit = classAnnotation.Modify(
                compilationUnit,
                @interface => @class
                    .PrependNewLine()
                    .Indent(
                        Instances.IndentationGenerator.ForClass()));

            var compilationRequirements = CompilationRequirements.From(compilationUnit);

            var codeFileContextProvider = this.ServiceProvider.GetRequiredService<Contexts.N001.ICodeFileContextProvider>();

            var codeFileContext = await codeFileContextProvider.GetCodeFileContext_WithoutProjectAndSolutionSearch(
                classCodeFilePath);

            await codeFileContext.WriteCompilation(compilationRequirements);
        }

        private async Task CreateInstanceTypesPair(
            string namespaceName,
            string instanceTypeNameStem,
            string classesDirectoryPath,
            string interfacesDirectoryPath,
            string markerAttributeNamespacedTypeName,
            string markerInterfaceNamespacedTypeName,
            string markerAttributeProjectPath,
            string markerInterfaceProjectPath)
        {
            await this.CreateInstanceInterface(
                namespaceName,
                instanceTypeNameStem,
                interfacesDirectoryPath,
                markerAttributeNamespacedTypeName,
                markerInterfaceNamespacedTypeName,
                markerAttributeProjectPath,
                markerInterfaceProjectPath);

            await this.CreateInstanceInfrastructureClass(
                namespaceName,
                instanceTypeNameStem,
                classesDirectoryPath);
        }

        private async Task CreateInstanceInterface(
            string namespaceName,
            string instanceTypeNameStem,
            string interfacesDirectoryPath,
            string markerAttributeNamespacedTypeName,
            string markerInterfaceNamespacedTypeName,
            string markerAttributeProjectPath,
            string markerInterfaceProjectPath)
        {
            var draftFunctionalityInterfaceName = Instances.TypeNameOperator.GetInterfaceTypeName(instanceTypeNameStem);

            var draftFunctionalityInterfaceCodeFileName = Instances.CodeFileName.GetCSharpFileNameForTypeName(draftFunctionalityInterfaceName);
            var draftFunctionalityInterfaceCodeFilePath = Instances.PathOperator.GetFilePath(
                interfacesDirectoryPath,
                draftFunctionalityInterfaceCodeFileName);

            var markerAttributeTypeName = Instances.NamespacedTypeNameOperator.GetTypeName(markerAttributeNamespacedTypeName);
            var markerAttributeNamespaceName = Instances.NamespacedTypeNameOperator.GetNamespaceName(markerAttributeNamespacedTypeName);

            var markerAttributeName = Instances.TypeNameOperator_Base.GetEnsuredNonAttributeSuffixedTypeName(markerAttributeTypeName);

            var markerInterfaceNamespaceName = Instances.NamespacedTypeNameOperator.GetNamespaceName(markerInterfaceNamespacedTypeName);
            var markerInterfaceTypeName = Instances.NamespacedTypeNameOperator.GetTypeName(markerInterfaceNamespacedTypeName);

            // Compilation unit.
            var compilationUnit = Instances.SyntaxGenerator.CompilationUnit();

            // Using System.
            var usingSystemNamespace = Instances.SyntaxGenerator.UsingSystemNamespace();

            compilationUnit = compilationUnit.AddUsingDirective(
                usingSystemNamespace,
                out var usingDirectiveAnnotation);

            // Namespace.
            var @namespace = Instances.SyntaxGenerator_Base.Namespace(namespaceName);

            compilationUnit = compilationUnit.AddNamespace(
                @namespace,
                out var namespaceAnnotation);

            var namespaceSpacing = Instances.SpacingGenerator.TwoBlankLines();

            compilationUnit = namespaceAnnotation.Modify(
                compilationUnit,
                @namespace => @namespace.WithLeadingTrivia(namespaceSpacing));

            // Interface.
            var @interface = Instances.SyntaxGenerator_Base.Interface(draftFunctionalityInterfaceName);

            ISyntaxNodeAnnotation<InterfaceDeclarationSyntax> interfaceAnnotation;
            (compilationUnit, interfaceAnnotation) = namespaceAnnotation.AddMemberWithResult(
                compilationUnit,
                @interface);

            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface => @interface
                    .MakePublic().DiscardAnnotation());

            var attribute = Instances.SyntaxGenerator_Base.Attribute(markerAttributeName);

            var baseType = Instances.SyntaxGenerator_Simple.SimpleBaseType(markerInterfaceTypeName);

            ISyntaxNodeAnnotation<AttributeSyntax> attributeAnnotation = SyntaxNodeAnnotation.Initialize<AttributeSyntax>();
            ISyntaxNodeAnnotation<SimpleBaseTypeSyntax> baseTypeAnnotation = SyntaxNodeAnnotation.Initialize<SimpleBaseTypeSyntax>();
            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface =>
                {
                    (@interface, attributeAnnotation) = @interface.AddAttribute(attribute);

                    baseType = baseType.Annotate(out baseTypeAnnotation);

                    @interface = @interface.WithBaseList(
                        Instances.SyntaxGenerator_Simple.BaseListSyntax(baseType)
                            .NormalizeWhitespace()
                            // Add a leading space in from of the base types list colon.
                            .PrependSpace());

                    return @interface;
                });

            // Indentation.
            compilationUnit = interfaceAnnotation.Modify(
                compilationUnit,
                @interface => @interface
                    .PrependNewLine()
                    .Indent(
                        Instances.IndentationGenerator.ForInterface()));

            var compilationRequirements = CompilationRequirements.From(compilationUnit)
                .AddNamespaceName(markerAttributeNamespaceName)
                .AddNamespaceName(markerInterfaceNamespaceName)
                .AddProjectReferenceFilePath(markerAttributeProjectPath)
                .AddProjectReferenceFilePath(markerInterfaceProjectPath)
                ;

            var codeFileContextProvider = this.ServiceProvider.GetRequiredService<Contexts.N001.ICodeFileContextProvider>();

            var codeFileContext = await codeFileContextProvider.GetCodeFileContext_WithoutProjectAndSolutionSearch(
                draftFunctionalityInterfaceCodeFilePath);

            await codeFileContext.WriteCompilation(compilationRequirements);
        }

        /// <summary>
        /// Creates a basic types library with:
        /// * Library project.
        /// * Construction console project.
        /// </summary>
        public async Task CreateBasicTypesLibrary()
        {
            /// Inputs
            var libraryName = "R5T.Z0009";
            var libraryDescription = "Visual Studio project type GUIDs.";
            var isPrivate = false;

            var repositoriesDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\";

            /// Run.
            await Instances.LibraryGenerator.CreateBasicTypesLibrary(
                libraryName,
                libraryDescription,
                isPrivate,
                repositoriesDirectoryPath,
                this.CodeFileContextProvider_N001,
                this.LocalRepositoryContextProvider_N004,
                this.ProjectContextProvider_N006,
                this.SolutionContextProvider_N005);
        }
    }
}