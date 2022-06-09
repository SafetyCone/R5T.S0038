using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.A0003;
using R5T.D0037.A002;
using R5T.D0048.Default;
using R5T.D0077.A002;
using R5T.D0078.A002;
using R5T.D0079.A002;
using R5T.D0081.I001;
using R5T.D0082.A001;
using R5T.D0083.I001;
using R5T.D0088.I0002;
using R5T.D0094.I001;
using R5T.D0095.I001;
using R5T.D0101.I0001;
using R5T.D0101.I001;
using R5T.D0116.A0001;
using R5T.Magyar;
using R5T.Ostrogothia.Rivet;
using R5T.T0063;
using R5T.T0139.N001;
using R5T.T0139.N001.D001;
using R5T.T0139.N002;
using R5T.T0139.N003;
using R5T.T0139.N004;
using R5T.T0139.N005;
using R5T.T0139.N007;


using IProvidedServiceActionAggregation = R5T.D0088.I0002.IProvidedServiceActionAggregation;
using IRequiredServiceActionAggregation = R5T.D0088.I0002.IRequiredServiceActionAggregation;
using ServicesPlatformRequiredServiceActionAggregation = R5T.A0003.RequiredServiceActionAggregation;


namespace R5T.S0038
{
    public class HostStartup : HostStartupBase
    {
        public override Task ConfigureConfiguration(IConfigurationBuilder configurationBuilder)
        {   
            // Do nothing.
        
            return Task.CompletedTask;
        }

        protected override Task ConfigureServices(IServiceCollection services, IProvidedServiceActionAggregation providedServicesAggregation)
        {
            // Inputs.
            var executionSynchronicityProviderAction = Instances.ServiceAction.AddConstructorBasedExecutionSynchronicityProviderAction(Synchronicity.Synchronous);

            var organizationProviderAction = Instances.ServiceAction.AddOrganizationProviderAction(); // Rivet organization.

            var rootOutputDirectoryPathProviderAction = Instances.ServiceAction.AddConstructorBasedRootOutputDirectoryPathProviderAction(@"C:\Temp\Output");

            // Services platform.
            var servicesPlatformRequiredServiceActionAggregation = new ServicesPlatformRequiredServiceActionAggregation
            {
                ConfigurationAction = providedServicesAggregation.ConfigurationAction,
                ExecutionSynchronicityProviderAction = executionSynchronicityProviderAction,
                LoggerAction = providedServicesAggregation.LoggerAction,
                LoggerFactoryAction = providedServicesAggregation.LoggerFactoryAction,
                MachineMessageOutputSinkProviderActions = EnumerableHelper.Empty<IServiceAction<D0099.D002.IMachineMessageOutputSinkProvider>>(),
                MachineMessageTypeJsonSerializationHandlerActions = EnumerableHelper.Empty<IServiceAction<D0098.IMachineMessageTypeJsonSerializationHandler>>(),
                OrganizationProviderAction = organizationProviderAction,
                RootOutputDirectoryPathProviderAction = rootOutputDirectoryPathProviderAction,
            };

            var servicesPlatform = Instances.ServiceAction.AddProvidedServiceActionAggregation(
                servicesPlatformRequiredServiceActionAggregation);

            // Logging.
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder
                    .SetMinimumLevel(LogLevel.Debug)
                    .AddConsole(
                        servicesPlatform.LoggerSynchronicityProviderAction)
                    .AddFile(
                        servicesPlatform.LogFilePathProviderAction,
                        servicesPlatform.LoggerSynchronicityProviderAction)
                    ;
            });


            // Git and GitHub
            var gitHubOperatorServiceActions = Instances.ServiceAction.AddGitHubOperatorServiceActions(
                servicesPlatform.SecretsDirectoryFilePathProviderAction);
            var gitOperatorServices = Instances.ServiceAction.AddGitOperatorServices(
                gitHubOperatorServiceActions.GitHubAuthenticationProviderAction,
                servicesPlatform.SecretsDirectoryFilePathProviderAction);

            // Project repository.
            var projectRepositoryFilePathsProviderAction = Instances.ServiceAction.AddHardCodedProjectRepositoryFilePathsProviderAction();

            var fileBasedProjectRepositoryAction = Instances.ServiceAction.AddFileBasedProjectRepositoryAction(
                projectRepositoryFilePathsProviderAction);

