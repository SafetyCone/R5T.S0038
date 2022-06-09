using System;


namespace R5T.S0038
{
    public class RemoteRepositoryFunctionality : IRemoteRepositoryFunctionality
    {
        #region Infrastructure

        public static RemoteRepositoryFunctionality Instance { get; } = new();

        private RemoteRepositoryFunctionality()
        {
        }

        #endregion
    }
}
