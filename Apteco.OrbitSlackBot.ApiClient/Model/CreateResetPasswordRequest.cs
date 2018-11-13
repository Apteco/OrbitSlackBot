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
    /// The parameters needed to create a new reset password request
    /// </summary>
    [DataContract]
    public partial class CreateResetPasswordRequest :  IEquatable<CreateResetPasswordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResetPasswordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateResetPasswordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResetPasswordRequest" /> class.
        /// </summary>
        /// <param name="EmailAddress">The email address for the user resetting their password (required).</param>
        /// <param name="ResetPasswordUrl">ResetPasswordUrl.</param>
        public CreateResetPasswordRequest(string EmailAddress = default(string), string ResetPasswordUrl = default(string))
        {
            // to ensure "EmailAddress" is required (not null)
            if (EmailAddress == null)
            {
                throw new InvalidDataException("EmailAddress is a required property for CreateResetPasswordRequest and cannot be null");
            }
            else
            {
                this.EmailAddress = EmailAddress;
            }
            this.ResetPasswordUrl = ResetPasswordUrl;
        }
        
        /// <summary>
        /// The email address for the user resetting their password
        /// </summary>
        /// <value>The email address for the user resetting their password</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets ResetPasswordUrl
        /// </summary>
        [DataMember(Name="resetPasswordUrl", EmitDefaultValue=false)]
        public string ResetPasswordUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResetPasswordRequest {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  ResetPasswordUrl: ").Append(ResetPasswordUrl).Append("\n");
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
            return this.Equals(input as CreateResetPasswordRequest);
        }

        /// <summary>
        /// Returns true if CreateResetPasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateResetPasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResetPasswordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.ResetPasswordUrl == input.ResetPasswordUrl ||
                    (this.ResetPasswordUrl != null &&
                    this.ResetPasswordUrl.Equals(input.ResetPasswordUrl))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.ResetPasswordUrl != null)
                    hashCode = hashCode * 59 + this.ResetPasswordUrl.GetHashCode();
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
