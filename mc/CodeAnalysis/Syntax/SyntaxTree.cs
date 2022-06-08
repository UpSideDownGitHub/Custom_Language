namespace minsk.CodeAnalysis
{
    public sealed class SyntaxTree
    { 
        public SyntaxTree(IEnumerable<string> diagnostics, ExpressionSyntax root, SyntaxToken endOfFileToken)
        {
            this.Diagnostics = diagnostics.ToArray();
            this.Root = root;
            this.EndOfFileToken = endOfFileToken;

        }

        public SyntaxToken EndOfFileToken { get; }
        public ExpressionSyntax Root { get; }
        public IReadOnlyList<string> Diagnostics { get; set; }

        public static SyntaxTree Parse(string text)
        {
            var parser = new Parser(text);
            return parser.Parse();
        }
    }
}