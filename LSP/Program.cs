﻿/* https://code-maze.com/liskov-substitution-principle */

using LSP;

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

Calculator sum = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}"); // 40

Console.WriteLine();

Calculator evenSum = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}"); // 18
