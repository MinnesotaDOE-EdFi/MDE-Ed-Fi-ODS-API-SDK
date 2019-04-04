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
    /// EdFiCohort
    /// </summary>
    [DataContract]
    public partial class EdFiCohort :  IEquatable<EdFiCohort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCohort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCohort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCohort" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="CohortIdentifier">The name or ID for the Cohort. (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="AcademicSubjectDescriptor">The academic subject associated with an academic intervention..</param>
        /// <param name="CohortDescription">The description of the Cohort and its purpose..</param>
        /// <param name="CohortScopeDescriptor">The scope of cohort (e.g., school, district, classroom)..</param>
        /// <param name="CohortTypeDescriptor">The type of cohort (e.g., academic intervention, classroom breakout). (required).</param>
        /// <param name="Programs">An unordered collection of cohortPrograms. The (optional) program associated with this Cohort (e.g., special education)..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiCohort(string Id = default(string), string CohortIdentifier = default(string), EdFiEducationOrganizationReference EducationOrganizationReference = default(EdFiEducationOrganizationReference), string AcademicSubjectDescriptor = default(string), string CohortDescription = default(string), string CohortScopeDescriptor = default(string), string CohortTypeDescriptor = default(string), List<EdFiCohortProgram> Programs = default(List<EdFiCohortProgram>), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiCohort and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CohortIdentifier" is required (not null)
            if (CohortIdentifier == null)
            {
                throw new InvalidDataException("CohortIdentifier is a required property for EdFiCohort and cannot be null");
            }
            else
            {
                this.CohortIdentifier = CohortIdentifier;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for EdFiCohort and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "CohortTypeDescriptor" is required (not null)
            if (CohortTypeDescriptor == null)
            {
                throw new InvalidDataException("CohortTypeDescriptor is a required property for EdFiCohort and cannot be null");
            }
            else
            {
                this.CohortTypeDescriptor = CohortTypeDescriptor;
            }
            this.AcademicSubjectDescriptor = AcademicSubjectDescriptor;
            this.CohortDescription = CohortDescription;
            this.CohortScopeDescriptor = CohortScopeDescriptor;
            this.Programs = Programs;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name or ID for the Cohort.
        /// </summary>
        /// <value>The name or ID for the Cohort.</value>
        [DataMember(Name="cohortIdentifier", EmitDefaultValue=false)]
        public string CohortIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// The academic subject associated with an academic intervention.
        /// </summary>
        /// <value>The academic subject associated with an academic intervention.</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// The description of the Cohort and its purpose.
        /// </summary>
        /// <value>The description of the Cohort and its purpose.</value>
        [DataMember(Name="cohortDescription", EmitDefaultValue=false)]
        public string CohortDescription { get; set; }

        /// <summary>
        /// The scope of cohort (e.g., school, district, classroom).
        /// </summary>
        /// <value>The scope of cohort (e.g., school, district, classroom).</value>
        [DataMember(Name="cohortScopeDescriptor", EmitDefaultValue=false)]
        public string CohortScopeDescriptor { get; set; }

        /// <summary>
        /// The type of cohort (e.g., academic intervention, classroom breakout).
        /// </summary>
        /// <value>The type of cohort (e.g., academic intervention, classroom breakout).</value>
        [DataMember(Name="cohortTypeDescriptor", EmitDefaultValue=false)]
        public string CohortTypeDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of cohortPrograms. The (optional) program associated with this Cohort (e.g., special education).
        /// </summary>
        /// <value>An unordered collection of cohortPrograms. The (optional) program associated with this Cohort (e.g., special education).</value>
        [DataMember(Name="programs", EmitDefaultValue=false)]
        public List<EdFiCohortProgram> Programs { get; set; }

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
            sb.Append("class EdFiCohort {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CohortIdentifier: ").Append(CohortIdentifier).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  CohortDescription: ").Append(CohortDescription).Append("\n");
            sb.Append("  CohortScopeDescriptor: ").Append(CohortScopeDescriptor).Append("\n");
            sb.Append("  CohortTypeDescriptor: ").Append(CohortTypeDescriptor).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
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
            return this.Equals(input as EdFiCohort);
        }

        /// <summary>
        /// Returns true if EdFiCohort instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCohort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCohort input)
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
                    this.CohortIdentifier == input.CohortIdentifier ||
                    (this.CohortIdentifier != null &&
                    this.CohortIdentifier.Equals(input.CohortIdentifier))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.CohortDescription == input.CohortDescription ||
                    (this.CohortDescription != null &&
                    this.CohortDescription.Equals(input.CohortDescription))
                ) && 
                (
                    this.CohortScopeDescriptor == input.CohortScopeDescriptor ||
                    (this.CohortScopeDescriptor != null &&
                    this.CohortScopeDescriptor.Equals(input.CohortScopeDescriptor))
                ) && 
                (
                    this.CohortTypeDescriptor == input.CohortTypeDescriptor ||
                    (this.CohortTypeDescriptor != null &&
                    this.CohortTypeDescriptor.Equals(input.CohortTypeDescriptor))
                ) && 
                (
                    this.Programs == input.Programs ||
                    this.Programs != null &&
                    this.Programs.SequenceEqual(input.Programs)
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
                if (this.CohortIdentifier != null)
                    hashCode = hashCode * 59 + this.CohortIdentifier.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                if (this.CohortDescription != null)
                    hashCode = hashCode * 59 + this.CohortDescription.GetHashCode();
                if (this.CohortScopeDescriptor != null)
                    hashCode = hashCode * 59 + this.CohortScopeDescriptor.GetHashCode();
                if (this.CohortTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.CohortTypeDescriptor.GetHashCode();
                if (this.Programs != null)
                    hashCode = hashCode * 59 + this.Programs.GetHashCode();
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
            // CohortIdentifier (string) maxLength
            if(this.CohortIdentifier != null && this.CohortIdentifier.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CohortIdentifier, length must be less than 20.", new [] { "CohortIdentifier" });
            }

            // AcademicSubjectDescriptor (string) maxLength
            if(this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // CohortDescription (string) maxLength
            if(this.CohortDescription != null && this.CohortDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CohortDescription, length must be less than 1024.", new [] { "CohortDescription" });
            }

            // CohortScopeDescriptor (string) maxLength
            if(this.CohortScopeDescriptor != null && this.CohortScopeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CohortScopeDescriptor, length must be less than 306.", new [] { "CohortScopeDescriptor" });
            }

            // CohortTypeDescriptor (string) maxLength
            if(this.CohortTypeDescriptor != null && this.CohortTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CohortTypeDescriptor, length must be less than 306.", new [] { "CohortTypeDescriptor" });
            }

            yield break;
        }
    }

}
