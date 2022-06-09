using System;

using R5T.Lombardy;

using R5T.D0078;
using R5T.D0079;
using R5T.D0083;
using R5T.T0062;
using R5T.T0063;

using N006 = R5T.T0139.N006;
using N007 = R5T.T0139.N007;


namespace R5T.S0038
{
    public static partial class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="N006.ProjectContextProvider"/> implementation of <see cref="N006.IProjectContextProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<N006.IProjectContextProvider> AddProjectContextProviderAction_N006(this IServiceAction _,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioProjectFileOperator> visualStudioProjectFileOperatorAction,
            IServiceAction<IVisualStudioProjectFileReferencesProvider> VisualStudioProjectFileReferencesProviderAction)
        {
            var serviceAction = N006.IServiceActionExtensions.AddProjectContextProviderAction(_,
                stringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorAction,
                VisualStudioProjectFileReferencesProviderAction);

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="N007.ProjectContextProvider"/> implementation of <see cref="N007.IProjectContextProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<N007.IProjectContextProvider> AddProjectContextProviderAction_N007(this IServiceAction _,
            IServiceAction<N006.IProjectContextProvider> projectContextProvider_N006Action,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            var serviceAction = N007.IServiceActionExtensions.AddProjectContextProviderAction(_,
                projectContextProvider_N006Action,
                visualStudioSolutionFileOperatorAction);

            return serviceAction;
        }
    }
}