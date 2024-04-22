using System.Runtime.Serialization;

namespace soap_api_calc.Models
{
    [DataContract]
    public class MathOperationRequest
    {
        [DataMember]
        public double Operand1 { get; set; }

        [DataMember]
        public double Operand2 { get; set; }
    }
}
