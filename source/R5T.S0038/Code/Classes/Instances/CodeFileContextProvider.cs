using System;


namespace R5T.S0038
{

    public class CodeFileContextProvider : ICodeFileContextProvider
    {
        #region Infrastructure

        public static CodeFileContextProvider Instance { get; } = new();

        private CodeFileContextProvider()
        {
        }

        #endregion
    }
}
