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
    /// The summary information for a particular category of static resources
    /// </summary>
    [DataContract]
    public partial class ResourceCategorySummary :  IEquatable<ResourceCategorySummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCategorySummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceCategorySummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCategorySummary" /> class.
        /// </summary>
        /// <param name="Name">The name of the resource category (required).</param>
        /// <param name="Description">The description of the resource category (required).</param>
        public ResourceCategorySummary(string Name = default(string), string Description = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ResourceCategorySummary and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ResourceCategorySummary and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
        }
        
        /// <summary>
        /// The name of the resource category
        /// </summary>
        /// <value>The name of the resource category</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the resource category
        /// </summary>
        /// <value>The description of the resource category</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceCategorySummary {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ResourceCategorySummary);
        }

        /// <summary>
        /// Returns true if ResourceCategorySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceCategorySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceCategorySummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
