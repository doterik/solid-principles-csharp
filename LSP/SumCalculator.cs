namespace LSP;

public class SumCalculator(int[] numbers) : Calculator(numbers)
{
    public override int Calculate() => _numbers.Sum();
}
