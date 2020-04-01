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
    /// MnStudentEarlyEducationProgramAssociationFundingSourceReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentEarlyEducationProgramAssociationFundingSourceReadable :  IEquatable<MnStudentEarlyEducationProgramAssociationFundingSourceReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationFundingSourceReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEarlyEducationProgramAssociationFundingSourceReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationFundingSourceReadable" /> class.
        /// </summary>
        /// <param name="FundingSourceDescriptor">Funding source. (required).</param>
        public MnStudentEarlyEducationProgramAssociationFundingSourceReadable(string FundingSourceDescriptor = default(string))
        {
            // to ensure "FundingSourceDescriptor" is required (not null)
            if (FundingSourceDescriptor == null)
            {
                throw new InvalidDataException("FundingSourceDescriptor is a required property for MnStudentEarlyEducationProgramAssociationFundingSourceReadable and cannot be null");
            }
            else
            {
                this.FundingSourceDescriptor = FundingSourceDescriptor;
            }
        }
        
        /// <summary>
        /// Funding source.
        /// </summary>
        /// <value>Funding source.</value>
        [DataMember(Name="fundingSourceDescriptor", EmitDefaultValue=false)]
        public string FundingSourceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentEarlyEducationProgramAssociationFundingSourceReadable {\n");
            sb.Append("  FundingSourceDescriptor: ").Append(FundingSourceDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentEarlyEducationProgramAssociationFundingSourceReadable);
        }

        /// <summary>
        /// Returns true if MnStudentEarlyEducationProgramAssociationFundingSourceReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEarlyEducationProgramAssociationFundingSourceReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEarlyEducationProgramAssociationFundingSourceReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FundingSourceDescriptor == input.FundingSourceDescriptor ||
                    (this.FundingSourceDescriptor != null &&
                    this.FundingSourceDescriptor.Equals(input.FundingSourceDescriptor))
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
                if (this.FundingSourceDescriptor != null)
                    hashCode = hashCode * 59 + this.FundingSourceDescriptor.GetHashCode();
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
            // FundingSourceDescriptor (string) maxLength
            if(this.FundingSourceDescriptor != null && this.FundingSourceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FundingSourceDescriptor, length must be less than 306.", new [] { "FundingSourceDescriptor" });
            }

            yield break;
        }
    }

}
