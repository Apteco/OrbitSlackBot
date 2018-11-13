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
    /// JsonPatchDocumentUpsertUserCollectionDetail
    /// </summary>
    [DataContract]
    public partial class JsonPatchDocumentUpsertUserCollectionDetail :  IEquatable<JsonPatchDocumentUpsertUserCollectionDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPatchDocumentUpsertUserCollectionDetail" /> class.
        /// </summary>
        /// <param name="Operations">Operations.</param>
        public JsonPatchDocumentUpsertUserCollectionDetail(List<OperationUpsertUserCollectionDetail> Operations = default(List<OperationUpsertUserCollectionDetail>))
        {
            this.Operations = Operations;
        }
        
        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name="operations", EmitDefaultValue=false)]
        public List<OperationUpsertUserCollectionDetail> Operations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonPatchDocumentUpsertUserCollectionDetail {\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
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
            return this.Equals(input as JsonPatchDocumentUpsertUserCollectionDetail);
        }

        /// <summary>
        /// Returns true if JsonPatchDocumentUpsertUserCollectionDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonPatchDocumentUpsertUserCollectionDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonPatchDocumentUpsertUserCollectionDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
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
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
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
