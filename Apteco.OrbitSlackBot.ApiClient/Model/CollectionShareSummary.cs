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
    /// Summary details for how a collection is shared
    /// </summary>
    [DataContract]
    public partial class CollectionShareSummary :  IEquatable<CollectionShareSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionShareSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionShareSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionShareSummary" /> class.
        /// </summary>
        /// <param name="Id">The id of the share (required).</param>
        /// <param name="CollectionId">The id of the collection being shared (required).</param>
        /// <param name="CollectionTitle">The title of the collection being shared (required).</param>
        /// <param name="NumberOfUsersSharedWith">The number of people the collection has been shared with (required).</param>
        public CollectionShareSummary(int? Id = default(int?), int? CollectionId = default(int?), string CollectionTitle = default(string), int? NumberOfUsersSharedWith = default(int?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CollectionShareSummary and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CollectionId" is required (not null)
            if (CollectionId == null)
            {
                throw new InvalidDataException("CollectionId is a required property for CollectionShareSummary and cannot be null");
            }
            else
            {
                this.CollectionId = CollectionId;
            }
            // to ensure "CollectionTitle" is required (not null)
            if (CollectionTitle == null)
            {
                throw new InvalidDataException("CollectionTitle is a required property for CollectionShareSummary and cannot be null");
            }
            else
            {
                this.CollectionTitle = CollectionTitle;
            }
            // to ensure "NumberOfUsersSharedWith" is required (not null)
            if (NumberOfUsersSharedWith == null)
            {
                throw new InvalidDataException("NumberOfUsersSharedWith is a required property for CollectionShareSummary and cannot be null");
            }
            else
            {
                this.NumberOfUsersSharedWith = NumberOfUsersSharedWith;
            }
        }
        
        /// <summary>
        /// The id of the share
        /// </summary>
        /// <value>The id of the share</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The id of the collection being shared
        /// </summary>
        /// <value>The id of the collection being shared</value>
        [DataMember(Name="collectionId", EmitDefaultValue=false)]
        public int? CollectionId { get; set; }

        /// <summary>
        /// The title of the collection being shared
        /// </summary>
        /// <value>The title of the collection being shared</value>
        [DataMember(Name="collectionTitle", EmitDefaultValue=false)]
        public string CollectionTitle { get; set; }

        /// <summary>
        /// The number of people the collection has been shared with
        /// </summary>
        /// <value>The number of people the collection has been shared with</value>
        [DataMember(Name="numberOfUsersSharedWith", EmitDefaultValue=false)]
        public int? NumberOfUsersSharedWith { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionShareSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  CollectionTitle: ").Append(CollectionTitle).Append("\n");
            sb.Append("  NumberOfUsersSharedWith: ").Append(NumberOfUsersSharedWith).Append("\n");
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
            return this.Equals(input as CollectionShareSummary);
        }

        /// <summary>
        /// Returns true if CollectionShareSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionShareSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionShareSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.CollectionTitle == input.CollectionTitle ||
                    (this.CollectionTitle != null &&
                    this.CollectionTitle.Equals(input.CollectionTitle))
                ) && 
                (
                    this.NumberOfUsersSharedWith == input.NumberOfUsersSharedWith ||
                    (this.NumberOfUsersSharedWith != null &&
                    this.NumberOfUsersSharedWith.Equals(input.NumberOfUsersSharedWith))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.CollectionTitle != null)
                    hashCode = hashCode * 59 + this.CollectionTitle.GetHashCode();
                if (this.NumberOfUsersSharedWith != null)
                    hashCode = hashCode * 59 + this.NumberOfUsersSharedWith.GetHashCode();
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
