using System.Numerics;

namespace Brutal.Numerics;

public interface IArithmeticOperators<TSelf, TOther, TResult>
    : IAdditionOperators<TSelf, TOther, TResult>,
        ISubtractionOperators<TSelf, TOther, TResult>,
        IMultiplyOperators<TSelf, TOther, TResult>,
        IDivisionOperators<TSelf, TOther, TResult>
    where TSelf : IArithmeticOperators<TSelf, TOther, TResult>?;

public interface IAssociativeArithmeticOperators<TSelf, TOther, TResult> : IArithmeticOperators<TSelf, TOther, TResult>
    where TSelf : IAssociativeArithmeticOperators<TSelf, TOther, TResult>?
{
    static abstract TResult operator +(TOther left, TSelf right);

    static abstract TResult operator -(TOther left, TSelf right);

    static abstract TResult operator *(TOther left, TSelf right);

    static abstract TResult operator /(TOther left, TSelf right);

#pragma warning disable CS8604 // Possible null reference argument.
    static virtual TResult operator checked +(TOther left, TSelf right) => unchecked(left + right);

    static virtual TResult operator checked -(TOther left, TSelf right) => unchecked(left - right);

    static virtual TResult operator checked *(TOther left, TSelf right) => unchecked(left * right);

    static virtual TResult operator checked /(TOther left, TSelf right) => unchecked(left / right);
#pragma warning restore CS8604 // Possible null reference argument.
}
