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
    /// EdFiIntervention
    /// </summary>
    [DataContract]
    public partial class EdFiIntervention :  IEquatable<EdFiIntervention>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiIntervention" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiIntervention() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiIntervention" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="InterventionIdentificationCode">A unique number or alphanumeric code assigned to an intervention. (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="AppropriateGradeLevels">An unordered collection of interventionAppropriateGradeLevels. Grade levels for the Intervention-if omitted, considered generally applicable..</param>
        /// <param name="AppropriateSexes">An unordered collection of interventionAppropriateSexes. Sexes for the Intervention. If omitted, considered generally applicable..</param>
        /// <param name="BeginDate">The start date for the intervention implementation. (required).</param>
        /// <param name="DeliveryMethodDescriptor">The way in which an intervention was implemented: individual, small group, whole class, or whole school. (required).</param>
        /// <param name="Diagnoses">An unordered collection of interventionDiagnoses. Targeted purpose of the Intervention (e.g., attendance issue, dropout risk)..</param>
        /// <param name="EducationContents">An unordered collection of interventionEducationContents. Relates the education content source to the education content..</param>
        /// <param name="EndDate">The end date for the intervention implementation..</param>
        /// <param name="InterventionClassDescriptor">The way in which an intervention is used: curriculum, supplement, or practice. (required).</param>
        /// <param name="InterventionPrescriptions">An unordered collection of interventionInterventionPrescriptions. The reference to the intervention prescription being followed in this intervention implementation..</param>
        /// <param name="LearningResourceMetadataURIs">An unordered collection of interventionLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item..</param>
        /// <param name="MaxDosage">The maximum duration of time in minutes that may be assigned for the intervention..</param>
        /// <param name="MeetingTimes">An unordered collection of interventionMeetingTimes. The times at which this intervention is scheduled to meet..</param>
        /// <param name="MinDosage">The minimum duration of time in minutes that may be assigned for the intervention..</param>
        /// <param name="PopulationServeds">An unordered collection of interventionPopulationServeds. A subset of students that are the focus of the Intervention..</param>
        /// <param name="Staffs">An unordered collection of interventionStaffs. Relates the staff member associated with the Intervention..</param>
        /// <param name="Uris">An unordered collection of interventionURIs. The URI (typical a URL) pointing to an education content item..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiIntervention(string Id = default(string), string InterventionIdentificationCode = default(string), EdFiEducationOrganizationReference EducationOrganizationReference = default(EdFiEducationOrganizationReference), List<EdFiInterventionAppropriateGradeLevel> AppropriateGradeLevels = default(List<EdFiInterventionAppropriateGradeLevel>), List<EdFiInterventionAppropriateSex> AppropriateSexes = default(List<EdFiInterventionAppropriateSex>), DateTime? BeginDate = default(DateTime?), string DeliveryMethodDescriptor = default(string), List<EdFiInterventionDiagnosis> Diagnoses = default(List<EdFiInterventionDiagnosis>), List<EdFiInterventionEducationContent> EducationContents = default(List<EdFiInterventionEducationContent>), DateTime? EndDate = default(DateTime?), string InterventionClassDescriptor = default(string), List<EdFiInterventionInterventionPrescription> InterventionPrescriptions = default(List<EdFiInterventionInterventionPrescription>), List<EdFiInterventionLearningResourceMetadataURI> LearningResourceMetadataURIs = default(List<EdFiInterventionLearningResourceMetadataURI>), int? MaxDosage = default(int?), List<EdFiInterventionMeetingTime> MeetingTimes = default(List<EdFiInterventionMeetingTime>), int? MinDosage = default(int?), List<EdFiInterventionPopulationServed> PopulationServeds = default(List<EdFiInterventionPopulationServed>), List<EdFiInterventionStaff> Staffs = default(List<EdFiInterventionStaff>), List<EdFiInterventionURI> Uris = default(List<EdFiInterventionURI>), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiIntervention and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "InterventionIdentificationCode" is required (not null)
            if (InterventionIdentificationCode == null)
            {
                throw new InvalidDataException("InterventionIdentificationCode is a required property for EdFiIntervention and cannot be null");
            }
            else
            {
                this.InterventionIdentificationCode = InterventionIdentificationCode;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for EdFiIntervention and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "BeginDate" is required (not null)
            if (BeginDate == null)
            {
                throw new InvalidDataException("BeginDate is a required property for EdFiIntervention and cannot be null");
            }
            else
            {
                this.BeginDate = BeginDate;
            }
            // to ensure "DeliveryMethodDescriptor" is required (not null)
            if (DeliveryMethodDescriptor == null)
            {
                throw new InvalidDataException("DeliveryMethodDescriptor is a required property for EdFiIntervention and cannot be null");
            }
            else
            {
                this.DeliveryMethodDescriptor = DeliveryMethodDescriptor;
            }
            // to ensure "InterventionClassDescriptor" is required (not null)
            if (InterventionClassDescriptor == null)
            {
                throw new InvalidDataException("InterventionClassDescriptor is a required property for EdFiIntervention and cannot be null");
            }
            else
            {
                this.InterventionClassDescriptor = InterventionClassDescriptor;
            }
            this.AppropriateGradeLevels = AppropriateGradeLevels;
            this.AppropriateSexes = AppropriateSexes;
            this.Diagnoses = Diagnoses;
            this.EducationContents = EducationContents;
            this.EndDate = EndDate;
            this.InterventionPrescriptions = InterventionPrescriptions;
            this.LearningResourceMetadataURIs = LearningResourceMetadataURIs;
            this.MaxDosage = MaxDosage;
            this.MeetingTimes = MeetingTimes;
            this.MinDosage = MinDosage;
            this.PopulationServeds = PopulationServeds;
            this.Staffs = Staffs;
            this.Uris = Uris;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an intervention.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an intervention.</value>
        [DataMember(Name="interventionIdentificationCode", EmitDefaultValue=false)]
        public string InterventionIdentificationCode { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// An unordered collection of interventionAppropriateGradeLevels. Grade levels for the Intervention-if omitted, considered generally applicable.
        /// </summary>
        /// <value>An unordered collection of interventionAppropriateGradeLevels. Grade levels for the Intervention-if omitted, considered generally applicable.</value>
        [DataMember(Name="appropriateGradeLevels", EmitDefaultValue=false)]
        public List<EdFiInterventionAppropriateGradeLevel> AppropriateGradeLevels { get; set; }

        /// <summary>
        /// An unordered collection of interventionAppropriateSexes. Sexes for the Intervention. If omitted, considered generally applicable.
        /// </summary>
        /// <value>An unordered collection of interventionAppropriateSexes. Sexes for the Intervention. If omitted, considered generally applicable.</value>
        [DataMember(Name="appropriateSexes", EmitDefaultValue=false)]
        public List<EdFiInterventionAppropriateSex> AppropriateSexes { get; set; }

        /// <summary>
        /// The start date for the intervention implementation.
        /// </summary>
        /// <value>The start date for the intervention implementation.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The way in which an intervention was implemented: individual, small group, whole class, or whole school.
        /// </summary>
        /// <value>The way in which an intervention was implemented: individual, small group, whole class, or whole school.</value>
        [DataMember(Name="deliveryMethodDescriptor", EmitDefaultValue=false)]
        public string DeliveryMethodDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of interventionDiagnoses. Targeted purpose of the Intervention (e.g., attendance issue, dropout risk).
        /// </summary>
        /// <value>An unordered collection of interventionDiagnoses. Targeted purpose of the Intervention (e.g., attendance issue, dropout risk).</value>
        [DataMember(Name="diagnoses", EmitDefaultValue=false)]
        public List<EdFiInterventionDiagnosis> Diagnoses { get; set; }

        /// <summary>
        /// An unordered collection of interventionEducationContents. Relates the education content source to the education content.
        /// </summary>
        /// <value>An unordered collection of interventionEducationContents. Relates the education content source to the education content.</value>
        [DataMember(Name="educationContents", EmitDefaultValue=false)]
        public List<EdFiInterventionEducationContent> EducationContents { get; set; }

        /// <summary>
        /// The end date for the intervention implementation.
        /// </summary>
        /// <value>The end date for the intervention implementation.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The way in which an intervention is used: curriculum, supplement, or practice.
        /// </summary>
        /// <value>The way in which an intervention is used: curriculum, supplement, or practice.</value>
        [DataMember(Name="interventionClassDescriptor", EmitDefaultValue=false)]
        public string InterventionClassDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of interventionInterventionPrescriptions. The reference to the intervention prescription being followed in this intervention implementation.
        /// </summary>
        /// <value>An unordered collection of interventionInterventionPrescriptions. The reference to the intervention prescription being followed in this intervention implementation.</value>
        [DataMember(Name="interventionPrescriptions", EmitDefaultValue=false)]
        public List<EdFiInterventionInterventionPrescription> InterventionPrescriptions { get; set; }

        /// <summary>
        /// An unordered collection of interventionLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>An unordered collection of interventionLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name="learningResourceMetadataURIs", EmitDefaultValue=false)]
        public List<EdFiInterventionLearningResourceMetadataURI> LearningResourceMetadataURIs { get; set; }

        /// <summary>
        /// The maximum duration of time in minutes that may be assigned for the intervention.
        /// </summary>
        /// <value>The maximum duration of time in minutes that may be assigned for the intervention.</value>
        [DataMember(Name="maxDosage", EmitDefaultValue=false)]
        public int? MaxDosage { get; set; }

        /// <summary>
        /// An unordered collection of interventionMeetingTimes. The times at which this intervention is scheduled to meet.
        /// </summary>
        /// <value>An unordered collection of interventionMeetingTimes. The times at which this intervention is scheduled to meet.</value>
        [DataMember(Name="meetingTimes", EmitDefaultValue=false)]
        public List<EdFiInterventionMeetingTime> MeetingTimes { get; set; }

        /// <summary>
        /// The minimum duration of time in minutes that may be assigned for the intervention.
        /// </summary>
        /// <value>The minimum duration of time in minutes that may be assigned for the intervention.</value>
        [DataMember(Name="minDosage", EmitDefaultValue=false)]
        public int? MinDosage { get; set; }

        /// <summary>
        /// An unordered collection of interventionPopulationServeds. A subset of students that are the focus of the Intervention.
        /// </summary>
        /// <value>An unordered collection of interventionPopulationServeds. A subset of students that are the focus of the Intervention.</value>
        [DataMember(Name="populationServeds", EmitDefaultValue=false)]
        public List<EdFiInterventionPopulationServed> PopulationServeds { get; set; }

        /// <summary>
        /// An unordered collection of interventionStaffs. Relates the staff member associated with the Intervention.
        /// </summary>
        /// <value>An unordered collection of interventionStaffs. Relates the staff member associated with the Intervention.</value>
        [DataMember(Name="staffs", EmitDefaultValue=false)]
        public List<EdFiInterventionStaff> Staffs { get; set; }

        /// <summary>
        /// An unordered collection of interventionURIs. The URI (typical a URL) pointing to an education content item.
        /// </summary>
        /// <value>An unordered collection of interventionURIs. The URI (typical a URL) pointing to an education content item.</value>
        [DataMember(Name="uris", EmitDefaultValue=false)]
        public List<EdFiInterventionURI> Uris { get; set; }

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
            sb.Append("class EdFiIntervention {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InterventionIdentificationCode: ").Append(InterventionIdentificationCode).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  AppropriateGradeLevels: ").Append(AppropriateGradeLevels).Append("\n");
            sb.Append("  AppropriateSexes: ").Append(AppropriateSexes).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  DeliveryMethodDescriptor: ").Append(DeliveryMethodDescriptor).Append("\n");
            sb.Append("  Diagnoses: ").Append(Diagnoses).Append("\n");
            sb.Append("  EducationContents: ").Append(EducationContents).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  InterventionClassDescriptor: ").Append(InterventionClassDescriptor).Append("\n");
            sb.Append("  InterventionPrescriptions: ").Append(InterventionPrescriptions).Append("\n");
            sb.Append("  LearningResourceMetadataURIs: ").Append(LearningResourceMetadataURIs).Append("\n");
            sb.Append("  MaxDosage: ").Append(MaxDosage).Append("\n");
            sb.Append("  MeetingTimes: ").Append(MeetingTimes).Append("\n");
            sb.Append("  MinDosage: ").Append(MinDosage).Append("\n");
            sb.Append("  PopulationServeds: ").Append(PopulationServeds).Append("\n");
            sb.Append("  Staffs: ").Append(Staffs).Append("\n");
            sb.Append("  Uris: ").Append(Uris).Append("\n");
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
            return this.Equals(input as EdFiIntervention);
        }

        /// <summary>
        /// Returns true if EdFiIntervention instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiIntervention to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiIntervention input)
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
                    this.InterventionIdentificationCode == input.InterventionIdentificationCode ||
                    (this.InterventionIdentificationCode != null &&
                    this.InterventionIdentificationCode.Equals(input.InterventionIdentificationCode))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.AppropriateGradeLevels == input.AppropriateGradeLevels ||
                    this.AppropriateGradeLevels != null &&
                    this.AppropriateGradeLevels.SequenceEqual(input.AppropriateGradeLevels)
                ) && 
                (
                    this.AppropriateSexes == input.AppropriateSexes ||
                    this.AppropriateSexes != null &&
                    this.AppropriateSexes.SequenceEqual(input.AppropriateSexes)
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.DeliveryMethodDescriptor == input.DeliveryMethodDescriptor ||
                    (this.DeliveryMethodDescriptor != null &&
                    this.DeliveryMethodDescriptor.Equals(input.DeliveryMethodDescriptor))
                ) && 
                (
                    this.Diagnoses == input.Diagnoses ||
                    this.Diagnoses != null &&
                    this.Diagnoses.SequenceEqual(input.Diagnoses)
                ) && 
                (
                    this.EducationContents == input.EducationContents ||
                    this.EducationContents != null &&
                    this.EducationContents.SequenceEqual(input.EducationContents)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.InterventionClassDescriptor == input.InterventionClassDescriptor ||
                    (this.InterventionClassDescriptor != null &&
                    this.InterventionClassDescriptor.Equals(input.InterventionClassDescriptor))
                ) && 
                (
                    this.InterventionPrescriptions == input.InterventionPrescriptions ||
                    this.InterventionPrescriptions != null &&
                    this.InterventionPrescriptions.SequenceEqual(input.InterventionPrescriptions)
                ) && 
                (
                    this.LearningResourceMetadataURIs == input.LearningResourceMetadataURIs ||
                    this.LearningResourceMetadataURIs != null &&
                    this.LearningResourceMetadataURIs.SequenceEqual(input.LearningResourceMetadataURIs)
                ) && 
                (
                    this.MaxDosage == input.MaxDosage ||
                    (this.MaxDosage != null &&
                    this.MaxDosage.Equals(input.MaxDosage))
                ) && 
                (
                    this.MeetingTimes == input.MeetingTimes ||
                    this.MeetingTimes != null &&
                    this.MeetingTimes.SequenceEqual(input.MeetingTimes)
                ) && 
                (
                    this.MinDosage == input.MinDosage ||
                    (this.MinDosage != null &&
                    this.MinDosage.Equals(input.MinDosage))
                ) && 
                (
                    this.PopulationServeds == input.PopulationServeds ||
                    this.PopulationServeds != null &&
                    this.PopulationServeds.SequenceEqual(input.PopulationServeds)
                ) && 
                (
                    this.Staffs == input.Staffs ||
                    this.Staffs != null &&
                    this.Staffs.SequenceEqual(input.Staffs)
                ) && 
                (
                    this.Uris == input.Uris ||
                    this.Uris != null &&
                    this.Uris.SequenceEqual(input.Uris)
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
                if (this.InterventionIdentificationCode != null)
                    hashCode = hashCode * 59 + this.InterventionIdentificationCode.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.AppropriateGradeLevels != null)
                    hashCode = hashCode * 59 + this.AppropriateGradeLevels.GetHashCode();
                if (this.AppropriateSexes != null)
                    hashCode = hashCode * 59 + this.AppropriateSexes.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.DeliveryMethodDescriptor != null)
                    hashCode = hashCode * 59 + this.DeliveryMethodDescriptor.GetHashCode();
                if (this.Diagnoses != null)
                    hashCode = hashCode * 59 + this.Diagnoses.GetHashCode();
                if (this.EducationContents != null)
                    hashCode = hashCode * 59 + this.EducationContents.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.InterventionClassDescriptor != null)
                    hashCode = hashCode * 59 + this.InterventionClassDescriptor.GetHashCode();
                if (this.InterventionPrescriptions != null)
                    hashCode = hashCode * 59 + this.InterventionPrescriptions.GetHashCode();
                if (this.LearningResourceMetadataURIs != null)
                    hashCode = hashCode * 59 + this.LearningResourceMetadataURIs.GetHashCode();
                if (this.MaxDosage != null)
                    hashCode = hashCode * 59 + this.MaxDosage.GetHashCode();
                if (this.MeetingTimes != null)
                    hashCode = hashCode * 59 + this.MeetingTimes.GetHashCode();
                if (this.MinDosage != null)
                    hashCode = hashCode * 59 + this.MinDosage.GetHashCode();
                if (this.PopulationServeds != null)
                    hashCode = hashCode * 59 + this.PopulationServeds.GetHashCode();
                if (this.Staffs != null)
                    hashCode = hashCode * 59 + this.Staffs.GetHashCode();
                if (this.Uris != null)
                    hashCode = hashCode * 59 + this.Uris.GetHashCode();
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
            // InterventionIdentificationCode (string) maxLength
            if(this.InterventionIdentificationCode != null && this.InterventionIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterventionIdentificationCode, length must be less than 60.", new [] { "InterventionIdentificationCode" });
            }

            // DeliveryMethodDescriptor (string) maxLength
            if(this.DeliveryMethodDescriptor != null && this.DeliveryMethodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryMethodDescriptor, length must be less than 306.", new [] { "DeliveryMethodDescriptor" });
            }

            // InterventionClassDescriptor (string) maxLength
            if(this.InterventionClassDescriptor != null && this.InterventionClassDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InterventionClassDescriptor, length must be less than 306.", new [] { "InterventionClassDescriptor" });
            }

            yield break;
        }
    }

}
