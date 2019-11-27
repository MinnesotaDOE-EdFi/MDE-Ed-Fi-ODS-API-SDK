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
    /// MnGradeExtensionReadable
    /// </summary>
    [DataContract]
    public partial class MnGradeExtensionReadable :  IEquatable<MnGradeExtensionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnGradeExtensionReadable" /> class.
        /// </summary>
        /// <param name="CollegeCreditEarned">College credit earned..</param>
        /// <param name="CollegeGradeEarned">College grade earned..</param>
        /// <param name="LocalCreditEarned">College credit earned..</param>
        public MnGradeExtensionReadable(double? CollegeCreditEarned = default(double?), string CollegeGradeEarned = default(string), double? LocalCreditEarned = default(double?))
        {
            this.CollegeCreditEarned = CollegeCreditEarned;
            this.CollegeGradeEarned = CollegeGradeEarned;
            this.LocalCreditEarned = LocalCreditEarned;
        }
        
        /// <summary>
        /// College credit earned.
        /// </summary>
        /// <value>College credit earned.</value>
        [DataMember(Name="collegeCreditEarned", EmitDefaultValue=false)]
        public double? CollegeCreditEarned { get; set; }

        /// <summary>
        /// College grade earned.
        /// </summary>
        /// <value>College grade earned.</value>
        [DataMember(Name="collegeGradeEarned", EmitDefaultValue=false)]
        public string CollegeGradeEarned { get; set; }

        /// <summary>
        /// College credit earned.
        /// </summary>
        /// <value>College credit earned.</value>
        [DataMember(Name="localCreditEarned", EmitDefaultValue=false)]
        public double? LocalCreditEarned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnGradeExtensionReadable {\n");
            sb.Append("  CollegeCreditEarned: ").Append(CollegeCreditEarned).Append("\n");
            sb.Append("  CollegeGradeEarned: ").Append(CollegeGradeEarned).Append("\n");
            sb.Append("  LocalCreditEarned: ").Append(LocalCreditEarned).Append("\n");
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
            return this.Equals(input as MnGradeExtensionReadable);
        }

        /// <summary>
        /// Returns true if MnGradeExtensionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnGradeExtensionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnGradeExtensionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollegeCreditEarned == input.CollegeCreditEarned ||
                    (this.CollegeCreditEarned != null &&
                    this.CollegeCreditEarned.Equals(input.CollegeCreditEarned))
                ) && 
                (
                    this.CollegeGradeEarned == input.CollegeGradeEarned ||
                    (this.CollegeGradeEarned != null &&
                    this.CollegeGradeEarned.Equals(input.CollegeGradeEarned))
                ) && 
                (
                    this.LocalCreditEarned == input.LocalCreditEarned ||
                    (this.LocalCreditEarned != null &&
                    this.LocalCreditEarned.Equals(input.LocalCreditEarned))
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
                if (this.CollegeCreditEarned != null)
                    hashCode = hashCode * 59 + this.CollegeCreditEarned.GetHashCode();
                if (this.CollegeGradeEarned != null)
                    hashCode = hashCode * 59 + this.CollegeGradeEarned.GetHashCode();
                if (this.LocalCreditEarned != null)
                    hashCode = hashCode * 59 + this.LocalCreditEarned.GetHashCode();
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
            // CollegeGradeEarned (string) maxLength
            if(this.CollegeGradeEarned != null && this.CollegeGradeEarned.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CollegeGradeEarned, length must be less than 16.", new [] { "CollegeGradeEarned" });
            }

            yield break;
        }
    }

}
