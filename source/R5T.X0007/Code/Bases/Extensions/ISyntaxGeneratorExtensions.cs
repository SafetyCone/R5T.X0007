using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using R5T.N0001.Generation.Initial.Simple;


namespace System
{
    public static partial class ISyntaxGeneratorExtensions
    {
        public static CompilationUnitSyntax CompilationUnit(this ISyntaxGenerator _)
        {
            return _.CompilationUnit_Simple();
        }
    }
}
