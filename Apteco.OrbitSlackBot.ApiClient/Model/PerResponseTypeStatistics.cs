/* 
 * FastStats API
 *
 * An API to allow access to FastStats resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Apteco.OrbitSlackBot.ApiClient.Client.SwaggerDateConverter;

namespace Apteco.OrbitSlackBot.ApiClient.Model
{
    /// <summary>
    /// Per-response type response data
    /// </summary>
    [DataContract]
    public partial class PerResponseTypeStatistics :  IEquatable<PerResponseTypeStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerResponseTypeStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerResponseTypeStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerResponseTypeStatistics" /> class.
        /// </summary>
        /// <param name="PerChannelStatisticsMap">A map between a channel&#39;s id and its response statistics data (required).</param>
        /// <param name="TotalResponsesCount">The total number of responses for the given response type (required).</param>
        public PerResponseTypeStatistics(Dictionary<string, PerResponseTypePerChannelStatistics> PerChannelStatisticsMap = default(Dictionary<string, PerResponseTypePerChannelStatistics>), long? TotalResponsesCount = default(long?))
        {
            // to ensure "PerChannelStatisticsMap" is required (not null)
            if (PerChannelStatisticsMap == null)
            {
                throw new InvalidDataException("PerChannelStatisticsMap is a required property for PerResponseTypeStatistics and cannot be null");
            }
            else
            {
                this.PerChannelStatisticsMap = PerChannelStatisticsMap;
            }
            // to ensure "TotalResponsesCount" is required (not null)
            if (TotalResponsesCount == null)
            {
                throw new InvalidDataException("TotalResponsesCount is a required property for PerResponseTypeStatistics and cannot be null");
            }
            else
            {
                this.TotalResponsesCount = TotalResponsesCount;
            }
        }
        
        /// <summary>
        /// A map between a channel&#39;s id and its response statistics data
        /// </summary>
        /// <value>A map between a channel&#39;s id and its response statistics data</value>
        [DataMember(Name="perChannelStatisticsMap", EmitDefaultValue=false)]
        public Dictionary<string, PerResponseTypePerChannelStatistics> PerChannelStatisticsMap { get; set; }

        /// <summary>
        /// The total number of responses for the given response type
        /// </summary>
        /// <value>The total number of responses for the given response type</value>
        [DataMember(Name="totalResponsesCount", EmitDefaultValue=false)]
        public long? TotalResponsesCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerResponseTypeStatistics {\n");
            sb.Append("  PerChannelStatisticsMap: ").Append(PerChannelStatisticsMap).Append("\n");
            sb.Append("  TotalResponsesCount: ").Append(TotalResponsesCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PerResponseTypeStatistics);
        }

        /// <summary>
        /// Returns true if PerResponseTypeStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of PerResponseTypeStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerResponseTypeStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PerChannelStatisticsMap == input.PerChannelStatisticsMap ||
                    this.PerChannelStatisticsMap != null &&
                    this.PerChannelStatisticsMap.SequenceEqual(input.PerChannelStatisticsMap)
                ) && 
                (
                    this.TotalResponsesCount == input.TotalResponsesCount ||
                    (this.TotalResponsesCount != null &&
                    this.TotalResponsesCount.Equals(input.TotalResponsesCount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PerChannelStatisticsMap != null)
                    hashCode = hashCode * 59 + this.PerChannelStatisticsMap.GetHashCode();
                if (this.TotalResponsesCount != null)
                    hashCode = hashCode * 59 + this.TotalResponsesCount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
