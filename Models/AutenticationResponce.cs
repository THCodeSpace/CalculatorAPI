/*
 * CalculatorAPI
 *
 * CalculatorAPI
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace CalculatorApi.Models
{
    /// <summary>
    /// Calculator Responce Model
    /// </summary>
    [DataContract]
    public partial class AutenticationResponce
    { 
        /// <summary>
        /// JWT Bearer Token
        /// </summary>
        /// <value>JWT Bearer Token</value>

        [DataMember(Name="token")]
        public required string Token { get; set; }

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