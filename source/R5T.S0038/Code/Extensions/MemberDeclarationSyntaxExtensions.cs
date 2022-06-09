extern alias R5T_X0016;


using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0134;


namespace R5T.S0038
{
    public static class MemberDeclarationSyntaxExtensions
    {
        public static AddNodeResult<T, AttributeSyntax> AddAttribute<T>(this T member,
            AttributeSyntax attribute)
            where T : MemberDeclarationSyntax
        {
            return R5T_X0016.System.MemberDeclarationSyntaxExtensions.AddAttribute(
                member,
                attribute);
        }

        public static AddTokenResult<T> MakePublic<T>(this T member)
            where T : MemberDeclarationSyntax
        {
            return R5T_X0016.System.MemberDeclarationSyntaxExtensions.MakePublicWithResult(
                member);
        }
    }
}
