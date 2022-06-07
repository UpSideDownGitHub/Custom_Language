namespace minsk.CodeAnalysis
{
    sealed class ParenthesizedExpressionSyntax : ExpressionSyntax
    {

        public ParenthesizedExpressionSyntax(SyntaxToken openParenthesisToken, ExpressionSyntax expression, SyntaxToken closeParenthesisToken)
        {
            this.OpenParenthesisToken = openParenthesisToken;
            this.Expression = expression;
            this.CloseParenthesisToken = closeParenthesisToken;
            
        }
        public SyntaxToken CloseParenthesisToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken OpenParenthesisToken { get; }

        public override SyntaxKind Kind => SyntaxKind.ParenthesizedExpression;

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return OpenParenthesisToken;
            yield return Expression;
            yield return CloseParenthesisToken;
        }
    }
}