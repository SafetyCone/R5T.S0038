using System;

using R5T.T0131;


namespace R5T.S0038
{
    [DraftValuesMarker]
    public interface ISyntaxTextValues : IDraftValuesMarker
    {
        public string UsingSystemNamespace()
        {
            return "using System;";
        }
    }
}
