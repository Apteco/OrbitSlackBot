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
    /// Details for a particular update that happened to a share
    /// </summary>
    [DataContract]
    public partial class CollectionShareUpdate :  IEquatable<CollectionShareUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionShareUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionShareUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionShareUpdate" /> class.
        /// </summary>
        /// <param name="Id">The id of the update (required).</param>
        /// <param name="Timestamp">The timestamp of when the update happened (required).</param>
        /// <param name="User">The user that initiated this share update (required).</param>
        /// <param name="Notes">The notes associated with this share update (required).</param>
        /// <param name="NumberOfAddedUsers">The number of users that were added to this share as part of this update (required).</param>
        /// <param name="FirstAddedUser">The first of the users that were added to this share as part of this update (required).</param>
        /// <param name="NumberOfRemovedUsers">The number of users that were removed from this share as part of this update (required).</param>
        /// <param name="FirstRemovedUser">The first of the users that were removed from this share as part of this update (required).</param>
        public CollectionShareUpdate(int? Id = default(int?), DateTime? Timestamp = default(DateTime?), UserDisplayDetails User = default(UserDisplayDetails), string Notes = default(string), int? NumberOfAddedUsers = default(int?), UserDisplayDetails FirstAddedUser = default(UserDisplayDetails), int? NumberOfRemovedUsers = default(int?), UserDisplayDetails FirstRemovedUser = default(UserDisplayDetails))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.User = User;
            }
            // to ensure "Notes" is required (not null)
            if (Notes == null)
            {
                throw new InvalidDataException("Notes is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.Notes = Notes;
            }
            // to ensure "NumberOfAddedUsers" is required (not null)
            if (NumberOfAddedUsers == null)
            {
                throw new InvalidDataException("NumberOfAddedUsers is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.NumberOfAddedUsers = NumberOfAddedUsers;
            }
            // to ensure "FirstAddedUser" is required (not null)
            if (FirstAddedUser == null)
            {
                throw new InvalidDataException("FirstAddedUser is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.FirstAddedUser = FirstAddedUser;
            }
            // to ensure "NumberOfRemovedUsers" is required (not null)
            if (NumberOfRemovedUsers == null)
            {
                throw new InvalidDataException("NumberOfRemovedUsers is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.NumberOfRemovedUsers = NumberOfRemovedUsers;
            }
            // to ensure "FirstRemovedUser" is required (not null)
            if (FirstRemovedUser == null)
            {
                throw new InvalidDataException("FirstRemovedUser is a required property for CollectionShareUpdate and cannot be null");
            }
            else
            {
                this.FirstRemovedUser = FirstRemovedUser;
            }
        }
        
        /// <summary>
        /// The id of the update
        /// </summary>
        /// <value>The id of the update</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The timestamp of when the update happened
        /// </summary>
        /// <value>The timestamp of when the update happened</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The user that initiated this share update
        /// </summary>
        /// <value>The user that initiated this share update</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserDisplayDetails User { get; set; }

        /// <summary>
        /// The notes associated with this share update
        /// </summary>
        /// <value>The notes associated with this share update</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// The number of users that were added to this share as part of this update
        /// </summary>
        /// <value>The number of users that were added to this share as part of this update</value>
        [DataMember(Name="numberOfAddedUsers", EmitDefaultValue=false)]
        public int? NumberOfAddedUsers { get; set; }

        /// <summary>
        /// The first of the users that were added to this share as part of this update
        /// </summary>
        /// <value>The first of the users that were added to this share as part of this update</value>
        [DataMember(Name="firstAddedUser", EmitDefaultValue=false)]
        public UserDisplayDetails FirstAddedUser { get; set; }

        /// <summary>
        /// The number of users that were removed from this share as part of this update
        /// </summary>
        /// <value>The number of users that were removed from this share as part of this update</value>
        [DataMember(Name="numberOfRemovedUsers", EmitDefaultValue=false)]
        public int? NumberOfRemovedUsers { get; set; }

        /// <summary>
        /// The first of the users that were removed from this share as part of this update
        /// </summary>
        /// <value>The first of the users that were removed from this share as part of this update</value>
        [DataMember(Name="firstRemovedUser", EmitDefaultValue=false)]
        public UserDisplayDetails FirstRemovedUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionShareUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  NumberOfAddedUsers: ").Append(NumberOfAddedUsers).Append("\n");
            sb.Append("  FirstAddedUser: ").Append(FirstAddedUser).Append("\n");
            sb.Append("  NumberOfRemovedUsers: ").Append(NumberOfRemovedUsers).Append("\n");
            sb.Append("  FirstRemovedUser: ").Append(FirstRemovedUser).Append("\n");
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
            return this.Equals(input as CollectionShareUpdate);
        }

        /// <summary>
        /// Returns true if CollectionShareUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionShareUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionShareUpdate input)
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
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.NumberOfAddedUsers == input.NumberOfAddedUsers ||
                    (this.NumberOfAddedUsers != null &&
                    this.NumberOfAddedUsers.Equals(input.NumberOfAddedUsers))
                ) && 
                (
                    this.FirstAddedUser == input.FirstAddedUser ||
                    (this.FirstAddedUser != null &&
                    this.FirstAddedUser.Equals(input.FirstAddedUser))
                ) && 
                (
                    this.NumberOfRemovedUsers == input.NumberOfRemovedUsers ||
                    (this.NumberOfRemovedUsers != null &&
                    this.NumberOfRemovedUsers.Equals(input.NumberOfRemovedUsers))
                ) && 
                (
                    this.FirstRemovedUser == input.FirstRemovedUser ||
                    (this.FirstRemovedUser != null &&
                    this.FirstRemovedUser.Equals(input.FirstRemovedUser))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.NumberOfAddedUsers != null)
                    hashCode = hashCode * 59 + this.NumberOfAddedUsers.GetHashCode();
                if (this.FirstAddedUser != null)
                    hashCode = hashCode * 59 + this.FirstAddedUser.GetHashCode();
                if (this.NumberOfRemovedUsers != null)
                    hashCode = hashCode * 59 + this.NumberOfRemovedUsers.GetHashCode();
                if (this.FirstRemovedUser != null)
                    hashCode = hashCode * 59 + this.FirstRemovedUser.GetHashCode();
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
