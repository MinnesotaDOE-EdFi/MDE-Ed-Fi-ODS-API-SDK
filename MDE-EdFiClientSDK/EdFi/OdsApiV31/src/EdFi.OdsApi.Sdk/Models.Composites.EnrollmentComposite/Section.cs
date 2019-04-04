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
    /// Section
    /// </summary>
    [DataContract]
    public partial class Section :  IEquatable<Section>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Section() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="LocalCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="SectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="AcademicSubjectDescriptor">The intended major subject area of the course..</param>
        /// <param name="AvailableCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="ClassPeriods">An unordered collection of sectionClassPeriods. .</param>
        /// <param name="EducationalEnvironmentDescriptor">The setting in which a child receives education and related services; for example:          Center-based instruction          Home-based instruction          Hospital class          Mainstream          Residential care and treatment facility          ....</param>
        /// <param name="Location">Location.</param>
        /// <param name="LocationSchoolReference">LocationSchoolReference.</param>
        /// <param name="SequenceOfCourse">When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1..</param>
        /// <param name="Session">Session.</param>
        /// <param name="Staff">An unordered collection of staffSectionAssociations. .</param>
        /// <param name="Students">An unordered collection of studentSectionAssociations. .</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public Section(string Id = default(string), string LocalCourseCode = default(string), string SectionIdentifier = default(string), string AcademicSubjectDescriptor = default(string), double? AvailableCredits = default(double?), List<SectionSectionClassPeriod> ClassPeriods = default(List<SectionSectionClassPeriod>), string EducationalEnvironmentDescriptor = default(string), SectionLocation Location = default(SectionLocation), SectionSchool LocationSchoolReference = default(SectionSchool), int? SequenceOfCourse = default(int?), SectionSession Session = default(SectionSession), List<SectionStaffSectionAssociation> Staff = default(List<SectionStaffSectionAssociation>), List<SectionStudentSectionAssociation> Students = default(List<SectionStudentSectionAssociation>), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Section and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "LocalCourseCode" is required (not null)
            if (LocalCourseCode == null)
            {
                throw new InvalidDataException("LocalCourseCode is a required property for Section and cannot be null");
            }
            else
            {
                this.LocalCourseCode = LocalCourseCode;
            }
            // to ensure "SectionIdentifier" is required (not null)
            if (SectionIdentifier == null)
            {
                throw new InvalidDataException("SectionIdentifier is a required property for Section and cannot be null");
            }
            else
            {
                this.SectionIdentifier = SectionIdentifier;
            }
            this.AcademicSubjectDescriptor = AcademicSubjectDescriptor;
            this.AvailableCredits = AvailableCredits;
            this.ClassPeriods = ClassPeriods;
            this.EducationalEnvironmentDescriptor = EducationalEnvironmentDescriptor;
            this.Location = Location;
            this.LocationSchoolReference = LocationSchoolReference;
            this.SequenceOfCourse = SequenceOfCourse;
            this.Session = Session;
            this.Staff = Staff;
            this.Students = Students;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name="localCourseCode", EmitDefaultValue=false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name="sectionIdentifier", EmitDefaultValue=false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// The intended major subject area of the course.
        /// </summary>
        /// <value>The intended major subject area of the course.</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="availableCredits", EmitDefaultValue=false)]
        public double? AvailableCredits { get; set; }

        /// <summary>
        /// An unordered collection of sectionClassPeriods. 
        /// </summary>
        /// <value>An unordered collection of sectionClassPeriods. </value>
        [DataMember(Name="classPeriods", EmitDefaultValue=false)]
        public List<SectionSectionClassPeriod> ClassPeriods { get; set; }

        /// <summary>
        /// The setting in which a child receives education and related services; for example:          Center-based instruction          Home-based instruction          Hospital class          Mainstream          Residential care and treatment facility          ...
        /// </summary>
        /// <value>The setting in which a child receives education and related services; for example:          Center-based instruction          Home-based instruction          Hospital class          Mainstream          Residential care and treatment facility          ...</value>
        [DataMember(Name="educationalEnvironmentDescriptor", EmitDefaultValue=false)]
        public string EducationalEnvironmentDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public SectionLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets LocationSchoolReference
        /// </summary>
        [DataMember(Name="locationSchoolReference", EmitDefaultValue=false)]
        public SectionSchool LocationSchoolReference { get; set; }

        /// <summary>
        /// When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.
        /// </summary>
        /// <value>When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.</value>
        [DataMember(Name="sequenceOfCourse", EmitDefaultValue=false)]
        public int? SequenceOfCourse { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public SectionSession Session { get; set; }

        /// <summary>
        /// An unordered collection of staffSectionAssociations. 
        /// </summary>
        /// <value>An unordered collection of staffSectionAssociations. </value>
        [DataMember(Name="staff", EmitDefaultValue=false)]
        public List<SectionStaffSectionAssociation> Staff { get; set; }

        /// <summary>
        /// An unordered collection of studentSectionAssociations. 
        /// </summary>
        /// <value>An unordered collection of studentSectionAssociations. </value>
        [DataMember(Name="students", EmitDefaultValue=false)]
        public List<SectionStudentSectionAssociation> Students { get; set; }

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
            sb.Append("class Section {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  AvailableCredits: ").Append(AvailableCredits).Append("\n");
            sb.Append("  ClassPeriods: ").Append(ClassPeriods).Append("\n");
            sb.Append("  EducationalEnvironmentDescriptor: ").Append(EducationalEnvironmentDescriptor).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LocationSchoolReference: ").Append(LocationSchoolReference).Append("\n");
            sb.Append("  SequenceOfCourse: ").Append(SequenceOfCourse).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  Staff: ").Append(Staff).Append("\n");
            sb.Append("  Students: ").Append(Students).Append("\n");
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
            return this.Equals(input as Section);
        }

        /// <summary>
        /// Returns true if Section instances are equal
        /// </summary>
        /// <param name="input">Instance of Section to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Section input)
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
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.AvailableCredits == input.AvailableCredits ||
                    (this.AvailableCredits != null &&
                    this.AvailableCredits.Equals(input.AvailableCredits))
                ) && 
                (
                    this.ClassPeriods == input.ClassPeriods ||
                    this.ClassPeriods != null &&
                    this.ClassPeriods.SequenceEqual(input.ClassPeriods)
                ) && 
                (
                    this.EducationalEnvironmentDescriptor == input.EducationalEnvironmentDescriptor ||
                    (this.EducationalEnvironmentDescriptor != null &&
                    this.EducationalEnvironmentDescriptor.Equals(input.EducationalEnvironmentDescriptor))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.LocationSchoolReference == input.LocationSchoolReference ||
                    (this.LocationSchoolReference != null &&
                    this.LocationSchoolReference.Equals(input.LocationSchoolReference))
                ) && 
                (
                    this.SequenceOfCourse == input.SequenceOfCourse ||
                    (this.SequenceOfCourse != null &&
                    this.SequenceOfCourse.Equals(input.SequenceOfCourse))
                ) && 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                ) && 
                (
                    this.Staff == input.Staff ||
                    this.Staff != null &&
                    this.Staff.SequenceEqual(input.Staff)
                ) && 
                (
                    this.Students == input.Students ||
                    this.Students != null &&
                    this.Students.SequenceEqual(input.Students)
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
                if (this.LocalCourseCode != null)
                    hashCode = hashCode * 59 + this.LocalCourseCode.GetHashCode();
                if (this.SectionIdentifier != null)
                    hashCode = hashCode * 59 + this.SectionIdentifier.GetHashCode();
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                if (this.AvailableCredits != null)
                    hashCode = hashCode * 59 + this.AvailableCredits.GetHashCode();
                if (this.ClassPeriods != null)
                    hashCode = hashCode * 59 + this.ClassPeriods.GetHashCode();
                if (this.EducationalEnvironmentDescriptor != null)
                    hashCode = hashCode * 59 + this.EducationalEnvironmentDescriptor.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LocationSchoolReference != null)
                    hashCode = hashCode * 59 + this.LocationSchoolReference.GetHashCode();
                if (this.SequenceOfCourse != null)
                    hashCode = hashCode * 59 + this.SequenceOfCourse.GetHashCode();
                if (this.Session != null)
                    hashCode = hashCode * 59 + this.Session.GetHashCode();
                if (this.Staff != null)
                    hashCode = hashCode * 59 + this.Staff.GetHashCode();
                if (this.Students != null)
                    hashCode = hashCode * 59 + this.Students.GetHashCode();
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

            // AcademicSubjectDescriptor (string) maxLength
            if(this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // EducationalEnvironmentDescriptor (string) maxLength
            if(this.EducationalEnvironmentDescriptor != null && this.EducationalEnvironmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationalEnvironmentDescriptor, length must be less than 306.", new [] { "EducationalEnvironmentDescriptor" });
            }

            yield break;
        }
    }

}
