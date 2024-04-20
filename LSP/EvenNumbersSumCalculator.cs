namespace LSP;

public class EvenNumbersSumCalculator(int[] numbers) : Calculator(numbers)
{
    public override int Calculate() => _numbers.Where(x => x % 2 is 0).Sum();
}
