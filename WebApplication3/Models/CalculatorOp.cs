using System.Runtime.Serialization;

namespace WebApplication3.Models
{
    [DataContract]
    public class CalculatorOp
    {

        
            
            [DataMember]    
            public int firstoperand { get; set; }
            [DataMember]
            public int secondoperand { get; set; }
            
        
    }
}
