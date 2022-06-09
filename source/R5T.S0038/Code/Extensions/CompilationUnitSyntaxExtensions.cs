extern alias R5T_X0012;

using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0134;


namespace R5T.S0038
{
    public static class CompilationUnitSyntaxExtensions
    {
        public static AddNodeResult<CompilationUnitSyntax, NamespaceDeclarationSyntax> AddNamespace(this CompilationUnitSyntax compilationUnit,
            NamespaceDeclarationSyntax @namespace)
        {
            return R5T_X0012::System.CompilationUnitSyntaxExtensions.AddNamespace(
                compilationUnit,
                @namespace);
        }

        public static CompilationUnitSyntax AddNamespace(this CompilationUnitSyntax compilationUnit,
            NamespaceDeclarationSyntax @namespace,
            out ISyntaxNodeAnnotation<NamespaceDeclarationSyntax> namespaceAnnotation)
        {
            return R5T_X0012::System.CompilationUnitSyntaxExtensions.AddNamespace(
                compilationUnit,
                @namespace,
                out namespaceAnnotation);
        }

        public static AddNodeResult<CompilationUnitSyntax, UsingDirectiveSyntax> AddUsingDirective(this CompilationUnitSyntax compilationUnit,
            UsingDirectiveSyntax usingDirective)
        {
            return R5T_X0012::System.CompilationUnitSyntaxExtensions.AddUsingDirective(
                compilationUnit,
                usingDirective);
        }

        public static CompilationUnitSyntax AddUsingDirective(this CompilationUnitSyntax compilationUnit,
            UsingDirectiveSyntax usingDirective,
            out ISyntaxNodeAnnotation<UsingDirectiveSyntax> usingDirectiveAnnotation)
        {
            return R5T_X0012::System.CompilationUnitSyntaxExtensions.AddUsingDirective(
                compilationUnit,
                usingDirective,
                out usingDirectiveAnnotation);
        }
    }
}
