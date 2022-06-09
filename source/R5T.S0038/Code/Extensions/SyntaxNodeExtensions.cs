extern alias R5T_F0021;


using System;

using Microsoft.CodeAnalysis;


namespace R5T.S0038
{
    public static class SyntaxNodeExtensions
    {
        public static TNode PrependNewLine<TNode>(this TNode node)
            where TNode : SyntaxNode
        {
            return R5T_F0021.System.SyntaxNodeExtensions.PrependNewLine(node);
        }
    }
}
