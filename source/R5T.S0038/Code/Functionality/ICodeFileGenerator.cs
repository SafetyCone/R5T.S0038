using System;
using System.IO;

using R5T.T0132;


namespace R5T.S0038
{
	[FunctionalityMarker]
	public partial interface ICodeFileGenerator : IFunctionalityMarker
	{
		public void CreateDocumentationFile(
			string filePath,
			string namespaceName,
			string documentationText)
        {
			var text =
$@"
using System;


namespace {namespaceName}
{{
	/// <summary>
	/// {documentationText}
	/// </summary>
	public static class Documentation
	{{
	}}
}}
";
			this.WriteText(
				filePath,
				text);
        }

		public void CreateInstancesFile(
			string filePath,
			string namespaceName)
        {
			var text =
$@"
using System;


namespace {namespaceName}
{{
    public static class Instances
    {{
		
    }}
}}
";

			this.WriteText(
				filePath,
				text);
        }

		public void CreateProgramFile(
			string filePath,
			string namespaceName)
        {
			var text =
$@"
using System;


namespace {namespaceName}
{{
    class Program
    {{
        static void Main()
        {{
            Console.WriteLine(""Hello World!"");
        }}
    }}
}}
";
			this.WriteText(
				filePath,
				text);
        }

		public void WriteText(
			string filePath,
			string text)
        {
			var outputText = text.Trim();

			File.WriteAllText(
				filePath,
				outputText);
		}
	}
}