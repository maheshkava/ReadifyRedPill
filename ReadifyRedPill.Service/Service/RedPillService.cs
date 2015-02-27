using System;
using System.ServiceModel;
namespace ReadifyRedPill.Service
{
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class RedPillService : IRedPill
    {

        public long FibonacciNumber(long n)
        {
            var initalize = n < 0 ? -1 : 1;
            var result = new Fibonacci(n * initalize).Calculate(n * initalize);
            return initalize == -1 && n % 2 == 0 ? initalize * result : result;
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return new Shape().WhatShapeIsThis(a, b, c);
        }

        public string ReverseWords(string s)
        {
            var argumentException = new ArgumentNullException("s", "Value cannot be null");
            if (s == null) throw new FaultException<ArgumentNullException>(argumentException, argumentException.Message);
            return new Word().ReverseWords(s);
        }

        public Guid WhatIsYourToken()
        {
            return Guid.Parse("d83be0f9-76b5-448b-bb0c-820687a83d62");
            //return Guid.Empty;
        }
    }
}