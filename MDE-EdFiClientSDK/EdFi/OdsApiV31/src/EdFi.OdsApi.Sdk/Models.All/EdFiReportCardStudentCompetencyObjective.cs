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
    /// EdFiReportCardStudentCompetencyObjective
    /// </summary>
    [DataContract]
    public partial class EdFiReportCardStudentCompetencyObjective :  IEquatable<EdFiReportCardStudentCompetencyObjective>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardStudentCompetencyObjective" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiReportCardStudentCompetencyObjective() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardStudentCompetencyObjective" /> class.
        /// </summary>
        /// <param name="StudentCompetencyObjectiveReference">StudentCompetencyObjectiveReference (required).</param>
        public EdFiReportCardStudentCompetencyObjective(EdFiStudentCompetencyObjectiveReference StudentCompetencyObjectiveReference = default(EdFiStudentCompetencyObjectiveReference))
        {
            // to ensure "StudentCompetencyObjectiveReference" is required (not null)
            if (StudentCompetencyObjectiveReference == null)
            {
                throw new InvalidDataException("StudentCompetencyObjectiveReference is a required property for EdFiReportCardStudentCompetencyObjective and cannot be null");
            }
            else
            {
                this.StudentCompetencyObjectiveReference = StudentCompetencyObjectiveReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets StudentCompetencyObjectiveReference
        /// </summary>
        [DataMember(Name="studentCompetencyObjectiveReference", EmitDefaultValue=false)]
        public EdFiStudentCompetencyObjectiveReference StudentCompetencyObjectiveReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiReportCardStudentCompetencyObjective {\n");
            sb.Append("  StudentCompetencyObjectiveReference: ").Append(StudentCompetencyObjectiveReference).Append("\n");
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
            return this.Equals(input as EdFiReportCardStudentCompetencyObjective);
        }

        /// <summary>
        /// Returns true if EdFiReportCardStudentCompetencyObjective instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiReportCardStudentCompetencyObjective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiReportCardStudentCompetencyObjective input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StudentCompetencyObjectiveReference == input.StudentCompetencyObjectiveReference ||
                    (this.StudentCompetencyObjectiveReference != null &&
                    this.StudentCompetencyObjectiveReference.Equals(input.StudentCompetencyObjectiveReference))
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
                if (this.StudentCompetencyObjectiveReference != null)
                    hashCode = hashCode * 59 + this.StudentCompetencyObjectiveReference.GetHashCode();
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
