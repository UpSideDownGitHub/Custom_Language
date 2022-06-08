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
        IdentifierToken,
        PipePipeToken,
        AmpersandAmersandToken,
        BangToken,
        BangEqualToken,
        EqualsEqualsToken,

        // Keywords
        FalseKeyword,
        TrueKeyword,

        // Expressions
        LiteralExpression,
        BinaryExpression,
        UnaryExpression,
        ParenthesizedExpression

    }
}