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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationLanguageUse
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationLanguageUse :  IEquatable<EdFiStudentEducationOrganizationAssociationLanguageUse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationLanguageUse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationLanguageUse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationLanguageUse" /> class.
        /// </summary>
        /// <param name="LanguageUseDescriptor">A description of how the language is used (e.g. Home Language, Native Language, Spoken Language). (required).</param>
        public EdFiStudentEducationOrganizationAssociationLanguageUse(string LanguageUseDescriptor = default(string))
        {
            // to ensure "LanguageUseDescriptor" is required (not null)
            if (LanguageUseDescriptor == null)
            {
                throw new InvalidDataException("LanguageUseDescriptor is a required property for EdFiStudentEducationOrganizationAssociationLanguageUse and cannot be null");
            }
            else
            {
                this.LanguageUseDescriptor = LanguageUseDescriptor;
            }
        }
        
        /// <summary>
        /// A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        /// <value>A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).</value>
        [DataMember(Name="languageUseDescriptor", EmitDefaultValue=false)]
        public string LanguageUseDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationLanguageUse {\n");
            sb.Append("  LanguageUseDescriptor: ").Append(LanguageUseDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationLanguageUse);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationLanguageUse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationLanguageUse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationLanguageUse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageUseDescriptor == input.LanguageUseDescriptor ||
                    (this.LanguageUseDescriptor != null &&
                    this.LanguageUseDescriptor.Equals(input.LanguageUseDescriptor))
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
                if (this.LanguageUseDescriptor != null)
                    hashCode = hashCode * 59 + this.LanguageUseDescriptor.GetHashCode();
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
            // LanguageUseDescriptor (string) maxLength
            if(this.LanguageUseDescriptor != null && this.LanguageUseDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageUseDescriptor, length must be less than 306.", new [] { "LanguageUseDescriptor" });
            }

            yield break;
        }
    }

}
