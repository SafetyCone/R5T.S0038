using System;

using R5T.T0131;


namespace R5T.S0038
{
	[ValuesMarker]
	public partial interface IProjectDirectoryRelativePath : IValuesMarker,
		Z0007.IProjectDirectoryRelativePath
	{
        public string Demonstrations_Draft_Classes_Directory => @"Code\Examinations\Demonstrations-Draft\Classes";
        public string Demonstrations_Classes_Directory => @"Code\Examinations\Demonstrations\Classes";
        public string Experiments_Draft_Classes_Directory => @"Code\Examinations\Experiments-Draft\Classes";
        public string Experiments_Classes_Directory => @"Code\Examinations\Experiments\Classes";
        public string Explorations_Draft_Classes_Directory => @"Code\Examinations\Explorations-Draft\Classes";
        public string Explorations_Classes_Directory => @"Code\Examinations\Explorations\Classes";
        public string Functionality_Draft_Classes_Directory => @"Code\Functionality-Draft\Classes";
        public string Functionality_Classes_Directory => @"Code\Functionality\Classes";
        public string Values_Draft_Classes_Directory => @"Code\Values-Draft\Classes";
        public string Values_Classes_Directory => @"Code\Values\Classes";
    }
}