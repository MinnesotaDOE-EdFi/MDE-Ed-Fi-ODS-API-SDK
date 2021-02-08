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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentAssessmentReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAssessmentReadable :  IEquatable<EdFiStudentAssessmentReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAssessmentReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="StudentAssessmentIdentifier">A unique number or alphanumeric code assigned to an assessment administered to a student. (required).</param>
        /// <param name="AssessmentReference">AssessmentReference (required).</param>
        /// <param name="SchoolYearTypeReference">SchoolYearTypeReference.</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="Accommodations">An unordered collection of studentAssessmentAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:          Braille          Enlarged monitor view          Extra time          Large Print          Setting          Oral Administration          ....</param>
        /// <param name="AdministrationDate">The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. (required).</param>
        /// <param name="AdministrationEndDate">The date and time an assessment administration ended..</param>
        /// <param name="AdministrationEnvironmentDescriptor">The environment in which the test was administered. For example:          Electronic          Classroom          Testing Center          ....</param>
        /// <param name="AdministrationLanguageDescriptor">The language in which an assessment is written and/or administered..</param>
        /// <param name="EventCircumstanceDescriptor">An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc..</param>
        /// <param name="EventDescription">Describes special events that occur before during or after the assessment session that may impact use of results..</param>
        /// <param name="Items">An unordered collection of studentAssessmentItems. The student&#39;s response to an assessment item and the item-level scores such as correct, incorrect, or met standard..</param>
        /// <param name="PerformanceLevels">An unordered collection of studentAssessmentPerformanceLevels. The performance level(s) achieved for the StudentAssessment..</param>
        /// <param name="ReasonNotTestedDescriptor">The primary reason student is not tested. For example:          Absent          Refusal by parent          Refusal by student          Medical waiver          Illness          Disruptive behavior          LEP Exempt          ....</param>
        /// <param name="RetestIndicatorDescriptor">Indicator if the test was retaken. For example:          Primary administration          First retest          Second retest          ....</param>
        /// <param name="ScoreResults">An unordered collection of studentAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc..</param>
        /// <param name="SerialNumber">The unique number for the assessment form or answer document..</param>
        /// <param name="StudentObjectiveAssessments">An unordered collection of studentAssessmentStudentObjectiveAssessments. The student&#39;s score and/or performance levels earned for an ObjectiveAssessment..</param>
        /// <param name="WhenAssessedGradeLevelDescriptor">The grade level of a student when assessed..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="Ext">Ext.</param>
        public EdFiStudentAssessmentReadable(string Id = default(string), string StudentAssessmentIdentifier = default(string), EdFiAssessmentReference AssessmentReference = default(EdFiAssessmentReference), EdFiSchoolYearTypeReference SchoolYearTypeReference = default(EdFiSchoolYearTypeReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), List<EdFiStudentAssessmentAccommodationReadable> Accommodations = default(List<EdFiStudentAssessmentAccommodationReadable>), DateTime? AdministrationDate = default(DateTime?), DateTime? AdministrationEndDate = default(DateTime?), string AdministrationEnvironmentDescriptor = default(string), string AdministrationLanguageDescriptor = default(string), string EventCircumstanceDescriptor = default(string), string EventDescription = default(string), List<EdFiStudentAssessmentItemReadable> Items = default(List<EdFiStudentAssessmentItemReadable>), List<EdFiStudentAssessmentPerformanceLevelReadable> PerformanceLevels = default(List<EdFiStudentAssessmentPerformanceLevelReadable>), string ReasonNotTestedDescriptor = default(string), string RetestIndicatorDescriptor = default(string), List<EdFiStudentAssessmentScoreResultReadable> ScoreResults = default(List<EdFiStudentAssessmentScoreResultReadable>), string SerialNumber = default(string), List<EdFiStudentAssessmentStudentObjectiveAssessmentReadable> StudentObjectiveAssessments = default(List<EdFiStudentAssessmentStudentObjectiveAssessmentReadable>), string WhenAssessedGradeLevelDescriptor = default(string), string Etag = default(string), StudentAssessmentExtensionsReadable Ext = default(StudentAssessmentExtensionsReadable))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStudentAssessmentReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "StudentAssessmentIdentifier" is required (not null)
            if (StudentAssessmentIdentifier == null)
            {
                throw new InvalidDataException("StudentAssessmentIdentifier is a required property for EdFiStudentAssessmentReadable and cannot be null");
            }
            else
            {
                this.StudentAssessmentIdentifier = StudentAssessmentIdentifier;
            }
            // to ensure "AssessmentReference" is required (not null)
            if (AssessmentReference == null)
            {
                throw new InvalidDataException("AssessmentReference is a required property for EdFiStudentAssessmentReadable and cannot be null");
            }
            else
            {
                this.AssessmentReference = AssessmentReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiStudentAssessmentReadable and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            // to ensure "AdministrationDate" is required (not null)
            if (AdministrationDate == null)
            {
                throw new InvalidDataException("AdministrationDate is a required property for EdFiStudentAssessmentReadable and cannot be null");
            }
            else
            {
                this.AdministrationDate = AdministrationDate;
            }
            this.SchoolYearTypeReference = SchoolYearTypeReference;
            this.Accommodations = Accommodations;
            this.AdministrationEndDate = AdministrationEndDate;
            this.AdministrationEnvironmentDescriptor = AdministrationEnvironmentDescriptor;
            this.AdministrationLanguageDescriptor = AdministrationLanguageDescriptor;
            this.EventCircumstanceDescriptor = EventCircumstanceDescriptor;
            this.EventDescription = EventDescription;
            this.Items = Items;
            this.PerformanceLevels = PerformanceLevels;
            this.ReasonNotTestedDescriptor = ReasonNotTestedDescriptor;
            this.RetestIndicatorDescriptor = RetestIndicatorDescriptor;
            this.ScoreResults = ScoreResults;
            this.SerialNumber = SerialNumber;
            this.StudentObjectiveAssessments = StudentObjectiveAssessments;
            this.WhenAssessedGradeLevelDescriptor = WhenAssessedGradeLevelDescriptor;
            this.Etag = Etag;
            this.Ext = Ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment administered to a student.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment administered to a student.</value>
        [DataMember(Name="studentAssessmentIdentifier", EmitDefaultValue=false)]
        public string StudentAssessmentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AssessmentReference
        /// </summary>
        [DataMember(Name="assessmentReference", EmitDefaultValue=false)]
        public EdFiAssessmentReference AssessmentReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name="schoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:          Braille          Enlarged monitor view          Extra time          Large Print          Setting          Oral Administration          ...
        /// </summary>
        /// <value>An unordered collection of studentAssessmentAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:          Braille          Enlarged monitor view          Extra time          Large Print          Setting          Oral Administration          ...</value>
        [DataMember(Name="accommodations", EmitDefaultValue=false)]
        public List<EdFiStudentAssessmentAccommodationReadable> Accommodations { get; set; }

        /// <summary>
        /// The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones.
        /// </summary>
        /// <value>The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones.</value>
        [DataMember(Name="administrationDate", EmitDefaultValue=false)]
        public DateTime? AdministrationDate { get; set; }

        /// <summary>
        /// The date and time an assessment administration ended.
        /// </summary>
        /// <value>The date and time an assessment administration ended.</value>
        [DataMember(Name="administrationEndDate", EmitDefaultValue=false)]
        public DateTime? AdministrationEndDate { get; set; }

        /// <summary>
        /// The environment in which the test was administered. For example:          Electronic          Classroom          Testing Center          ...
        /// </summary>
        /// <value>The environment in which the test was administered. For example:          Electronic          Classroom          Testing Center          ...</value>
        [DataMember(Name="administrationEnvironmentDescriptor", EmitDefaultValue=false)]
        public string AdministrationEnvironmentDescriptor { get; set; }

        /// <summary>
        /// The language in which an assessment is written and/or administered.
        /// </summary>
        /// <value>The language in which an assessment is written and/or administered.</value>
        [DataMember(Name="administrationLanguageDescriptor", EmitDefaultValue=false)]
        public string AdministrationLanguageDescriptor { get; set; }

        /// <summary>
        /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
        /// </summary>
        /// <value>An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.</value>
        [DataMember(Name="eventCircumstanceDescriptor", EmitDefaultValue=false)]
        public string EventCircumstanceDescriptor { get; set; }

        /// <summary>
        /// Describes special events that occur before during or after the assessment session that may impact use of results.
        /// </summary>
        /// <value>Describes special events that occur before during or after the assessment session that may impact use of results.</value>
        [DataMember(Name="eventDescription", EmitDefaultValue=false)]
        public string EventDescription { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentItems. The student&#39;s response to an assessment item and the item-level scores such as correct, incorrect, or met standard.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentItems. The student&#39;s response to an assessment item and the item-level scores such as correct, incorrect, or met standard.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<EdFiStudentAssessmentItemReadable> Items { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentPerformanceLevels. The performance level(s) achieved for the StudentAssessment.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentPerformanceLevels. The performance level(s) achieved for the StudentAssessment.</value>
        [DataMember(Name="performanceLevels", EmitDefaultValue=false)]
        public List<EdFiStudentAssessmentPerformanceLevelReadable> PerformanceLevels { get; set; }

        /// <summary>
        /// The primary reason student is not tested. For example:          Absent          Refusal by parent          Refusal by student          Medical waiver          Illness          Disruptive behavior          LEP Exempt          ...
        /// </summary>
        /// <value>The primary reason student is not tested. For example:          Absent          Refusal by parent          Refusal by student          Medical waiver          Illness          Disruptive behavior          LEP Exempt          ...</value>
        [DataMember(Name="reasonNotTestedDescriptor", EmitDefaultValue=false)]
        public string ReasonNotTestedDescriptor { get; set; }

        /// <summary>
        /// Indicator if the test was retaken. For example:          Primary administration          First retest          Second retest          ...
        /// </summary>
        /// <value>Indicator if the test was retaken. For example:          Primary administration          First retest          Second retest          ...</value>
        [DataMember(Name="retestIndicatorDescriptor", EmitDefaultValue=false)]
        public string RetestIndicatorDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.</value>
        [DataMember(Name="scoreResults", EmitDefaultValue=false)]
        public List<EdFiStudentAssessmentScoreResultReadable> ScoreResults { get; set; }

        /// <summary>
        /// The unique number for the assessment form or answer document.
        /// </summary>
        /// <value>The unique number for the assessment form or answer document.</value>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentStudentObjectiveAssessments. The student&#39;s score and/or performance levels earned for an ObjectiveAssessment.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentStudentObjectiveAssessments. The student&#39;s score and/or performance levels earned for an ObjectiveAssessment.</value>
        [DataMember(Name="studentObjectiveAssessments", EmitDefaultValue=false)]
        public List<EdFiStudentAssessmentStudentObjectiveAssessmentReadable> StudentObjectiveAssessments { get; set; }

        /// <summary>
        /// The grade level of a student when assessed.
        /// </summary>
        /// <value>The grade level of a student when assessed.</value>
        [DataMember(Name="whenAssessedGradeLevelDescriptor", EmitDefaultValue=false)]
        public string WhenAssessedGradeLevelDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public StudentAssessmentExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StudentAssessmentIdentifier: ").Append(StudentAssessmentIdentifier).Append("\n");
            sb.Append("  AssessmentReference: ").Append(AssessmentReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  Accommodations: ").Append(Accommodations).Append("\n");
            sb.Append("  AdministrationDate: ").Append(AdministrationDate).Append("\n");
            sb.Append("  AdministrationEndDate: ").Append(AdministrationEndDate).Append("\n");
            sb.Append("  AdministrationEnvironmentDescriptor: ").Append(AdministrationEnvironmentDescriptor).Append("\n");
            sb.Append("  AdministrationLanguageDescriptor: ").Append(AdministrationLanguageDescriptor).Append("\n");
            sb.Append("  EventCircumstanceDescriptor: ").Append(EventCircumstanceDescriptor).Append("\n");
            sb.Append("  EventDescription: ").Append(EventDescription).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  PerformanceLevels: ").Append(PerformanceLevels).Append("\n");
            sb.Append("  ReasonNotTestedDescriptor: ").Append(ReasonNotTestedDescriptor).Append("\n");
            sb.Append("  RetestIndicatorDescriptor: ").Append(RetestIndicatorDescriptor).Append("\n");
            sb.Append("  ScoreResults: ").Append(ScoreResults).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  StudentObjectiveAssessments: ").Append(StudentObjectiveAssessments).Append("\n");
            sb.Append("  WhenAssessedGradeLevelDescriptor: ").Append(WhenAssessedGradeLevelDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiStudentAssessmentReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentAssessmentReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAssessmentReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAssessmentReadable input)
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
                    this.StudentAssessmentIdentifier == input.StudentAssessmentIdentifier ||
                    (this.StudentAssessmentIdentifier != null &&
                    this.StudentAssessmentIdentifier.Equals(input.StudentAssessmentIdentifier))
                ) && 
                (
                    this.AssessmentReference == input.AssessmentReference ||
                    (this.AssessmentReference != null &&
                    this.AssessmentReference.Equals(input.AssessmentReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.Accommodations == input.Accommodations ||
                    this.Accommodations != null &&
                    this.Accommodations.SequenceEqual(input.Accommodations)
                ) && 
                (
                    this.AdministrationDate == input.AdministrationDate ||
                    (this.AdministrationDate != null &&
                    this.AdministrationDate.Equals(input.AdministrationDate))
                ) && 
                (
                    this.AdministrationEndDate == input.AdministrationEndDate ||
                    (this.AdministrationEndDate != null &&
                    this.AdministrationEndDate.Equals(input.AdministrationEndDate))
                ) && 
                (
                    this.AdministrationEnvironmentDescriptor == input.AdministrationEnvironmentDescriptor ||
                    (this.AdministrationEnvironmentDescriptor != null &&
                    this.AdministrationEnvironmentDescriptor.Equals(input.AdministrationEnvironmentDescriptor))
                ) && 
                (
                    this.AdministrationLanguageDescriptor == input.AdministrationLanguageDescriptor ||
                    (this.AdministrationLanguageDescriptor != null &&
                    this.AdministrationLanguageDescriptor.Equals(input.AdministrationLanguageDescriptor))
                ) && 
                (
                    this.EventCircumstanceDescriptor == input.EventCircumstanceDescriptor ||
                    (this.EventCircumstanceDescriptor != null &&
                    this.EventCircumstanceDescriptor.Equals(input.EventCircumstanceDescriptor))
                ) && 
                (
                    this.EventDescription == input.EventDescription ||
                    (this.EventDescription != null &&
                    this.EventDescription.Equals(input.EventDescription))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.PerformanceLevels == input.PerformanceLevels ||
                    this.PerformanceLevels != null &&
                    this.PerformanceLevels.SequenceEqual(input.PerformanceLevels)
                ) && 
                (
                    this.ReasonNotTestedDescriptor == input.ReasonNotTestedDescriptor ||
                    (this.ReasonNotTestedDescriptor != null &&
                    this.ReasonNotTestedDescriptor.Equals(input.ReasonNotTestedDescriptor))
                ) && 
                (
                    this.RetestIndicatorDescriptor == input.RetestIndicatorDescriptor ||
                    (this.RetestIndicatorDescriptor != null &&
                    this.RetestIndicatorDescriptor.Equals(input.RetestIndicatorDescriptor))
                ) && 
                (
                    this.ScoreResults == input.ScoreResults ||
                    this.ScoreResults != null &&
                    this.ScoreResults.SequenceEqual(input.ScoreResults)
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.StudentObjectiveAssessments == input.StudentObjectiveAssessments ||
                    this.StudentObjectiveAssessments != null &&
                    this.StudentObjectiveAssessments.SequenceEqual(input.StudentObjectiveAssessments)
                ) && 
                (
                    this.WhenAssessedGradeLevelDescriptor == input.WhenAssessedGradeLevelDescriptor ||
                    (this.WhenAssessedGradeLevelDescriptor != null &&
                    this.WhenAssessedGradeLevelDescriptor.Equals(input.WhenAssessedGradeLevelDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.StudentAssessmentIdentifier != null)
                    hashCode = hashCode * 59 + this.StudentAssessmentIdentifier.GetHashCode();
                if (this.AssessmentReference != null)
                    hashCode = hashCode * 59 + this.AssessmentReference.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.Accommodations != null)
                    hashCode = hashCode * 59 + this.Accommodations.GetHashCode();
                if (this.AdministrationDate != null)
                    hashCode = hashCode * 59 + this.AdministrationDate.GetHashCode();
                if (this.AdministrationEndDate != null)
                    hashCode = hashCode * 59 + this.AdministrationEndDate.GetHashCode();
                if (this.AdministrationEnvironmentDescriptor != null)
                    hashCode = hashCode * 59 + this.AdministrationEnvironmentDescriptor.GetHashCode();
                if (this.AdministrationLanguageDescriptor != null)
                    hashCode = hashCode * 59 + this.AdministrationLanguageDescriptor.GetHashCode();
                if (this.EventCircumstanceDescriptor != null)
                    hashCode = hashCode * 59 + this.EventCircumstanceDescriptor.GetHashCode();
                if (this.EventDescription != null)
                    hashCode = hashCode * 59 + this.EventDescription.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.PerformanceLevels != null)
                    hashCode = hashCode * 59 + this.PerformanceLevels.GetHashCode();
                if (this.ReasonNotTestedDescriptor != null)
                    hashCode = hashCode * 59 + this.ReasonNotTestedDescriptor.GetHashCode();
                if (this.RetestIndicatorDescriptor != null)
                    hashCode = hashCode * 59 + this.RetestIndicatorDescriptor.GetHashCode();
                if (this.ScoreResults != null)
                    hashCode = hashCode * 59 + this.ScoreResults.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.StudentObjectiveAssessments != null)
                    hashCode = hashCode * 59 + this.StudentObjectiveAssessments.GetHashCode();
                if (this.WhenAssessedGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.WhenAssessedGradeLevelDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
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
            // StudentAssessmentIdentifier (string) maxLength
            if(this.StudentAssessmentIdentifier != null && this.StudentAssessmentIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentAssessmentIdentifier, length must be less than 60.", new [] { "StudentAssessmentIdentifier" });
            }

            // AdministrationEnvironmentDescriptor (string) maxLength
            if(this.AdministrationEnvironmentDescriptor != null && this.AdministrationEnvironmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrationEnvironmentDescriptor, length must be less than 306.", new [] { "AdministrationEnvironmentDescriptor" });
            }

            // AdministrationLanguageDescriptor (string) maxLength
            if(this.AdministrationLanguageDescriptor != null && this.AdministrationLanguageDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrationLanguageDescriptor, length must be less than 306.", new [] { "AdministrationLanguageDescriptor" });
            }

            // EventCircumstanceDescriptor (string) maxLength
            if(this.EventCircumstanceDescriptor != null && this.EventCircumstanceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventCircumstanceDescriptor, length must be less than 306.", new [] { "EventCircumstanceDescriptor" });
            }

            // EventDescription (string) maxLength
            if(this.EventDescription != null && this.EventDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventDescription, length must be less than 1024.", new [] { "EventDescription" });
            }

            // ReasonNotTestedDescriptor (string) maxLength
            if(this.ReasonNotTestedDescriptor != null && this.ReasonNotTestedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReasonNotTestedDescriptor, length must be less than 306.", new [] { "ReasonNotTestedDescriptor" });
            }

            // RetestIndicatorDescriptor (string) maxLength
            if(this.RetestIndicatorDescriptor != null && this.RetestIndicatorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RetestIndicatorDescriptor, length must be less than 306.", new [] { "RetestIndicatorDescriptor" });
            }

            // SerialNumber (string) maxLength
            if(this.SerialNumber != null && this.SerialNumber.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SerialNumber, length must be less than 60.", new [] { "SerialNumber" });
            }

            // WhenAssessedGradeLevelDescriptor (string) maxLength
            if(this.WhenAssessedGradeLevelDescriptor != null && this.WhenAssessedGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WhenAssessedGradeLevelDescriptor, length must be less than 306.", new [] { "WhenAssessedGradeLevelDescriptor" });
            }

            yield break;
        }
    }

}
