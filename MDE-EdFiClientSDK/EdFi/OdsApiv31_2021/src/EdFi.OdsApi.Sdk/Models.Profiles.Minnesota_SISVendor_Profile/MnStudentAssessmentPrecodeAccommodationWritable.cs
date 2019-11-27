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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile
{
    /// <summary>
    /// MnStudentAssessmentPrecodeAccommodationWritable
    /// </summary>
    [DataContract]
    public partial class MnStudentAssessmentPrecodeAccommodationWritable :  IEquatable<MnStudentAssessmentPrecodeAccommodationWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeAccommodationWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentAssessmentPrecodeAccommodationWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeAccommodationWritable" /> class.
        /// </summary>
        /// <param name="AccommodationDescriptor">The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:          Braille          Enlarged monitor view          Extra time          Large Print          Setting          Oral Administration          ... (required).</param>
        public MnStudentAssessmentPrecodeAccommodationWritable(string AccommodationDescriptor = default(string))
        {
            // to ensure "AccommodationDescriptor" is required (not null)
            if (AccommodationDescriptor == null)
            {
                throw new InvalidDataException("AccommodationDescriptor is a required property for MnStudentAssessmentPrecodeAccommodationWritable and cannot be null");
            }
            else
            {
                this.AccommodationDescriptor = AccommodationDescriptor;
            }
        }
        
        /// <summary>
        /// The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:          Braille          Enlarged monitor view          Extra time          Large Print          Setting          Oral Administration          ...
        /// </summary>
        /// <value>The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:          Braille          Enlarged monitor view          Extra time          Large Print          Setting          Oral Administration          ...</value>
        [DataMember(Name="accommodationDescriptor", EmitDefaultValue=false)]
        public string AccommodationDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentAssessmentPrecodeAccommodationWritable {\n");
            sb.Append("  AccommodationDescriptor: ").Append(AccommodationDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentAssessmentPrecodeAccommodationWritable);
        }

        /// <summary>
        /// Returns true if MnStudentAssessmentPrecodeAccommodationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentAssessmentPrecodeAccommodationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentAssessmentPrecodeAccommodationWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccommodationDescriptor == input.AccommodationDescriptor ||
                    (this.AccommodationDescriptor != null &&
                    this.AccommodationDescriptor.Equals(input.AccommodationDescriptor))
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
                if (this.AccommodationDescriptor != null)
                    hashCode = hashCode * 59 + this.AccommodationDescriptor.GetHashCode();
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
            // AccommodationDescriptor (string) maxLength
            if(this.AccommodationDescriptor != null && this.AccommodationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccommodationDescriptor, length must be less than 306.", new [] { "AccommodationDescriptor" });
            }

            yield break;
        }
    }

}
