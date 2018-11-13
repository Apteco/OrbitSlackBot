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
    /// The parameters needed to create a new user registration request
    /// </summary>
    [DataContract]
    public partial class CreateUserRegistrationRequest :  IEquatable<CreateUserRegistrationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRegistrationRequest" /> class.
        /// </summary>
        /// <param name="Username">The username for the new user to be created with (required).</param>
        /// <param name="Firstname">The first name for the new user.</param>
        /// <param name="Surname">The surname for the new user.</param>
        /// <param name="EmailAddress">The email address for the new user (required).</param>
        /// <param name="Password">The password for the new user (required).</param>
        /// <param name="ConfirmRegistrationUrl">A URL to send in the notification to the user to allow them to confirm their registration.    If the URL is specified, it can use the {token} parameter:    http://www.example.com/register/{token}    If present, this parameter will be replaced with the token of the registration request, which will be needed when confirming the registration.</param>
        public CreateUserRegistrationRequest(string Username = default(string), string Firstname = default(string), string Surname = default(string), string EmailAddress = default(string), string Password = default(string), string ConfirmRegistrationUrl = default(string))
        {
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for CreateUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "EmailAddress" is required (not null)
            if (EmailAddress == null)
            {
                throw new InvalidDataException("EmailAddress is a required property for CreateUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.EmailAddress = EmailAddress;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for CreateUserRegistrationRequest and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            this.Firstname = Firstname;
            this.Surname = Surname;
            this.ConfirmRegistrationUrl = ConfirmRegistrationUrl;
        }
        
        /// <summary>
        /// The username for the new user to be created with
        /// </summary>
        /// <value>The username for the new user to be created with</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The first name for the new user
        /// </summary>
        /// <value>The first name for the new user</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The surname for the new user
        /// </summary>
        /// <value>The surname for the new user</value>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }

        /// <summary>
        /// The email address for the new user
        /// </summary>
        /// <value>The email address for the new user</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The password for the new user
        /// </summary>
        /// <value>The password for the new user</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// A URL to send in the notification to the user to allow them to confirm their registration.    If the URL is specified, it can use the {token} parameter:    http://www.example.com/register/{token}    If present, this parameter will be replaced with the token of the registration request, which will be needed when confirming the registration
        /// </summary>
        /// <value>A URL to send in the notification to the user to allow them to confirm their registration.    If the URL is specified, it can use the {token} parameter:    http://www.example.com/register/{token}    If present, this parameter will be replaced with the token of the registration request, which will be needed when confirming the registration</value>
        [DataMember(Name="confirmRegistrationUrl", EmitDefaultValue=false)]
        public string ConfirmRegistrationUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserRegistrationRequest {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ConfirmRegistrationUrl: ").Append(ConfirmRegistrationUrl).Append("\n");
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
            return this.Equals(input as CreateUserRegistrationRequest);
        }

        /// <summary>
        /// Returns true if CreateUserRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserRegistrationRequest input)
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
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ConfirmRegistrationUrl == input.ConfirmRegistrationUrl ||
                    (this.ConfirmRegistrationUrl != null &&
                    this.ConfirmRegistrationUrl.Equals(input.ConfirmRegistrationUrl))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ConfirmRegistrationUrl != null)
                    hashCode = hashCode * 59 + this.ConfirmRegistrationUrl.GetHashCode();
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
