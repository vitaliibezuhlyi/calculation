namespace CalculationLibrary.Core;

public class Calculator
{
    public int Add(params int[] numbers)
    {
        int sum = 0;
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
}