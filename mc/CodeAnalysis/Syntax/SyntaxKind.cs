namespace minsk.CodeAnalysis.Syntax
{
    public enum SyntaxKind
    {
        // Tokens
        BadToken,
        EndOfFileToken,
        WhitespaceToken,
        NumberToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        CloseParenthesisToken,
        OpenParenthesisToken,
        
        // Expressions
        LiteralExpression,
        BinaryExpression,
        UnaryExpression,
        ParenthesizedExpression
        
    }
}