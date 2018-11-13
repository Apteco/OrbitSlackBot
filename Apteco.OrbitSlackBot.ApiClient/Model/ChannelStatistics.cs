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
    /// Channel communication statistics
    /// </summary>
    [DataContract]
    public partial class ChannelStatistics :  IEquatable<ChannelStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStatistics" /> class.
        /// </summary>
        /// <param name="Days">The set of days where channel information is available (required).</param>
        /// <param name="PerChannelStats">A map between a channel&#39;s id and its statistics data (required).</param>
        /// <param name="TotalCommunicationsCount">The total number of communications across all channels (required).</param>
        /// <param name="TotalCost">The total cost across all channels (required).</param>
        /// <param name="StatisticsTimestamp">The date and time that the channel statistics were calculated.</param>
        public ChannelStatistics(List<string> Days = default(List<string>), Dictionary<string, PerChannelStatistics> PerChannelStats = default(Dictionary<string, PerChannelStatistics>), long? TotalCommunicationsCount = default(long?), double? TotalCost = default(double?), DateTime? StatisticsTimestamp = default(DateTime?))
        {
            // to ensure "Days" is required (not null)
            if (Days == null)
            {
                throw new InvalidDataException("Days is a required property for ChannelStatistics and cannot be null");
            }
            else
            {
                this.Days = Days;
            }
            // to ensure "PerChannelStats" is required (not null)
            if (PerChannelStats == null)
            {
                throw new InvalidDataException("PerChannelStats is a required property for ChannelStatistics and cannot be null");
            }
            else
            {
                this.PerChannelStats = PerChannelStats;
            }
            // to ensure "TotalCommunicationsCount" is required (not null)
            if (TotalCommunicationsCount == null)
            {
                throw new InvalidDataException("TotalCommunicationsCount is a required property for ChannelStatistics and cannot be null");
            }
            else
            {
                this.TotalCommunicationsCount = TotalCommunicationsCount;
            }
            // to ensure "TotalCost" is required (not null)
            if (TotalCost == null)
            {
                throw new InvalidDataException("TotalCost is a required property for ChannelStatistics and cannot be null");
            }
            else
            {
                this.TotalCost = TotalCost;
            }
            this.StatisticsTimestamp = StatisticsTimestamp;
        }
        
        /// <summary>
        /// The set of days where channel information is available
        /// </summary>
        /// <value>The set of days where channel information is available</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<string> Days { get; set; }

        /// <summary>
        /// A map between a channel&#39;s id and its statistics data
        /// </summary>
        /// <value>A map between a channel&#39;s id and its statistics data</value>
        [DataMember(Name="perChannelStats", EmitDefaultValue=false)]
        public Dictionary<string, PerChannelStatistics> PerChannelStats { get; set; }

        /// <summary>
        /// The total number of communications across all channels
        /// </summary>
        /// <value>The total number of communications across all channels</value>
        [DataMember(Name="totalCommunicationsCount", EmitDefaultValue=false)]
        public long? TotalCommunicationsCount { get; set; }

        /// <summary>
        /// The total cost across all channels
        /// </summary>
        /// <value>The total cost across all channels</value>
        [DataMember(Name="totalCost", EmitDefaultValue=false)]
        public double? TotalCost { get; set; }

        /// <summary>
        /// The date and time that the channel statistics were calculated
        /// </summary>
        /// <value>The date and time that the channel statistics were calculated</value>
        [DataMember(Name="statisticsTimestamp", EmitDefaultValue=false)]
        public DateTime? StatisticsTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelStatistics {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  PerChannelStats: ").Append(PerChannelStats).Append("\n");
            sb.Append("  TotalCommunicationsCount: ").Append(TotalCommunicationsCount).Append("\n");
            sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
            sb.Append("  StatisticsTimestamp: ").Append(StatisticsTimestamp).Append("\n");
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
            return this.Equals(input as ChannelStatistics);
        }

        /// <summary>
        /// Returns true if ChannelStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    this.Days.SequenceEqual(input.Days)
                ) && 
                (
                    this.PerChannelStats == input.PerChannelStats ||
                    this.PerChannelStats != null &&
                    this.PerChannelStats.SequenceEqual(input.PerChannelStats)
                ) && 
                (
                    this.TotalCommunicationsCount == input.TotalCommunicationsCount ||
                    (this.TotalCommunicationsCount != null &&
                    this.TotalCommunicationsCount.Equals(input.TotalCommunicationsCount))
                ) && 
                (
                    this.TotalCost == input.TotalCost ||
                    (this.TotalCost != null &&
                    this.TotalCost.Equals(input.TotalCost))
                ) && 
                (
                    this.StatisticsTimestamp == input.StatisticsTimestamp ||
                    (this.StatisticsTimestamp != null &&
                    this.StatisticsTimestamp.Equals(input.StatisticsTimestamp))
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
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
                if (this.PerChannelStats != null)
                    hashCode = hashCode * 59 + this.PerChannelStats.GetHashCode();
                if (this.TotalCommunicationsCount != null)
                    hashCode = hashCode * 59 + this.TotalCommunicationsCount.GetHashCode();
                if (this.TotalCost != null)
                    hashCode = hashCode * 59 + this.TotalCost.GetHashCode();
                if (this.StatisticsTimestamp != null)
                    hashCode = hashCode * 59 + this.StatisticsTimestamp.GetHashCode();
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
