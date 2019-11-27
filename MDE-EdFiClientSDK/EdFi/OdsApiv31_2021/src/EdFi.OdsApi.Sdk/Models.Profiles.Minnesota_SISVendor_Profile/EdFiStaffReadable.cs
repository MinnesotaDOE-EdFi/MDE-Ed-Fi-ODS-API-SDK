/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface. The Ed-Fi ODS / API supports both transactional and bulk modes of operation.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
 * 
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
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile
{
    /// <summary>
    /// EdFiStaffReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStaffReadable :  IEquatable<EdFiStaffReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="StaffUniqueId">A unique alphanumeric code assigned to a staff. (required).</param>
        /// <param name="FirstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="GenerationCodeSuffix">An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III)..</param>
        /// <param name="LastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="MiddleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStaffReadable(string Id = default(string), string StaffUniqueId = default(string), string FirstName = default(string), string GenerationCodeSuffix = default(string), string LastSurname = default(string), string MiddleName = default(string), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStaffReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "StaffUniqueId" is required (not null)
            if (StaffUniqueId == null)
            {
                throw new InvalidDataException("StaffUniqueId is a required property for EdFiStaffReadable and cannot be null");
            }
            else
            {
                this.StaffUniqueId = StaffUniqueId;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for EdFiStaffReadable and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastSurname" is required (not null)
            if (LastSurname == null)
            {
                throw new InvalidDataException("LastSurname is a required property for EdFiStaffReadable and cannot be null");
            }
            else
            {
                this.LastSurname = LastSurname;
            }
            this.GenerationCodeSuffix = GenerationCodeSuffix;
            this.MiddleName = MiddleName;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a staff.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a staff.</value>
        [DataMember(Name="staffUniqueId", EmitDefaultValue=false)]
        public string StaffUniqueId { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).
        /// </summary>
        /// <value>An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).</value>
        [DataMember(Name="generationCodeSuffix", EmitDefaultValue=false)]
        public string GenerationCodeSuffix { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name="lastSurname", EmitDefaultValue=false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStaffReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StaffUniqueId: ").Append(StaffUniqueId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  GenerationCodeSuffix: ").Append(GenerationCodeSuffix).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiStaffReadable);
        }

        /// <summary>
        /// Returns true if EdFiStaffReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffReadable input)
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
                    this.StaffUniqueId == input.StaffUniqueId ||
                    (this.StaffUniqueId != null &&
                    this.StaffUniqueId.Equals(input.StaffUniqueId))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.GenerationCodeSuffix == input.GenerationCodeSuffix ||
                    (this.GenerationCodeSuffix != null &&
                    this.GenerationCodeSuffix.Equals(input.GenerationCodeSuffix))
                ) && 
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.StaffUniqueId != null)
                    hashCode = hashCode * 59 + this.StaffUniqueId.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.GenerationCodeSuffix != null)
                    hashCode = hashCode * 59 + this.GenerationCodeSuffix.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
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
            // StaffUniqueId (string) maxLength
            if(this.StaffUniqueId != null && this.StaffUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StaffUniqueId, length must be less than 32.", new [] { "StaffUniqueId" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 75.", new [] { "FirstName" });
            }

            // GenerationCodeSuffix (string) maxLength
            if(this.GenerationCodeSuffix != null && this.GenerationCodeSuffix.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenerationCodeSuffix, length must be less than 10.", new [] { "GenerationCodeSuffix" });
            }

            // LastSurname (string) maxLength
            if(this.LastSurname != null && this.LastSurname.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be less than 75.", new [] { "LastSurname" });
            }

            // MiddleName (string) maxLength
            if(this.MiddleName != null && this.MiddleName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiddleName, length must be less than 75.", new [] { "MiddleName" });
            }

            yield break;
        }
    }

}