            var projectRepositoryAction = Instances.ServiceAction.ForwardFileBasedProjectRepositoryToProjectRepositoryAction(
                fileBasedProjectRepositoryAction);


            // Visual studio.
            var dotnetOperatorActions = Instances.ServiceAction.AddDotnetOperatorActions(
                servicesPlatform.CommandLineOperatorAction,
                servicesPlatform.SecretsDirectoryFilePathProviderAction);
            var visualStudioProjectFileOperatorActions = Instances.ServiceAction.AddVisualStudioProjectFileOperatorActions(
                dotnetOperatorActions.DotnetOperatorAction,
                servicesPlatform.FileNameOperatorAction,
                servicesPlatform.StringlyTypedPathOperatorAction);
            var visualStudioProjectFileReferencesProviderAction = Instances.ServiceAction.AddVisualStudioProjectFileReferencesProviderAction(
                servicesPlatform.StringlyTypedPathOperatorAction);
            var visualStudioSolutionFileOperatorActions = Instances.ServiceAction.AddVisualStudioSolutionFileOperatorActions(
                dotnetOperatorActions.DotnetOperatorAction,
                servicesPlatform.FileNameOperatorAction,
                servicesPlatform.StringlyTypedPathOperatorAction);

            // Using directives formatter.
            var usingDirectivesFormatterActions = Instances.ServiceAction.AddUsingDirectivesFormatterActions();

            // Add services here.

            // Level 00.

            // Level 01.
            var projectFileOperatorAction = Instances.ServiceAction.AddProjectFileOperatorAction(
                visualStudioProjectFileOperatorActions.VisualStudioProjectFileOperatorAction,
                visualStudioProjectFileReferencesProviderAction); var localRepositoryContextProviderAction_N003 = Instances.ServiceAction.AddLocalRepositoryContextProviderAction(
                 gitOperatorServices.GitOperatorAction);
            var projectContextProviderAction_N006 = Instances.ServiceAction.AddProjectContextProviderAction_N006(
                servicesPlatform.StringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorActions.VisualStudioProjectFileOperatorAction,
                visualStudioProjectFileReferencesProviderAction);
            var remoteRepositoryContextProviderAction = Instances.ServiceAction.AddRemoteRepositoryContextProviderAction(
                gitHubOperatorServiceActions.GitHubOperatorAction);
            var solutionFileOperatorAction = Instances.ServiceAction.AddSolutionFileOperatorAction(
                servicesPlatform.StringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorActions.VisualStudioSolutionFileOperatorAction);
            var solutionContextProviderAction_N005 = Instances.ServiceAction.AddSolutionContextProviderAction(
                servicesPlatform.StringlyTypedPathOperatorAction,
                visualStudioProjectFileReferencesProviderAction,
                visualStudioSolutionFileOperatorActions.VisualStudioSolutionFileOperatorAction);

            // Level 02.
            var codeFileContextProviderAction = Instances.ServiceAction.AddCodeFileContextProviderAction(
                projectFileOperatorAction,
                solutionFileOperatorAction,
                usingDirectivesFormatterActions.UsingDirectivesFormatterAction);
            var localRepositoryContextProviderAction_N004 = Instances.ServiceAction.AddLocalRepositoryContextProviderAction(
                localRepositoryContextProviderAction_N003,
                remoteRepositoryContextProviderAction);
            var projectContextProviderAction_N007 = Instances.ServiceAction.AddProjectContextProviderAction_N007(
                projectContextProviderAction_N006,
                visualStudioSolutionFileOperatorActions.VisualStudioSolutionFileOperatorAction);

            // Run.
            services.MarkAsServiceCollectonConfigurationStatement()
                .Run(servicesPlatform.ConfigurationAuditSerializerAction)
                .Run(servicesPlatform.ServiceCollectionAuditSerializerAction)
                // Services
                .Run(codeFileContextProviderAction)
                .Run(localRepositoryContextProviderAction_N003)
                .Run(localRepositoryContextProviderAction_N004)
                .Run(projectContextProviderAction_N007)
                .Run(projectRepositoryAction)
                .Run(remoteRepositoryContextProviderAction)
                .Run(solutionContextProviderAction_N005)
                ;

            return Task.CompletedTask;
        }

        protected override Task FillRequiredServiceActions(IRequiredServiceActionAggregation requiredServiceActions)
        {
            // Do nothing since none are required.
        
            return Task.CompletedTask;
        }
    }
}