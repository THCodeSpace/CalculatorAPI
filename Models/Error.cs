/*
 * CalculatorAPI
 *
 * CalculatorAPI
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CalculatorApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Error
    { 
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [Required]

        [DataMember(Name="code")]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [Required]

        [DataMember(Name="message")]
        public string? Message { get; set; }

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
