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
    /// MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable :  IEquatable<MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable" /> class.
        /// </summary>
        /// <param name="AssessmentFormatDescriptor">Format for which an objective assessment was administered. E.g., Paper.</param>
        /// <param name="AssessmentStatusDescriptor">The state of a student assessment. E.g.,          Student has submitted a response for all scored items OR          Student has submitted a response to at least one scored item, but not all scored items.</param>
        /// <param name="AssessmentTierDescriptor">Tier descriptor for objective assessment. E.g., Listening, Reading, Speaking, Writing.</param>
        /// <param name="ClusterGradeLevelDescriptor">Grade level for the objective assessment..</param>
        public MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable(string AssessmentFormatDescriptor = default(string), string AssessmentStatusDescriptor = default(string), string AssessmentTierDescriptor = default(string), string ClusterGradeLevelDescriptor = default(string))
        {
            this.AssessmentFormatDescriptor = AssessmentFormatDescriptor;
            this.AssessmentStatusDescriptor = AssessmentStatusDescriptor;
            this.AssessmentTierDescriptor = AssessmentTierDescriptor;
            this.ClusterGradeLevelDescriptor = ClusterGradeLevelDescriptor;
        }
        
        /// <summary>
        /// Format for which an objective assessment was administered. E.g., Paper
        /// </summary>
        /// <value>Format for which an objective assessment was administered. E.g., Paper</value>
        [DataMember(Name="assessmentFormatDescriptor", EmitDefaultValue=false)]
        public string AssessmentFormatDescriptor { get; set; }

        /// <summary>
        /// The state of a student assessment. E.g.,          Student has submitted a response for all scored items OR          Student has submitted a response to at least one scored item, but not all scored items
        /// </summary>
        /// <value>The state of a student assessment. E.g.,          Student has submitted a response for all scored items OR          Student has submitted a response to at least one scored item, but not all scored items</value>
        [DataMember(Name="assessmentStatusDescriptor", EmitDefaultValue=false)]
        public string AssessmentStatusDescriptor { get; set; }

        /// <summary>
        /// Tier descriptor for objective assessment. E.g., Listening, Reading, Speaking, Writing
        /// </summary>
        /// <value>Tier descriptor for objective assessment. E.g., Listening, Reading, Speaking, Writing</value>
        [DataMember(Name="assessmentTierDescriptor", EmitDefaultValue=false)]
        public string AssessmentTierDescriptor { get; set; }

        /// <summary>
        /// Grade level for the objective assessment.
        /// </summary>
        /// <value>Grade level for the objective assessment.</value>
        [DataMember(Name="clusterGradeLevelDescriptor", EmitDefaultValue=false)]
        public string ClusterGradeLevelDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable {\n");
            sb.Append("  AssessmentFormatDescriptor: ").Append(AssessmentFormatDescriptor).Append("\n");
            sb.Append("  AssessmentStatusDescriptor: ").Append(AssessmentStatusDescriptor).Append("\n");
            sb.Append("  AssessmentTierDescriptor: ").Append(AssessmentTierDescriptor).Append("\n");
            sb.Append("  ClusterGradeLevelDescriptor: ").Append(ClusterGradeLevelDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable);
        }

        /// <summary>
        /// Returns true if MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentAssessmentStudentObjectiveAssessmentExtensionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentFormatDescriptor == input.AssessmentFormatDescriptor ||
                    (this.AssessmentFormatDescriptor != null &&
                    this.AssessmentFormatDescriptor.Equals(input.AssessmentFormatDescriptor))
                ) && 
                (
                    this.AssessmentStatusDescriptor == input.AssessmentStatusDescriptor ||
                    (this.AssessmentStatusDescriptor != null &&
                    this.AssessmentStatusDescriptor.Equals(input.AssessmentStatusDescriptor))
                ) && 
                (
                    this.AssessmentTierDescriptor == input.AssessmentTierDescriptor ||
                    (this.AssessmentTierDescriptor != null &&
                    this.AssessmentTierDescriptor.Equals(input.AssessmentTierDescriptor))
                ) && 
                (
                    this.ClusterGradeLevelDescriptor == input.ClusterGradeLevelDescriptor ||
                    (this.ClusterGradeLevelDescriptor != null &&
                    this.ClusterGradeLevelDescriptor.Equals(input.ClusterGradeLevelDescriptor))
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
                if (this.AssessmentFormatDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentFormatDescriptor.GetHashCode();
                if (this.AssessmentStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentStatusDescriptor.GetHashCode();
                if (this.AssessmentTierDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentTierDescriptor.GetHashCode();
                if (this.ClusterGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.ClusterGradeLevelDescriptor.GetHashCode();
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
            // AssessmentFormatDescriptor (string) maxLength
            if(this.AssessmentFormatDescriptor != null && this.AssessmentFormatDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentFormatDescriptor, length must be less than 306.", new [] { "AssessmentFormatDescriptor" });
            }

            // AssessmentStatusDescriptor (string) maxLength
            if(this.AssessmentStatusDescriptor != null && this.AssessmentStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentStatusDescriptor, length must be less than 306.", new [] { "AssessmentStatusDescriptor" });
            }

            // AssessmentTierDescriptor (string) maxLength
            if(this.AssessmentTierDescriptor != null && this.AssessmentTierDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentTierDescriptor, length must be less than 306.", new [] { "AssessmentTierDescriptor" });
            }

            // ClusterGradeLevelDescriptor (string) maxLength
            if(this.ClusterGradeLevelDescriptor != null && this.ClusterGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClusterGradeLevelDescriptor, length must be less than 306.", new [] { "ClusterGradeLevelDescriptor" });
            }

            yield break;
        }
    }

}
