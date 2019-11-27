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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Assessment_Vendor_Profile
{
    /// <summary>
    /// MnSchoolYearTypeReference
    /// </summary>
    [DataContract]
    public partial class MnSchoolYearTypeReference :  IEquatable<MnSchoolYearTypeReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolYearTypeReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnSchoolYearTypeReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolYearTypeReference" /> class.
        /// </summary>
        /// <param name="SchoolYear">Key for School Year (required).</param>
        /// <param name="Link">Link.</param>
        public MnSchoolYearTypeReference(int? SchoolYear = default(int?), Link Link = default(Link))
        {
            // to ensure "SchoolYear" is required (not null)
            if (SchoolYear == null)
            {
                throw new InvalidDataException("SchoolYear is a required property for MnSchoolYearTypeReference and cannot be null");
            }
            else
            {
                this.SchoolYear = SchoolYear;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// Key for School Year
        /// </summary>
        /// <value>Key for School Year</value>
        [DataMember(Name="schoolYear", EmitDefaultValue=false)]
        public int? SchoolYear { get; set; }

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
            sb.Append("class MnSchoolYearTypeReference {\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
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
            return this.Equals(input as MnSchoolYearTypeReference);
        }

        /// <summary>
        /// Returns true if MnSchoolYearTypeReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MnSchoolYearTypeReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnSchoolYearTypeReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchoolYear == input.SchoolYear ||
                    (this.SchoolYear != null &&
                    this.SchoolYear.Equals(input.SchoolYear))
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
                if (this.SchoolYear != null)
                    hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
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
            yield break;
        }
    }

}