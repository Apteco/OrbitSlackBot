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
    /// FileStream
    /// </summary>
    [DataContract]
    public partial class FileStream :  IEquatable<FileStream>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileStream" /> class.
        /// </summary>
        /// <param name="SafeFileHandle">SafeFileHandle.</param>
        /// <param name="Position">Position.</param>
        /// <param name="ReadTimeout">ReadTimeout.</param>
        /// <param name="WriteTimeout">WriteTimeout.</param>
        public FileStream(SafeFileHandle SafeFileHandle = default(SafeFileHandle), long? Position = default(long?), int? ReadTimeout = default(int?), int? WriteTimeout = default(int?))
        {
            this.SafeFileHandle = SafeFileHandle;
            this.Position = Position;
            this.ReadTimeout = ReadTimeout;
            this.WriteTimeout = WriteTimeout;
        }
        
        /// <summary>
        /// Gets or Sets IsAsync
        /// </summary>
        [DataMember(Name="isAsync", EmitDefaultValue=false)]
        public bool? IsAsync { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets SafeFileHandle
        /// </summary>
        [DataMember(Name="safeFileHandle", EmitDefaultValue=false)]
        public SafeFileHandle SafeFileHandle { get; set; }

        /// <summary>
        /// Gets or Sets CanRead
        /// </summary>
        [DataMember(Name="canRead", EmitDefaultValue=false)]
        public bool? CanRead { get; private set; }

        /// <summary>
        /// Gets or Sets CanSeek
        /// </summary>
        [DataMember(Name="canSeek", EmitDefaultValue=false)]
        public bool? CanSeek { get; private set; }

        /// <summary>
        /// Gets or Sets CanWrite
        /// </summary>
        [DataMember(Name="canWrite", EmitDefaultValue=false)]
        public bool? CanWrite { get; private set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long? Length { get; private set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public long? Position { get; set; }

        /// <summary>
        /// Gets or Sets ReadTimeout
        /// </summary>
        [DataMember(Name="readTimeout", EmitDefaultValue=false)]
        public int? ReadTimeout { get; set; }

        /// <summary>
        /// Gets or Sets CanTimeout
        /// </summary>
        [DataMember(Name="canTimeout", EmitDefaultValue=false)]
        public bool? CanTimeout { get; private set; }

        /// <summary>
        /// Gets or Sets WriteTimeout
        /// </summary>
        [DataMember(Name="writeTimeout", EmitDefaultValue=false)]
        public int? WriteTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileStream {\n");
            sb.Append("  IsAsync: ").Append(IsAsync).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SafeFileHandle: ").Append(SafeFileHandle).Append("\n");
            sb.Append("  CanRead: ").Append(CanRead).Append("\n");
            sb.Append("  CanSeek: ").Append(CanSeek).Append("\n");
            sb.Append("  CanWrite: ").Append(CanWrite).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ReadTimeout: ").Append(ReadTimeout).Append("\n");
            sb.Append("  CanTimeout: ").Append(CanTimeout).Append("\n");
            sb.Append("  WriteTimeout: ").Append(WriteTimeout).Append("\n");
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
            return this.Equals(input as FileStream);
        }

        /// <summary>
        /// Returns true if FileStream instances are equal
        /// </summary>
        /// <param name="input">Instance of FileStream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileStream input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAsync == input.IsAsync ||
                    (this.IsAsync != null &&
                    this.IsAsync.Equals(input.IsAsync))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SafeFileHandle == input.SafeFileHandle ||
                    (this.SafeFileHandle != null &&
                    this.SafeFileHandle.Equals(input.SafeFileHandle))
                ) && 
                (
                    this.CanRead == input.CanRead ||
                    (this.CanRead != null &&
                    this.CanRead.Equals(input.CanRead))
                ) && 
                (
                    this.CanSeek == input.CanSeek ||
                    (this.CanSeek != null &&
                    this.CanSeek.Equals(input.CanSeek))
                ) && 
                (
                    this.CanWrite == input.CanWrite ||
                    (this.CanWrite != null &&
                    this.CanWrite.Equals(input.CanWrite))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.ReadTimeout == input.ReadTimeout ||
                    (this.ReadTimeout != null &&
                    this.ReadTimeout.Equals(input.ReadTimeout))
                ) && 
                (
                    this.CanTimeout == input.CanTimeout ||
                    (this.CanTimeout != null &&
                    this.CanTimeout.Equals(input.CanTimeout))
                ) && 
                (
                    this.WriteTimeout == input.WriteTimeout ||
                    (this.WriteTimeout != null &&
                    this.WriteTimeout.Equals(input.WriteTimeout))
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
                if (this.IsAsync != null)
                    hashCode = hashCode * 59 + this.IsAsync.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SafeFileHandle != null)
                    hashCode = hashCode * 59 + this.SafeFileHandle.GetHashCode();
                if (this.CanRead != null)
                    hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.CanSeek != null)
                    hashCode = hashCode * 59 + this.CanSeek.GetHashCode();
                if (this.CanWrite != null)
                    hashCode = hashCode * 59 + this.CanWrite.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.ReadTimeout != null)
                    hashCode = hashCode * 59 + this.ReadTimeout.GetHashCode();
                if (this.CanTimeout != null)
                    hashCode = hashCode * 59 + this.CanTimeout.GetHashCode();
                if (this.WriteTimeout != null)
                    hashCode = hashCode * 59 + this.WriteTimeout.GetHashCode();
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
