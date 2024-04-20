#pragma warning disable IDE1006 // Naming Styles.
#pragma warning disable SA1309  // Field names should not begin with underscore.
#pragma warning disable SA1401  // Fields should be private.

namespace LSP;

public abstract class Calculator(int[] numbers)
{
    private protected readonly int[] _numbers = numbers;

    public abstract int Calculate();
}
