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
    /// Display details for a user
    /// </summary>
    [DataContract]
    public partial class UserDisplayDetails :  IEquatable<UserDisplayDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDisplayDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserDisplayDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDisplayDetails" /> class.
        /// </summary>
        /// <param name="Username">The user&#39;s username (required).</param>
        /// <param name="Firstname">The user&#39;s first name (required).</param>
        /// <param name="Surname">The user&#39;s surname (required).</param>
        /// <param name="EmailAddress">The user&#39;s email address (required).</param>
        public UserDisplayDetails(string Username = default(string), string Firstname = default(string), string Surname = default(string), string EmailAddress = default(string))
        {
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for UserDisplayDetails and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "Firstname" is required (not null)
            if (Firstname == null)
            {
                throw new InvalidDataException("Firstname is a required property for UserDisplayDetails and cannot be null");
            }
            else
            {
                this.Firstname = Firstname;
            }
            // to ensure "Surname" is required (not null)
            if (Surname == null)
            {
                throw new InvalidDataException("Surname is a required property for UserDisplayDetails and cannot be null");
            }
            else
            {
                this.Surname = Surname;
            }
            // to ensure "EmailAddress" is required (not null)
            if (EmailAddress == null)
            {
                throw new InvalidDataException("EmailAddress is a required property for UserDisplayDetails and cannot be null");
            }
            else
            {
                this.EmailAddress = EmailAddress;
            }
        }
        
        /// <summary>
        /// The user&#39;s username
        /// </summary>
        /// <value>The user&#39;s username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The user&#39;s first name
        /// </summary>
        /// <value>The user&#39;s first name</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The user&#39;s surname
        /// </summary>
        /// <value>The user&#39;s surname</value>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }

        /// <summary>
        /// The user&#39;s email address
        /// </summary>
        /// <value>The user&#39;s email address</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDisplayDetails {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
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
            return this.Equals(input as UserDisplayDetails);
        }

        /// <summary>
        /// Returns true if UserDisplayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDisplayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDisplayDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
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
