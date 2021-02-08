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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile
{
    /// <summary>
    /// MnParentReference
    /// </summary>
    [DataContract]
    public partial class MnParentReference :  IEquatable<MnParentReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnParentReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnParentReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnParentReference" /> class.
        /// </summary>
        /// <param name="ParentUniqueId">A unique alphanumeric code assigned to a parent. (required).</param>
        /// <param name="Link">Link.</param>
        public MnParentReference(string ParentUniqueId = default(string), Link Link = default(Link))
        {
            // to ensure "ParentUniqueId" is required (not null)
            if (ParentUniqueId == null)
            {
                throw new InvalidDataException("ParentUniqueId is a required property for MnParentReference and cannot be null");
            }
            else
            {
                this.ParentUniqueId = ParentUniqueId;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// A unique alphanumeric code assigned to a parent.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a parent.</value>
        [DataMember(Name="parentUniqueId", EmitDefaultValue=false)]
        public string ParentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnParentReference {\n");
            sb.Append("  ParentUniqueId: ").Append(ParentUniqueId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as MnParentReference);
        }

        /// <summary>
        /// Returns true if MnParentReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MnParentReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnParentReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentUniqueId == input.ParentUniqueId ||
                    (this.ParentUniqueId != null &&
                    this.ParentUniqueId.Equals(input.ParentUniqueId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.ParentUniqueId != null)
                    hashCode = hashCode * 59 + this.ParentUniqueId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // ParentUniqueId (string) maxLength
            if(this.ParentUniqueId != null && this.ParentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ParentUniqueId, length must be less than 32.", new [] { "ParentUniqueId" });
            }

            yield break;
        }
    }

}
