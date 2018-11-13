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
    /// Details to change a user&#39;s password with
    /// </summary>
    [DataContract]
    public partial class ChangePasswordDetails :  IEquatable<ChangePasswordDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangePasswordDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordDetails" /> class.
        /// </summary>
        /// <param name="CurrentPassword">The user&#39;s current password (required).</param>
        /// <param name="NewPassword">The new password to use (required).</param>
        public ChangePasswordDetails(string CurrentPassword = default(string), string NewPassword = default(string))
        {
            // to ensure "CurrentPassword" is required (not null)
            if (CurrentPassword == null)
            {
                throw new InvalidDataException("CurrentPassword is a required property for ChangePasswordDetails and cannot be null");
            }
            else
            {
                this.CurrentPassword = CurrentPassword;
            }
            // to ensure "NewPassword" is required (not null)
            if (NewPassword == null)
            {
                throw new InvalidDataException("NewPassword is a required property for ChangePasswordDetails and cannot be null");
            }
            else
            {
                this.NewPassword = NewPassword;
            }
        }
        
        /// <summary>
        /// The user&#39;s current password
        /// </summary>
        /// <value>The user&#39;s current password</value>
        [DataMember(Name="currentPassword", EmitDefaultValue=false)]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// The new password to use
        /// </summary>
        /// <value>The new password to use</value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordDetails {\n");
            sb.Append("  CurrentPassword: ").Append(CurrentPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return this.Equals(input as ChangePasswordDetails);
        }

        /// <summary>
        /// Returns true if ChangePasswordDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangePasswordDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePasswordDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentPassword == input.CurrentPassword ||
                    (this.CurrentPassword != null &&
                    this.CurrentPassword.Equals(input.CurrentPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
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
                if (this.CurrentPassword != null)
                    hashCode = hashCode * 59 + this.CurrentPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
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
