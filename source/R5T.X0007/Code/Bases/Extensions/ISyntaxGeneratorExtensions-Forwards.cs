using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;


namespace R5T.N0001.Generation.Initial.Simple
{
    public static partial class ISyntaxGeneratorExtensions
    {
        internal static CompilationUnitSyntax CompilationUnit_Simple(this ISyntaxGenerator _)
        {
            var output = _.CompilationUnit();
            return output;
        }
    }
}
