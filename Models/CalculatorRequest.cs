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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace CalculatorApi.Models
{
    /// <summary>
    /// Calculator Request Model
    /// </summary>
    [DataContract]
    public partial class CalculatorRequest 
    { 
        /// <summary>
        /// The first number
        /// </summary>
        /// <value>The first number</value>
        [Required]

        [DataMember(Name="num1")]
        public decimal Num1 { get; set; }

        /// <summary>
        /// The second number
        /// </summary>
        /// <value>The second number</value>
        [Required]

        [DataMember(Name="num2")]
        public decimal Num2 { get; set; }
               
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
