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

namespace EdFi.OdsApi.Sdk.Models.Composites.EnrollmentComposite
{
    /// <summary>
    /// SchoolEducationOrganizationInstitutionTelephone
    /// </summary>
    [DataContract]
    public partial class SchoolEducationOrganizationInstitutionTelephone :  IEquatable<SchoolEducationOrganizationInstitutionTelephone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolEducationOrganizationInstitutionTelephone" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SchoolEducationOrganizationInstitutionTelephone() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolEducationOrganizationInstitutionTelephone" /> class.
        /// </summary>
        /// <param name="InstitutionTelephoneNumberTypeDescriptor">The type of communication number listed for an individual or organization. (required).</param>
        /// <param name="TelephoneNumber">The telephone number including the area code, and extension, if applicable. (required).</param>
        public SchoolEducationOrganizationInstitutionTelephone(string InstitutionTelephoneNumberTypeDescriptor = default(string), string TelephoneNumber = default(string))
        {
            // to ensure "InstitutionTelephoneNumberTypeDescriptor" is required (not null)
            if (InstitutionTelephoneNumberTypeDescriptor == null)
            {
                throw new InvalidDataException("InstitutionTelephoneNumberTypeDescriptor is a required property for SchoolEducationOrganizationInstitutionTelephone and cannot be null");
            }
            else
            {
                this.InstitutionTelephoneNumberTypeDescriptor = InstitutionTelephoneNumberTypeDescriptor;
            }
            // to ensure "TelephoneNumber" is required (not null)
            if (TelephoneNumber == null)
            {
                throw new InvalidDataException("TelephoneNumber is a required property for SchoolEducationOrganizationInstitutionTelephone and cannot be null");
            }
            else
            {
                this.TelephoneNumber = TelephoneNumber;
            }
        }
        
        /// <summary>
        /// The type of communication number listed for an individual or organization.
        /// </summary>
        /// <value>The type of communication number listed for an individual or organization.</value>
        [DataMember(Name="institutionTelephoneNumberTypeDescriptor", EmitDefaultValue=false)]
        public string InstitutionTelephoneNumberTypeDescriptor { get; set; }

        /// <summary>
        /// The telephone number including the area code, and extension, if applicable.
        /// </summary>
        /// <value>The telephone number including the area code, and extension, if applicable.</value>
        [DataMember(Name="telephoneNumber", EmitDefaultValue=false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolEducationOrganizationInstitutionTelephone {\n");
            sb.Append("  InstitutionTelephoneNumberTypeDescriptor: ").Append(InstitutionTelephoneNumberTypeDescriptor).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
            return this.Equals(input as SchoolEducationOrganizationInstitutionTelephone);
        }

        /// <summary>
        /// Returns true if SchoolEducationOrganizationInstitutionTelephone instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolEducationOrganizationInstitutionTelephone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolEducationOrganizationInstitutionTelephone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstitutionTelephoneNumberTypeDescriptor == input.InstitutionTelephoneNumberTypeDescriptor ||
                    (this.InstitutionTelephoneNumberTypeDescriptor != null &&
                    this.InstitutionTelephoneNumberTypeDescriptor.Equals(input.InstitutionTelephoneNumberTypeDescriptor))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
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
                if (this.InstitutionTelephoneNumberTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.InstitutionTelephoneNumberTypeDescriptor.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
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
            // InstitutionTelephoneNumberTypeDescriptor (string) maxLength
            if(this.InstitutionTelephoneNumberTypeDescriptor != null && this.InstitutionTelephoneNumberTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstitutionTelephoneNumberTypeDescriptor, length must be less than 306.", new [] { "InstitutionTelephoneNumberTypeDescriptor" });
            }

            // TelephoneNumber (string) maxLength
            if(this.TelephoneNumber != null && this.TelephoneNumber.Length > 24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TelephoneNumber, length must be less than 24.", new [] { "TelephoneNumber" });
            }

            yield break;
        }
    }

}
