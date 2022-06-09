using System;


namespace R5T.S0038
{
    public class ProjectIdentityStrings : IProjectIdentityStrings
    {
        #region Infrastructure

        public static ProjectIdentityStrings Instance { get; } = new();

        private ProjectIdentityStrings()
        {
        }

        #endregion
    }
}
