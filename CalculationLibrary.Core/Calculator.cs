namespace CalculationLibrary.Core;

public class Calculator
{
    public double Add(params double[] numbers)
    {
        double sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    public int Subtract(params int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        var result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result -= numbers[i];
        }

        return result;
    }

    public int Multiply(params int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }

        var result = 1;
        foreach (var number in numbers)
        {
            result *= number;
        }

        return result;
    }

    public double Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Divisor cannot be zero.");
        }

        return (double)dividend / divisor;
    }

    public double Power(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }
}