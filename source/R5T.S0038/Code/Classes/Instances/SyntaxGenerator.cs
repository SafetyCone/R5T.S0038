using System;


namespace R5T.S0038
{
    public class SyntaxGenerator : ISyntaxGenerator
    {
        #region Infrastructure

        public static SyntaxGenerator Instance { get; } = new();

        private SyntaxGenerator()
        {
        }

        #endregion
    }
}
