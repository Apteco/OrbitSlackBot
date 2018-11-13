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
    /// The details required to create a new collection share
    /// </summary>
    [DataContract]
    public partial class CreateCollectionShareDetail :  IEquatable<CreateCollectionShareDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionShareDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCollectionShareDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionShareDetail" /> class.
        /// </summary>
        /// <param name="CollectionId">The id of the collection being shared (required).</param>
        /// <param name="EmailAddressesToAdd">The list of email addresses to share this collection with (required).</param>
        /// <param name="NotifyAddedUsers">Whether to notify the users added in this share that the collection has now been shared with them (required).</param>
        /// <param name="AddedUserNotificationMessage">If added users are to be notified, this is the message to be sent to them.  The URL of the view of the collection (specified when the collection was created)  will be added to the notification after this message..</param>
        /// <param name="Notes">The notes associated with this share update.</param>
        /// <param name="ViewCollectionUrl">A URL of a page to view the shared collection.  If specified this will be used in notification  messages to show added or removed users where to view the collection    If the URL is specified, it can use {collectionId} and {emailAddress} parameters    http://www.example.com/collections/{collectionId}?email&#x3D;{emailAddress}    If present, these parameters will be replaced with the id of the collection and the email address of the user being added/removed.</param>
        public CreateCollectionShareDetail(int? CollectionId = default(int?), List<string> EmailAddressesToAdd = default(List<string>), bool? NotifyAddedUsers = default(bool?), string AddedUserNotificationMessage = default(string), string Notes = default(string), string ViewCollectionUrl = default(string))
        {
            // to ensure "CollectionId" is required (not null)
            if (CollectionId == null)
            {
                throw new InvalidDataException("CollectionId is a required property for CreateCollectionShareDetail and cannot be null");
            }
            else
            {
                this.CollectionId = CollectionId;
            }
            // to ensure "EmailAddressesToAdd" is required (not null)
            if (EmailAddressesToAdd == null)
            {
                throw new InvalidDataException("EmailAddressesToAdd is a required property for CreateCollectionShareDetail and cannot be null");
            }
            else
            {
                this.EmailAddressesToAdd = EmailAddressesToAdd;
            }
            // to ensure "NotifyAddedUsers" is required (not null)
            if (NotifyAddedUsers == null)
            {
                throw new InvalidDataException("NotifyAddedUsers is a required property for CreateCollectionShareDetail and cannot be null");
            }
            else
            {
                this.NotifyAddedUsers = NotifyAddedUsers;
            }
            this.AddedUserNotificationMessage = AddedUserNotificationMessage;
            this.Notes = Notes;
            this.ViewCollectionUrl = ViewCollectionUrl;
        }
        
        /// <summary>
        /// The id of the collection being shared
        /// </summary>
        /// <value>The id of the collection being shared</value>
        [DataMember(Name="collectionId", EmitDefaultValue=false)]
        public int? CollectionId { get; set; }

        /// <summary>
        /// The list of email addresses to share this collection with
        /// </summary>
        /// <value>The list of email addresses to share this collection with</value>
        [DataMember(Name="emailAddressesToAdd", EmitDefaultValue=false)]
        public List<string> EmailAddressesToAdd { get; set; }

        /// <summary>
        /// Whether to notify the users added in this share that the collection has now been shared with them
        /// </summary>
        /// <value>Whether to notify the users added in this share that the collection has now been shared with them</value>
        [DataMember(Name="notifyAddedUsers", EmitDefaultValue=false)]
        public bool? NotifyAddedUsers { get; set; }

        /// <summary>
        /// If added users are to be notified, this is the message to be sent to them.  The URL of the view of the collection (specified when the collection was created)  will be added to the notification after this message.
        /// </summary>
        /// <value>If added users are to be notified, this is the message to be sent to them.  The URL of the view of the collection (specified when the collection was created)  will be added to the notification after this message.</value>
        [DataMember(Name="addedUserNotificationMessage", EmitDefaultValue=false)]
        public string AddedUserNotificationMessage { get; set; }

        /// <summary>
        /// The notes associated with this share update
        /// </summary>
        /// <value>The notes associated with this share update</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// A URL of a page to view the shared collection.  If specified this will be used in notification  messages to show added or removed users where to view the collection    If the URL is specified, it can use {collectionId} and {emailAddress} parameters    http://www.example.com/collections/{collectionId}?email&#x3D;{emailAddress}    If present, these parameters will be replaced with the id of the collection and the email address of the user being added/removed
        /// </summary>
        /// <value>A URL of a page to view the shared collection.  If specified this will be used in notification  messages to show added or removed users where to view the collection    If the URL is specified, it can use {collectionId} and {emailAddress} parameters    http://www.example.com/collections/{collectionId}?email&#x3D;{emailAddress}    If present, these parameters will be replaced with the id of the collection and the email address of the user being added/removed</value>
        [DataMember(Name="viewCollectionUrl", EmitDefaultValue=false)]
        public string ViewCollectionUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCollectionShareDetail {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  EmailAddressesToAdd: ").Append(EmailAddressesToAdd).Append("\n");
            sb.Append("  NotifyAddedUsers: ").Append(NotifyAddedUsers).Append("\n");
            sb.Append("  AddedUserNotificationMessage: ").Append(AddedUserNotificationMessage).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ViewCollectionUrl: ").Append(ViewCollectionUrl).Append("\n");
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
            return this.Equals(input as CreateCollectionShareDetail);
        }

        /// <summary>
        /// Returns true if CreateCollectionShareDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollectionShareDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollectionShareDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.EmailAddressesToAdd == input.EmailAddressesToAdd ||
                    this.EmailAddressesToAdd != null &&
                    this.EmailAddressesToAdd.SequenceEqual(input.EmailAddressesToAdd)
                ) && 
                (
                    this.NotifyAddedUsers == input.NotifyAddedUsers ||
                    (this.NotifyAddedUsers != null &&
                    this.NotifyAddedUsers.Equals(input.NotifyAddedUsers))
                ) && 
                (
                    this.AddedUserNotificationMessage == input.AddedUserNotificationMessage ||
                    (this.AddedUserNotificationMessage != null &&
                    this.AddedUserNotificationMessage.Equals(input.AddedUserNotificationMessage))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ViewCollectionUrl == input.ViewCollectionUrl ||
                    (this.ViewCollectionUrl != null &&
                    this.ViewCollectionUrl.Equals(input.ViewCollectionUrl))
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
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.EmailAddressesToAdd != null)
                    hashCode = hashCode * 59 + this.EmailAddressesToAdd.GetHashCode();
                if (this.NotifyAddedUsers != null)
                    hashCode = hashCode * 59 + this.NotifyAddedUsers.GetHashCode();
                if (this.AddedUserNotificationMessage != null)
                    hashCode = hashCode * 59 + this.AddedUserNotificationMessage.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ViewCollectionUrl != null)
                    hashCode = hashCode * 59 + this.ViewCollectionUrl.GetHashCode();
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