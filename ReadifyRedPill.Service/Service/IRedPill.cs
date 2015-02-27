using System;
using System.ServiceModel;
namespace ReadifyRedPill.Service
{

    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        Guid WhatIsYourToken();
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        [OperationContract]
        long FibonacciNumber(long n);
        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);
        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        string ReverseWords(string s);
    }
}