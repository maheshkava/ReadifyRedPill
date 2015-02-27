using System.Runtime.Serialization;

[DataContract(Namespace = "http://KnockKnock.readify.net")]
public enum TriangleType : int
{
    [EnumMember]
    Error = 0,
    [EnumMember]
    Equilateral = 1,
    [EnumMember]
    Isosceles = 2,
    [EnumMember]
    Scalene = 3,
}