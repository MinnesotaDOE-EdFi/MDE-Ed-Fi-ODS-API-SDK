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
    /// EdFiReportCard
    /// </summary>
    [DataContract]
    public partial class EdFiReportCard :  IEquatable<EdFiReportCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiReportCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCard" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="GradingPeriodReference">GradingPeriodReference (required).</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="GpaCumulative">A measure of cumulative average performance in all courses taken by an individual from the beginning of the school year through the current grading period..</param>
        /// <param name="GpaGivenGradingPeriod">A measure of average performance in all courses taken by an individual for the current grading period..</param>
        /// <param name="Grades">An unordered collection of reportCardGrades. Grades for the classes attended by the Student for this grading period..</param>
        /// <param name="NumberOfDaysAbsent">The number of days an individual is absent when school is in session during a given reporting period..</param>
        /// <param name="NumberOfDaysInAttendance">The number of days an individual is present when school is in session during a given reporting period..</param>
        /// <param name="NumberOfDaysTardy">The number of days an individual is tardy during a given reporting period..</param>
        /// <param name="StudentCompetencyObjectives">An unordered collection of reportCardStudentCompetencyObjectives. The Student competency evaluations associated for this grading period..</param>
        /// <param name="StudentLearningObjectives">An unordered collection of reportCardStudentLearningObjectives. The StudentLearningObjective evaluations associated for this grading period..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiReportCard(string Id = default(string), EdFiEducationOrganizationReference EducationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiGradingPeriodReference GradingPeriodReference = default(EdFiGradingPeriodReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), double? GpaCumulative = default(double?), double? GpaGivenGradingPeriod = default(double?), List<EdFiReportCardGrade> Grades = default(List<EdFiReportCardGrade>), double? NumberOfDaysAbsent = default(double?), double? NumberOfDaysInAttendance = default(double?), int? NumberOfDaysTardy = default(int?), List<EdFiReportCardStudentCompetencyObjective> StudentCompetencyObjectives = default(List<EdFiReportCardStudentCompetencyObjective>), List<EdFiReportCardStudentLearningObjective> StudentLearningObjectives = default(List<EdFiReportCardStudentLearningObjective>), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiReportCard and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for EdFiReportCard and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "GradingPeriodReference" is required (not null)
            if (GradingPeriodReference == null)
            {
                throw new InvalidDataException("GradingPeriodReference is a required property for EdFiReportCard and cannot be null");
            }
            else
            {
                this.GradingPeriodReference = GradingPeriodReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiReportCard and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            this.GpaCumulative = GpaCumulative;
            this.GpaGivenGradingPeriod = GpaGivenGradingPeriod;
            this.Grades = Grades;
            this.NumberOfDaysAbsent = NumberOfDaysAbsent;
            this.NumberOfDaysInAttendance = NumberOfDaysInAttendance;
            this.NumberOfDaysTardy = NumberOfDaysTardy;
            this.StudentCompetencyObjectives = StudentCompetencyObjectives;
            this.StudentLearningObjectives = StudentLearningObjectives;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets GradingPeriodReference
        /// </summary>
        [DataMember(Name="gradingPeriodReference", EmitDefaultValue=false)]
        public EdFiGradingPeriodReference GradingPeriodReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// A measure of cumulative average performance in all courses taken by an individual from the beginning of the school year through the current grading period.
        /// </summary>
        /// <value>A measure of cumulative average performance in all courses taken by an individual from the beginning of the school year through the current grading period.</value>
        [DataMember(Name="gpaCumulative", EmitDefaultValue=false)]
        public double? GpaCumulative { get; set; }

        /// <summary>
        /// A measure of average performance in all courses taken by an individual for the current grading period.
        /// </summary>
        /// <value>A measure of average performance in all courses taken by an individual for the current grading period.</value>
        [DataMember(Name="gpaGivenGradingPeriod", EmitDefaultValue=false)]
        public double? GpaGivenGradingPeriod { get; set; }

        /// <summary>
        /// An unordered collection of reportCardGrades. Grades for the classes attended by the Student for this grading period.
        /// </summary>
        /// <value>An unordered collection of reportCardGrades. Grades for the classes attended by the Student for this grading period.</value>
        [DataMember(Name="grades", EmitDefaultValue=false)]
        public List<EdFiReportCardGrade> Grades { get; set; }

        /// <summary>
        /// The number of days an individual is absent when school is in session during a given reporting period.
        /// </summary>
        /// <value>The number of days an individual is absent when school is in session during a given reporting period.</value>
        [DataMember(Name="numberOfDaysAbsent", EmitDefaultValue=false)]
        public double? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// The number of days an individual is present when school is in session during a given reporting period.
        /// </summary>
        /// <value>The number of days an individual is present when school is in session during a given reporting period.</value>
        [DataMember(Name="numberOfDaysInAttendance", EmitDefaultValue=false)]
        public double? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// The number of days an individual is tardy during a given reporting period.
        /// </summary>
        /// <value>The number of days an individual is tardy during a given reporting period.</value>
        [DataMember(Name="numberOfDaysTardy", EmitDefaultValue=false)]
        public int? NumberOfDaysTardy { get; set; }

        /// <summary>
        /// An unordered collection of reportCardStudentCompetencyObjectives. The Student competency evaluations associated for this grading period.
        /// </summary>
        /// <value>An unordered collection of reportCardStudentCompetencyObjectives. The Student competency evaluations associated for this grading period.</value>
        [DataMember(Name="studentCompetencyObjectives", EmitDefaultValue=false)]
        public List<EdFiReportCardStudentCompetencyObjective> StudentCompetencyObjectives { get; set; }

        /// <summary>
        /// An unordered collection of reportCardStudentLearningObjectives. The StudentLearningObjective evaluations associated for this grading period.
        /// </summary>
        /// <value>An unordered collection of reportCardStudentLearningObjectives. The StudentLearningObjective evaluations associated for this grading period.</value>
        [DataMember(Name="studentLearningObjectives", EmitDefaultValue=false)]
        public List<EdFiReportCardStudentLearningObjective> StudentLearningObjectives { get; set; }

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
            sb.Append("class EdFiReportCard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  GradingPeriodReference: ").Append(GradingPeriodReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  GpaCumulative: ").Append(GpaCumulative).Append("\n");
            sb.Append("  GpaGivenGradingPeriod: ").Append(GpaGivenGradingPeriod).Append("\n");
            sb.Append("  Grades: ").Append(Grades).Append("\n");
            sb.Append("  NumberOfDaysAbsent: ").Append(NumberOfDaysAbsent).Append("\n");
            sb.Append("  NumberOfDaysInAttendance: ").Append(NumberOfDaysInAttendance).Append("\n");
            sb.Append("  NumberOfDaysTardy: ").Append(NumberOfDaysTardy).Append("\n");
            sb.Append("  StudentCompetencyObjectives: ").Append(StudentCompetencyObjectives).Append("\n");
            sb.Append("  StudentLearningObjectives: ").Append(StudentLearningObjectives).Append("\n");
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
            return this.Equals(input as EdFiReportCard);
        }

        /// <summary>
        /// Returns true if EdFiReportCard instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiReportCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiReportCard input)
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
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.GradingPeriodReference == input.GradingPeriodReference ||
                    (this.GradingPeriodReference != null &&
                    this.GradingPeriodReference.Equals(input.GradingPeriodReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.GpaCumulative == input.GpaCumulative ||
                    (this.GpaCumulative != null &&
                    this.GpaCumulative.Equals(input.GpaCumulative))
                ) && 
                (
                    this.GpaGivenGradingPeriod == input.GpaGivenGradingPeriod ||
                    (this.GpaGivenGradingPeriod != null &&
                    this.GpaGivenGradingPeriod.Equals(input.GpaGivenGradingPeriod))
                ) && 
                (
                    this.Grades == input.Grades ||
                    this.Grades != null &&
                    this.Grades.SequenceEqual(input.Grades)
                ) && 
                (
                    this.NumberOfDaysAbsent == input.NumberOfDaysAbsent ||
                    (this.NumberOfDaysAbsent != null &&
                    this.NumberOfDaysAbsent.Equals(input.NumberOfDaysAbsent))
                ) && 
                (
                    this.NumberOfDaysInAttendance == input.NumberOfDaysInAttendance ||
                    (this.NumberOfDaysInAttendance != null &&
                    this.NumberOfDaysInAttendance.Equals(input.NumberOfDaysInAttendance))
                ) && 
                (
                    this.NumberOfDaysTardy == input.NumberOfDaysTardy ||
                    (this.NumberOfDaysTardy != null &&
                    this.NumberOfDaysTardy.Equals(input.NumberOfDaysTardy))
                ) && 
                (
                    this.StudentCompetencyObjectives == input.StudentCompetencyObjectives ||
                    this.StudentCompetencyObjectives != null &&
                    this.StudentCompetencyObjectives.SequenceEqual(input.StudentCompetencyObjectives)
                ) && 
                (
                    this.StudentLearningObjectives == input.StudentLearningObjectives ||
                    this.StudentLearningObjectives != null &&
                    this.StudentLearningObjectives.SequenceEqual(input.StudentLearningObjectives)
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
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.GradingPeriodReference != null)
                    hashCode = hashCode * 59 + this.GradingPeriodReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.GpaCumulative != null)
                    hashCode = hashCode * 59 + this.GpaCumulative.GetHashCode();
                if (this.GpaGivenGradingPeriod != null)
                    hashCode = hashCode * 59 + this.GpaGivenGradingPeriod.GetHashCode();
                if (this.Grades != null)
                    hashCode = hashCode * 59 + this.Grades.GetHashCode();
                if (this.NumberOfDaysAbsent != null)
                    hashCode = hashCode * 59 + this.NumberOfDaysAbsent.GetHashCode();
                if (this.NumberOfDaysInAttendance != null)
                    hashCode = hashCode * 59 + this.NumberOfDaysInAttendance.GetHashCode();
                if (this.NumberOfDaysTardy != null)
                    hashCode = hashCode * 59 + this.NumberOfDaysTardy.GetHashCode();
                if (this.StudentCompetencyObjectives != null)
                    hashCode = hashCode * 59 + this.StudentCompetencyObjectives.GetHashCode();
                if (this.StudentLearningObjectives != null)
                    hashCode = hashCode * 59 + this.StudentLearningObjectives.GetHashCode();
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
            yield break;
        }
    }

}
