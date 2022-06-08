namespace minsk.CodeAnalysis.Binding
{
    internal sealed class BoundUnaryExpression : BoundExpression
    {
        public BoundUnaryExpression(BoundUnaryOperatorKind operatorKind, BoundExpression operand)
        {
            OperatorKind = operatorKind;
            Operand = operand;
        }

        public BoundUnaryOperatorKind OperatorKind { get; }
        public BoundExpression Operand { get; }

        public override Type type => Operand.type;

        public override BoundNodeKind Kind => BoundNodeKind.UnaryExpression;
    }
}