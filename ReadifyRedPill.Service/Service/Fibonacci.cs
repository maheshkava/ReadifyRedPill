using System;
using System.ServiceModel;

public class Fibonacci
{
    private readonly long[] _calculatedResult;
    public Fibonacci(long n)
    {
       // if (!(-92 <= n && n <= 92))  ThrowFaultException(n);

        _calculatedResult = new long[n + 1];
    }

    public long Calculate(long number)
    {
        if (number == 0)
            return 0;
        if (number == 1)
            return 1;
        if (_calculatedResult[number] != 0)
            return _calculatedResult[number];
        try
        {
            checked //integer over flow check
            {
                _calculatedResult[number] = Calculate(number - 1) + Calculate(number - 2);
            }
        }
        catch (Exception e)
        {
            ThrowFaultException(number);
        }
      
        return _calculatedResult[number];
    }

    private static void ThrowFaultException(long number)
    {
        string reason = string.Format("Fib(>{0}) will cause a 64-bit integer overflow.", number - 1);
        var argumentException = new ArgumentOutOfRangeException(reason);
        throw new FaultException<ArgumentOutOfRangeException>(argumentException, argumentException.Message);
    }
}