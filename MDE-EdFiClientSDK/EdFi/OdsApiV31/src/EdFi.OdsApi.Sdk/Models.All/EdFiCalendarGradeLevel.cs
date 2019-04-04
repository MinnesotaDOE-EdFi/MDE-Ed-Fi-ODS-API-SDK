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
    /// EdFiCalendarGradeLevel
    /// </summary>
    [DataContract]
    public partial class EdFiCalendarGradeLevel :  IEquatable<EdFiCalendarGradeLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarGradeLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCalendarGradeLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarGradeLevel" /> class.
        /// </summary>
        /// <param name="GradeLevelDescriptor">Indicates the GradeLevel associated with the Calendar. (required).</param>
        public EdFiCalendarGradeLevel(string GradeLevelDescriptor = default(string))
        {
            // to ensure "GradeLevelDescriptor" is required (not null)
            if (GradeLevelDescriptor == null)
            {
                throw new InvalidDataException("GradeLevelDescriptor is a required property for EdFiCalendarGradeLevel and cannot be null");
            }
            else
            {
                this.GradeLevelDescriptor = GradeLevelDescriptor;
            }
        }
        
        /// <summary>
        /// Indicates the GradeLevel associated with the Calendar.
        /// </summary>
        /// <value>Indicates the GradeLevel associated with the Calendar.</value>
        [DataMember(Name="gradeLevelDescriptor", EmitDefaultValue=false)]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCalendarGradeLevel {\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCalendarGradeLevel);
        }

        /// <summary>
        /// Returns true if EdFiCalendarGradeLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCalendarGradeLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCalendarGradeLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradeLevelDescriptor == input.GradeLevelDescriptor ||
                    (this.GradeLevelDescriptor != null &&
                    this.GradeLevelDescriptor.Equals(input.GradeLevelDescriptor))
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
                if (this.GradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.GradeLevelDescriptor.GetHashCode();
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
            // GradeLevelDescriptor (string) maxLength
            if(this.GradeLevelDescriptor != null && this.GradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradeLevelDescriptor, length must be less than 306.", new [] { "GradeLevelDescriptor" });
            }

            yield break;
        }
    }

}
