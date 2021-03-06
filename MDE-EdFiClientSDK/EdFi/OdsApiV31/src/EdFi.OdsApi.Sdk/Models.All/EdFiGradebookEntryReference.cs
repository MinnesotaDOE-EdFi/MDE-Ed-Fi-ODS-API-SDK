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
    /// EdFiGradebookEntryReference
    /// </summary>
    [DataContract]
    public partial class EdFiGradebookEntryReference :  IEquatable<EdFiGradebookEntryReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGradebookEntryReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradebookEntryReference" /> class.
        /// </summary>
        /// <param name="DateAssigned">The date the assignment, homework, or assessment was assigned or executed. (required).</param>
        /// <param name="GradebookEntryTitle">The name or title of the activity to be recorded in the GradebookEntry. (required).</param>
        /// <param name="LocalCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="SchoolId">The identifier assigned to a school. (required).</param>
        /// <param name="SchoolYear">The identifier for the school year. (required).</param>
        /// <param name="SectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="SessionName">The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (required).</param>
        /// <param name="Link">Link.</param>
        public EdFiGradebookEntryReference(DateTime? DateAssigned = default(DateTime?), string GradebookEntryTitle = default(string), string LocalCourseCode = default(string), int? SchoolId = default(int?), int? SchoolYear = default(int?), string SectionIdentifier = default(string), string SessionName = default(string), Link Link = default(Link))
        {
            // to ensure "DateAssigned" is required (not null)
            if (DateAssigned == null)
            {
                throw new InvalidDataException("DateAssigned is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.DateAssigned = DateAssigned;
            }
            // to ensure "GradebookEntryTitle" is required (not null)
            if (GradebookEntryTitle == null)
            {
                throw new InvalidDataException("GradebookEntryTitle is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.GradebookEntryTitle = GradebookEntryTitle;
            }
            // to ensure "LocalCourseCode" is required (not null)
            if (LocalCourseCode == null)
            {
                throw new InvalidDataException("LocalCourseCode is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.LocalCourseCode = LocalCourseCode;
            }
            // to ensure "SchoolId" is required (not null)
            if (SchoolId == null)
            {
                throw new InvalidDataException("SchoolId is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SchoolId = SchoolId;
            }
            // to ensure "SchoolYear" is required (not null)
            if (SchoolYear == null)
            {
                throw new InvalidDataException("SchoolYear is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SchoolYear = SchoolYear;
            }
            // to ensure "SectionIdentifier" is required (not null)
            if (SectionIdentifier == null)
            {
                throw new InvalidDataException("SectionIdentifier is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SectionIdentifier = SectionIdentifier;
            }
            // to ensure "SessionName" is required (not null)
            if (SessionName == null)
            {
                throw new InvalidDataException("SessionName is a required property for EdFiGradebookEntryReference and cannot be null");
            }
            else
            {
                this.SessionName = SessionName;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// The date the assignment, homework, or assessment was assigned or executed.
        /// </summary>
        /// <value>The date the assignment, homework, or assessment was assigned or executed.</value>
        [DataMember(Name="dateAssigned", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateAssigned { get; set; }

        /// <summary>
        /// The name or title of the activity to be recorded in the GradebookEntry.
        /// </summary>
        /// <value>The name or title of the activity to be recorded in the GradebookEntry.</value>
        [DataMember(Name="gradebookEntryTitle", EmitDefaultValue=false)]
        public string GradebookEntryTitle { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name="localCourseCode", EmitDefaultValue=false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name="schoolYear", EmitDefaultValue=false)]
        public int? SchoolYear { get; set; }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name="sectionIdentifier", EmitDefaultValue=false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).
        /// </summary>
        /// <value>The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).</value>
        [DataMember(Name="sessionName", EmitDefaultValue=false)]
        public string SessionName { get; set; }

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
            sb.Append("class EdFiGradebookEntryReference {\n");
            sb.Append("  DateAssigned: ").Append(DateAssigned).Append("\n");
            sb.Append("  GradebookEntryTitle: ").Append(GradebookEntryTitle).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
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
            return this.Equals(input as EdFiGradebookEntryReference);
        }

        /// <summary>
        /// Returns true if EdFiGradebookEntryReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGradebookEntryReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGradebookEntryReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateAssigned == input.DateAssigned ||
                    (this.DateAssigned != null &&
                    this.DateAssigned.Equals(input.DateAssigned))
                ) && 
                (
                    this.GradebookEntryTitle == input.GradebookEntryTitle ||
                    (this.GradebookEntryTitle != null &&
                    this.GradebookEntryTitle.Equals(input.GradebookEntryTitle))
                ) && 
                (
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    (this.SchoolYear != null &&
                    this.SchoolYear.Equals(input.SchoolYear))
                ) && 
                (
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
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
                if (this.DateAssigned != null)
                    hashCode = hashCode * 59 + this.DateAssigned.GetHashCode();
                if (this.GradebookEntryTitle != null)
                    hashCode = hashCode * 59 + this.GradebookEntryTitle.GetHashCode();
                if (this.LocalCourseCode != null)
                    hashCode = hashCode * 59 + this.LocalCourseCode.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.SchoolYear != null)
                    hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
                if (this.SectionIdentifier != null)
                    hashCode = hashCode * 59 + this.SectionIdentifier.GetHashCode();
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
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
            // GradebookEntryTitle (string) maxLength
            if(this.GradebookEntryTitle != null && this.GradebookEntryTitle.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradebookEntryTitle, length must be less than 60.", new [] { "GradebookEntryTitle" });
            }

            // LocalCourseCode (string) maxLength
            if(this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            // SectionIdentifier (string) maxLength
            if(this.SectionIdentifier != null && this.SectionIdentifier.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be less than 255.", new [] { "SectionIdentifier" });
            }

            // SessionName (string) maxLength
            if(this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
            }

            yield break;
        }
    }

}
