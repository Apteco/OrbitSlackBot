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
    /// Details about the creation of a new collection share update
    /// </summary>
    [DataContract]
    public partial class CreatedCollectionShareUpdateDetail :  IEquatable<CreatedCollectionShareUpdateDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedCollectionShareUpdateDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatedCollectionShareUpdateDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedCollectionShareUpdateDetail" /> class.
        /// </summary>
        /// <param name="CollectionShareUpdate">The details of the newly created collection share update (required).</param>
        /// <param name="InvalidUsersToAdd">Details of the users that were specified to be added to the collection  share in the update, but that were not valid users to be shared to (required).</param>
        /// <param name="InvalidUsersToRemove">Details of the users that were specified to be removed from the collection  share in the update, but that were not valid users to be removed from  sharing the collection (required).</param>
        public CreatedCollectionShareUpdateDetail(CollectionShareUpdate CollectionShareUpdate = default(CollectionShareUpdate), List<InvalidToShareUserDisplayDetails> InvalidUsersToAdd = default(List<InvalidToShareUserDisplayDetails>), List<InvalidToShareUserDisplayDetails> InvalidUsersToRemove = default(List<InvalidToShareUserDisplayDetails>))
        {
            // to ensure "CollectionShareUpdate" is required (not null)
            if (CollectionShareUpdate == null)
            {
                throw new InvalidDataException("CollectionShareUpdate is a required property for CreatedCollectionShareUpdateDetail and cannot be null");
            }
            else
            {
                this.CollectionShareUpdate = CollectionShareUpdate;
            }
            // to ensure "InvalidUsersToAdd" is required (not null)
            if (InvalidUsersToAdd == null)
            {
                throw new InvalidDataException("InvalidUsersToAdd is a required property for CreatedCollectionShareUpdateDetail and cannot be null");
            }
            else
            {
                this.InvalidUsersToAdd = InvalidUsersToAdd;
            }
            // to ensure "InvalidUsersToRemove" is required (not null)
            if (InvalidUsersToRemove == null)
            {
                throw new InvalidDataException("InvalidUsersToRemove is a required property for CreatedCollectionShareUpdateDetail and cannot be null");
            }
            else
            {
                this.InvalidUsersToRemove = InvalidUsersToRemove;
            }
        }
        
        /// <summary>
        /// The details of the newly created collection share update
        /// </summary>
        /// <value>The details of the newly created collection share update</value>
        [DataMember(Name="collectionShareUpdate", EmitDefaultValue=false)]
        public CollectionShareUpdate CollectionShareUpdate { get; set; }

        /// <summary>
        /// Details of the users that were specified to be added to the collection  share in the update, but that were not valid users to be shared to
        /// </summary>
        /// <value>Details of the users that were specified to be added to the collection  share in the update, but that were not valid users to be shared to</value>
        [DataMember(Name="invalidUsersToAdd", EmitDefaultValue=false)]
        public List<InvalidToShareUserDisplayDetails> InvalidUsersToAdd { get; set; }

        /// <summary>
        /// Details of the users that were specified to be removed from the collection  share in the update, but that were not valid users to be removed from  sharing the collection
        /// </summary>
        /// <value>Details of the users that were specified to be removed from the collection  share in the update, but that were not valid users to be removed from  sharing the collection</value>
        [DataMember(Name="invalidUsersToRemove", EmitDefaultValue=false)]
        public List<InvalidToShareUserDisplayDetails> InvalidUsersToRemove { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatedCollectionShareUpdateDetail {\n");
            sb.Append("  CollectionShareUpdate: ").Append(CollectionShareUpdate).Append("\n");
            sb.Append("  InvalidUsersToAdd: ").Append(InvalidUsersToAdd).Append("\n");
            sb.Append("  InvalidUsersToRemove: ").Append(InvalidUsersToRemove).Append("\n");
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
            return this.Equals(input as CreatedCollectionShareUpdateDetail);
        }

        /// <summary>
        /// Returns true if CreatedCollectionShareUpdateDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatedCollectionShareUpdateDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatedCollectionShareUpdateDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectionShareUpdate == input.CollectionShareUpdate ||
                    (this.CollectionShareUpdate != null &&
                    this.CollectionShareUpdate.Equals(input.CollectionShareUpdate))
                ) && 
                (
                    this.InvalidUsersToAdd == input.InvalidUsersToAdd ||
                    this.InvalidUsersToAdd != null &&
                    this.InvalidUsersToAdd.SequenceEqual(input.InvalidUsersToAdd)
                ) && 
                (
                    this.InvalidUsersToRemove == input.InvalidUsersToRemove ||
                    this.InvalidUsersToRemove != null &&
                    this.InvalidUsersToRemove.SequenceEqual(input.InvalidUsersToRemove)
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
                if (this.CollectionShareUpdate != null)
                    hashCode = hashCode * 59 + this.CollectionShareUpdate.GetHashCode();
                if (this.InvalidUsersToAdd != null)
                    hashCode = hashCode * 59 + this.InvalidUsersToAdd.GetHashCode();
                if (this.InvalidUsersToRemove != null)
                    hashCode = hashCode * 59 + this.InvalidUsersToRemove.GetHashCode();
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
