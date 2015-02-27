using System;
using System.Linq;
using System.ServiceModel;
using System.Web.Services.Protocols;

namespace RedPillClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new BasicHttpBinding_IRedPill();
            var str = client.WhatIsYourToken();
            Console.WriteLine("My token: " + str);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
            long result = 0;
            bool boolResult = false;
           
            Fib(client, 10, ref result, ref boolResult);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            WhatShapeIsThis(client, 1, 1, 1);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
            return;
       
        }

        private static void WhatShapeIsThis(BasicHttpBinding_IRedPill client, int a, int b, int c)
        {
            TriangleType result;
            bool boolResult;
            client.WhatShapeIsThis(a, true, b, true, c, true, out result, out boolResult);
           // Console.WriteLine(result == resultT);
            Console.WriteLine("Shape for Triangle with sides " + a +"," + b +"," + c +": " + result);
        }

 
        private static void Fib(BasicHttpBinding_IRedPill client,long number, ref long result, ref bool boolResult)
        {
            try
            {
                client.FibonacciNumber(number, true, out result, out boolResult);
                Console.WriteLine("Fib("+number+"): "+  result);
            }
            catch (SoapException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
