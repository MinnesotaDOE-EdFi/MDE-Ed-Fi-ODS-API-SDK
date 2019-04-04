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
    /// EdFiStudentInterventionAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentInterventionAssociation :  IEquatable<EdFiStudentInterventionAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentInterventionAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAssociation" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="CohortReference">CohortReference.</param>
        /// <param name="InterventionReference">InterventionReference (required).</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="DiagnosticStatement">A statement provided by the assigner that provides information regarding why the student was assigned to this intervention..</param>
        /// <param name="Dosage">The duration of time in minutes for which the student was assigned to participate in the intervention..</param>
        /// <param name="InterventionEffectivenesses">An unordered collection of studentInterventionAssociationInterventionEffectivenesses. A measure of the effects of an intervention in each outcome domain. The rating of effectiveness takes into account four factors: the quality of the research on the intervention, the statistical significance of the research findings, the size of the differences between participants in the intervention and comparison groups and the consistency in results..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentInterventionAssociation(string Id = default(string), EdFiCohortReference CohortReference = default(EdFiCohortReference), EdFiInterventionReference InterventionReference = default(EdFiInterventionReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), string DiagnosticStatement = default(string), int? Dosage = default(int?), List<EdFiStudentInterventionAssociationInterventionEffectiveness> InterventionEffectivenesses = default(List<EdFiStudentInterventionAssociationInterventionEffectiveness>), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStudentInterventionAssociation and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "InterventionReference" is required (not null)
            if (InterventionReference == null)
            {
                throw new InvalidDataException("InterventionReference is a required property for EdFiStudentInterventionAssociation and cannot be null");
            }
            else
            {
                this.InterventionReference = InterventionReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiStudentInterventionAssociation and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            this.CohortReference = CohortReference;
            this.DiagnosticStatement = DiagnosticStatement;
            this.Dosage = Dosage;
            this.InterventionEffectivenesses = InterventionEffectivenesses;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CohortReference
        /// </summary>
        [DataMember(Name="cohortReference", EmitDefaultValue=false)]
        public EdFiCohortReference CohortReference { get; set; }

        /// <summary>
        /// Gets or Sets InterventionReference
        /// </summary>
        [DataMember(Name="interventionReference", EmitDefaultValue=false)]
        public EdFiInterventionReference InterventionReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// A statement provided by the assigner that provides information regarding why the student was assigned to this intervention.
        /// </summary>
        /// <value>A statement provided by the assigner that provides information regarding why the student was assigned to this intervention.</value>
        [DataMember(Name="diagnosticStatement", EmitDefaultValue=false)]
        public string DiagnosticStatement { get; set; }

        /// <summary>
        /// The duration of time in minutes for which the student was assigned to participate in the intervention.
        /// </summary>
        /// <value>The duration of time in minutes for which the student was assigned to participate in the intervention.</value>
        [DataMember(Name="dosage", EmitDefaultValue=false)]
        public int? Dosage { get; set; }

        /// <summary>
        /// An unordered collection of studentInterventionAssociationInterventionEffectivenesses. A measure of the effects of an intervention in each outcome domain. The rating of effectiveness takes into account four factors: the quality of the research on the intervention, the statistical significance of the research findings, the size of the differences between participants in the intervention and comparison groups and the consistency in results.
        /// </summary>
        /// <value>An unordered collection of studentInterventionAssociationInterventionEffectivenesses. A measure of the effects of an intervention in each outcome domain. The rating of effectiveness takes into account four factors: the quality of the research on the intervention, the statistical significance of the research findings, the size of the differences between participants in the intervention and comparison groups and the consistency in results.</value>
        [DataMember(Name="interventionEffectivenesses", EmitDefaultValue=false)]
        public List<EdFiStudentInterventionAssociationInterventionEffectiveness> InterventionEffectivenesses { get; set; }

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
            sb.Append("class EdFiStudentInterventionAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CohortReference: ").Append(CohortReference).Append("\n");
            sb.Append("  InterventionReference: ").Append(InterventionReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  DiagnosticStatement: ").Append(DiagnosticStatement).Append("\n");
            sb.Append("  Dosage: ").Append(Dosage).Append("\n");
            sb.Append("  InterventionEffectivenesses: ").Append(InterventionEffectivenesses).Append("\n");
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
            return this.Equals(input as EdFiStudentInterventionAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentInterventionAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentInterventionAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentInterventionAssociation input)
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
                    this.CohortReference == input.CohortReference ||
                    (this.CohortReference != null &&
                    this.CohortReference.Equals(input.CohortReference))
                ) && 
                (
                    this.InterventionReference == input.InterventionReference ||
                    (this.InterventionReference != null &&
                    this.InterventionReference.Equals(input.InterventionReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.DiagnosticStatement == input.DiagnosticStatement ||
                    (this.DiagnosticStatement != null &&
                    this.DiagnosticStatement.Equals(input.DiagnosticStatement))
                ) && 
                (
                    this.Dosage == input.Dosage ||
                    (this.Dosage != null &&
                    this.Dosage.Equals(input.Dosage))
                ) && 
                (
                    this.InterventionEffectivenesses == input.InterventionEffectivenesses ||
                    this.InterventionEffectivenesses != null &&
                    this.InterventionEffectivenesses.SequenceEqual(input.InterventionEffectivenesses)
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
                if (this.CohortReference != null)
                    hashCode = hashCode * 59 + this.CohortReference.GetHashCode();
                if (this.InterventionReference != null)
                    hashCode = hashCode * 59 + this.InterventionReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.DiagnosticStatement != null)
                    hashCode = hashCode * 59 + this.DiagnosticStatement.GetHashCode();
                if (this.Dosage != null)
                    hashCode = hashCode * 59 + this.Dosage.GetHashCode();
                if (this.InterventionEffectivenesses != null)
                    hashCode = hashCode * 59 + this.InterventionEffectivenesses.GetHashCode();
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
            // DiagnosticStatement (string) maxLength
            if(this.DiagnosticStatement != null && this.DiagnosticStatement.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiagnosticStatement, length must be less than 1024.", new [] { "DiagnosticStatement" });
            }

            yield break;
        }
    }

}