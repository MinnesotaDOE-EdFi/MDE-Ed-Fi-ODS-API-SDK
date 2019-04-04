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
    /// EdFiReportCardReference
    /// </summary>
    [DataContract]
    public partial class EdFiReportCardReference :  IEquatable<EdFiReportCardReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiReportCardReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardReference" /> class.
        /// </summary>
        /// <param name="EducationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="GradingPeriodDescriptor">The name of the period for which grades are reported. (required).</param>
        /// <param name="GradingPeriodSchoolId">The identifier assigned to a school. (required).</param>
        /// <param name="GradingPeriodSchoolYear">The identifier for the grading period school year. (required).</param>
        /// <param name="GradingPeriodSequence">The sequential order of this period relative to other periods. (required).</param>
        /// <param name="StudentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="Link">Link.</param>
        public EdFiReportCardReference(int? EducationOrganizationId = default(int?), string GradingPeriodDescriptor = default(string), int? GradingPeriodSchoolId = default(int?), int? GradingPeriodSchoolYear = default(int?), int? GradingPeriodSequence = default(int?), string StudentUniqueId = default(string), Link Link = default(Link))
        {
            // to ensure "EducationOrganizationId" is required (not null)
            if (EducationOrganizationId == null)
            {
                throw new InvalidDataException("EducationOrganizationId is a required property for EdFiReportCardReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = EducationOrganizationId;
            }
            // to ensure "GradingPeriodDescriptor" is required (not null)
            if (GradingPeriodDescriptor == null)
            {
                throw new InvalidDataException("GradingPeriodDescriptor is a required property for EdFiReportCardReference and cannot be null");
            }
            else
            {
                this.GradingPeriodDescriptor = GradingPeriodDescriptor;
            }
            // to ensure "GradingPeriodSchoolId" is required (not null)
            if (GradingPeriodSchoolId == null)
            {
                throw new InvalidDataException("GradingPeriodSchoolId is a required property for EdFiReportCardReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSchoolId = GradingPeriodSchoolId;
            }
            // to ensure "GradingPeriodSchoolYear" is required (not null)
            if (GradingPeriodSchoolYear == null)
            {
                throw new InvalidDataException("GradingPeriodSchoolYear is a required property for EdFiReportCardReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSchoolYear = GradingPeriodSchoolYear;
            }
            // to ensure "GradingPeriodSequence" is required (not null)
            if (GradingPeriodSequence == null)
            {
                throw new InvalidDataException("GradingPeriodSequence is a required property for EdFiReportCardReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSequence = GradingPeriodSequence;
            }
            // to ensure "StudentUniqueId" is required (not null)
            if (StudentUniqueId == null)
            {
                throw new InvalidDataException("StudentUniqueId is a required property for EdFiReportCardReference and cannot be null");
            }
            else
            {
                this.StudentUniqueId = StudentUniqueId;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// The name of the period for which grades are reported.
        /// </summary>
        /// <value>The name of the period for which grades are reported.</value>
        [DataMember(Name="gradingPeriodDescriptor", EmitDefaultValue=false)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="gradingPeriodSchoolId", EmitDefaultValue=false)]
        public int? GradingPeriodSchoolId { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name="gradingPeriodSchoolYear", EmitDefaultValue=false)]
        public int? GradingPeriodSchoolYear { get; set; }

        /// <summary>
        /// The sequential order of this period relative to other periods.
        /// </summary>
        /// <value>The sequential order of this period relative to other periods.</value>
        [DataMember(Name="gradingPeriodSequence", EmitDefaultValue=false)]
        public int? GradingPeriodSequence { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name="studentUniqueId", EmitDefaultValue=false)]
        public string StudentUniqueId { get; set; }

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
            sb.Append("class EdFiReportCardReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  GradingPeriodSchoolId: ").Append(GradingPeriodSchoolId).Append("\n");
            sb.Append("  GradingPeriodSchoolYear: ").Append(GradingPeriodSchoolYear).Append("\n");
            sb.Append("  GradingPeriodSequence: ").Append(GradingPeriodSequence).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            return this.Equals(input as EdFiReportCardReference);
        }

        /// <summary>
        /// Returns true if EdFiReportCardReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiReportCardReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiReportCardReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.GradingPeriodDescriptor == input.GradingPeriodDescriptor ||
                    (this.GradingPeriodDescriptor != null &&
                    this.GradingPeriodDescriptor.Equals(input.GradingPeriodDescriptor))
                ) && 
                (
                    this.GradingPeriodSchoolId == input.GradingPeriodSchoolId ||
                    (this.GradingPeriodSchoolId != null &&
                    this.GradingPeriodSchoolId.Equals(input.GradingPeriodSchoolId))
                ) && 
                (
                    this.GradingPeriodSchoolYear == input.GradingPeriodSchoolYear ||
                    (this.GradingPeriodSchoolYear != null &&
                    this.GradingPeriodSchoolYear.Equals(input.GradingPeriodSchoolYear))
                ) && 
                (
                    this.GradingPeriodSequence == input.GradingPeriodSequence ||
                    (this.GradingPeriodSequence != null &&
                    this.GradingPeriodSequence.Equals(input.GradingPeriodSequence))
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
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
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.GradingPeriodDescriptor != null)
                    hashCode = hashCode * 59 + this.GradingPeriodDescriptor.GetHashCode();
                if (this.GradingPeriodSchoolId != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSchoolId.GetHashCode();
                if (this.GradingPeriodSchoolYear != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSchoolYear.GetHashCode();
                if (this.GradingPeriodSequence != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSequence.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
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
            // GradingPeriodDescriptor (string) maxLength
            if(this.GradingPeriodDescriptor != null && this.GradingPeriodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradingPeriodDescriptor, length must be less than 306.", new [] { "GradingPeriodDescriptor" });
            }

            // StudentUniqueId (string) maxLength
            if(this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}