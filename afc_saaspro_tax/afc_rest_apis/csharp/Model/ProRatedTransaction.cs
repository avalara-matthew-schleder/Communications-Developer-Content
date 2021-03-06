using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.Comms.Rest.Sample.Model
{
    /// <summary>
    /// Parameter for pro-rated tax calculation API.
    /// </summary>
    [DataContract]
    public partial class ProRatedTransaction
    {
        /// <summary>
        /// Percentage to prorate specified as a decimal.
        /// </summary>
        [DataMember(Name="ProRatedPercent", EmitDefaultValue=false)]
        public double? ProRatedPercent { get; set; }

        /// <summary>
        /// Transaction data.
        /// </summary>
        [DataMember(Name="Transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
