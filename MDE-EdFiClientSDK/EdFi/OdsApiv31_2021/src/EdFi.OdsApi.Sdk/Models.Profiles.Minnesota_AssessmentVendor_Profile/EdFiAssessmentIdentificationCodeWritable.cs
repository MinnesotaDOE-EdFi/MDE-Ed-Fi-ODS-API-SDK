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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_AssessmentVendor_Profile
{
    /// <summary>
    /// EdFiAssessmentIdentificationCodeWritable
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentIdentificationCodeWritable :  IEquatable<EdFiAssessmentIdentificationCodeWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentIdentificationCodeWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentIdentificationCodeWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentIdentificationCodeWritable" /> class.
        /// </summary>
        /// <param name="AssessmentIdentificationSystemDescriptor">A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment. (required).</param>
        /// <param name="AssigningOrganizationIdentificationCode">The organization code or name assigning the assessment identification code..</param>
        /// <param name="IdentificationCode">A unique number or alphanumeric code assigned to an assessment by a school, school system, state, or other agency or entity. (required).</param>
        public EdFiAssessmentIdentificationCodeWritable(string AssessmentIdentificationSystemDescriptor = default(string), string AssigningOrganizationIdentificationCode = default(string), string IdentificationCode = default(string))
        {
            // to ensure "AssessmentIdentificationSystemDescriptor" is required (not null)
            if (AssessmentIdentificationSystemDescriptor == null)
            {
                throw new InvalidDataException("AssessmentIdentificationSystemDescriptor is a required property for EdFiAssessmentIdentificationCodeWritable and cannot be null");
            }
            else
            {
                this.AssessmentIdentificationSystemDescriptor = AssessmentIdentificationSystemDescriptor;
            }
            // to ensure "IdentificationCode" is required (not null)
            if (IdentificationCode == null)
            {
                throw new InvalidDataException("IdentificationCode is a required property for EdFiAssessmentIdentificationCodeWritable and cannot be null");
            }
            else
            {
                this.IdentificationCode = IdentificationCode;
            }
            this.AssigningOrganizationIdentificationCode = AssigningOrganizationIdentificationCode;
        }
        
        /// <summary>
        /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment.
        /// </summary>
        /// <value>A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment.</value>
        [DataMember(Name="assessmentIdentificationSystemDescriptor", EmitDefaultValue=false)]
        public string AssessmentIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// The organization code or name assigning the assessment identification code.
        /// </summary>
        /// <value>The organization code or name assigning the assessment identification code.</value>
        [DataMember(Name="assigningOrganizationIdentificationCode", EmitDefaultValue=false)]
        public string AssigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentIdentificationCodeWritable {\n");
            sb.Append("  AssessmentIdentificationSystemDescriptor: ").Append(AssessmentIdentificationSystemDescriptor).Append("\n");
            sb.Append("  AssigningOrganizationIdentificationCode: ").Append(AssigningOrganizationIdentificationCode).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
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
            return this.Equals(input as EdFiAssessmentIdentificationCodeWritable);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentIdentificationCodeWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentIdentificationCodeWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentIdentificationCodeWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentIdentificationSystemDescriptor == input.AssessmentIdentificationSystemDescriptor ||
                    (this.AssessmentIdentificationSystemDescriptor != null &&
                    this.AssessmentIdentificationSystemDescriptor.Equals(input.AssessmentIdentificationSystemDescriptor))
                ) && 
                (
                    this.AssigningOrganizationIdentificationCode == input.AssigningOrganizationIdentificationCode ||
                    (this.AssigningOrganizationIdentificationCode != null &&
                    this.AssigningOrganizationIdentificationCode.Equals(input.AssigningOrganizationIdentificationCode))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
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
                if (this.AssessmentIdentificationSystemDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentIdentificationSystemDescriptor.GetHashCode();
                if (this.AssigningOrganizationIdentificationCode != null)
                    hashCode = hashCode * 59 + this.AssigningOrganizationIdentificationCode.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
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
            // AssessmentIdentificationSystemDescriptor (string) maxLength
            if(this.AssessmentIdentificationSystemDescriptor != null && this.AssessmentIdentificationSystemDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentIdentificationSystemDescriptor, length must be less than 306.", new [] { "AssessmentIdentificationSystemDescriptor" });
            }

            // AssigningOrganizationIdentificationCode (string) maxLength
            if(this.AssigningOrganizationIdentificationCode != null && this.AssigningOrganizationIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssigningOrganizationIdentificationCode, length must be less than 60.", new [] { "AssigningOrganizationIdentificationCode" });
            }

            // IdentificationCode (string) maxLength
            if(this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            yield break;
        }
    }

}
