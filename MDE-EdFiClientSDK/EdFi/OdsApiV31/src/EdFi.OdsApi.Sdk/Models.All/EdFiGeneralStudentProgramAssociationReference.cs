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
    /// EdFiGeneralStudentProgramAssociationReference
    /// </summary>
    [DataContract]
    public partial class EdFiGeneralStudentProgramAssociationReference :  IEquatable<EdFiGeneralStudentProgramAssociationReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGeneralStudentProgramAssociationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGeneralStudentProgramAssociationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGeneralStudentProgramAssociationReference" /> class.
        /// </summary>
        /// <param name="BeginDate">The month, day, and year on which the Student first received services. (required).</param>
        /// <param name="EducationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="ProgramEducationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="ProgramName">The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (required).</param>
        /// <param name="ProgramTypeDescriptor">The type of program. (required).</param>
        /// <param name="StudentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="Link">Link.</param>
        public EdFiGeneralStudentProgramAssociationReference(DateTime? BeginDate = default(DateTime?), int? EducationOrganizationId = default(int?), int? ProgramEducationOrganizationId = default(int?), string ProgramName = default(string), string ProgramTypeDescriptor = default(string), string StudentUniqueId = default(string), Link Link = default(Link))
        {
            // to ensure "BeginDate" is required (not null)
            if (BeginDate == null)
            {
                throw new InvalidDataException("BeginDate is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.BeginDate = BeginDate;
            }
            // to ensure "EducationOrganizationId" is required (not null)
            if (EducationOrganizationId == null)
            {
                throw new InvalidDataException("EducationOrganizationId is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = EducationOrganizationId;
            }
            // to ensure "ProgramEducationOrganizationId" is required (not null)
            if (ProgramEducationOrganizationId == null)
            {
                throw new InvalidDataException("ProgramEducationOrganizationId is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.ProgramEducationOrganizationId = ProgramEducationOrganizationId;
            }
            // to ensure "ProgramName" is required (not null)
            if (ProgramName == null)
            {
                throw new InvalidDataException("ProgramName is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.ProgramName = ProgramName;
            }
            // to ensure "ProgramTypeDescriptor" is required (not null)
            if (ProgramTypeDescriptor == null)
            {
                throw new InvalidDataException("ProgramTypeDescriptor is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.ProgramTypeDescriptor = ProgramTypeDescriptor;
            }
            // to ensure "StudentUniqueId" is required (not null)
            if (StudentUniqueId == null)
            {
                throw new InvalidDataException("StudentUniqueId is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            else
            {
                this.StudentUniqueId = StudentUniqueId;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// The month, day, and year on which the Student first received services.
        /// </summary>
        /// <value>The month, day, and year on which the Student first received services.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="programEducationOrganizationId", EmitDefaultValue=false)]
        public int? ProgramEducationOrganizationId { get; set; }

        /// <summary>
        /// The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies.
        /// </summary>
        /// <value>The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies.</value>
        [DataMember(Name="programName", EmitDefaultValue=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [DataMember(Name="programTypeDescriptor", EmitDefaultValue=false)]
        public string ProgramTypeDescriptor { get; set; }

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
            sb.Append("class EdFiGeneralStudentProgramAssociationReference {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ProgramEducationOrganizationId: ").Append(ProgramEducationOrganizationId).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
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
            return this.Equals(input as EdFiGeneralStudentProgramAssociationReference);
        }

        /// <summary>
        /// Returns true if EdFiGeneralStudentProgramAssociationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGeneralStudentProgramAssociationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGeneralStudentProgramAssociationReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.ProgramEducationOrganizationId == input.ProgramEducationOrganizationId ||
                    (this.ProgramEducationOrganizationId != null &&
                    this.ProgramEducationOrganizationId.Equals(input.ProgramEducationOrganizationId))
                ) && 
                (
                    this.ProgramName == input.ProgramName ||
                    (this.ProgramName != null &&
                    this.ProgramName.Equals(input.ProgramName))
                ) && 
                (
                    this.ProgramTypeDescriptor == input.ProgramTypeDescriptor ||
                    (this.ProgramTypeDescriptor != null &&
                    this.ProgramTypeDescriptor.Equals(input.ProgramTypeDescriptor))
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
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.ProgramEducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.ProgramEducationOrganizationId.GetHashCode();
                if (this.ProgramName != null)
                    hashCode = hashCode * 59 + this.ProgramName.GetHashCode();
                if (this.ProgramTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramTypeDescriptor.GetHashCode();
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
            // ProgramName (string) maxLength
            if(this.ProgramName != null && this.ProgramName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramName, length must be less than 60.", new [] { "ProgramName" });
            }

            // ProgramTypeDescriptor (string) maxLength
            if(this.ProgramTypeDescriptor != null && this.ProgramTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramTypeDescriptor, length must be less than 306.", new [] { "ProgramTypeDescriptor" });
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
