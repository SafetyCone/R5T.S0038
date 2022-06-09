using System;


namespace R5T.S0038
{
    public class SyntaxTextValues : ISyntaxTextValues
    {
        #region Infrastructure

        public static SyntaxTextValues Instance { get; } = new();

        private SyntaxTextValues()
        {
        }

        #endregion
    }
}
