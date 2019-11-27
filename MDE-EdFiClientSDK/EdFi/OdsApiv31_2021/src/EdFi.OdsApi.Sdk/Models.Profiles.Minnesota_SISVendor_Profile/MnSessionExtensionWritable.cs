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
    /// MnSessionExtensionWritable
    /// </summary>
    [DataContract]
    public partial class MnSessionExtensionWritable :  IEquatable<MnSessionExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSessionExtensionWritable" /> class.
        /// </summary>
        /// <param name="DaysInSession">Total days in session..</param>
        /// <param name="TermNumber">Term number..</param>
        public MnSessionExtensionWritable(double? DaysInSession = default(double?), int? TermNumber = default(int?))
        {
            this.DaysInSession = DaysInSession;
            this.TermNumber = TermNumber;
        }
        
        /// <summary>
        /// Total days in session.
        /// </summary>
        /// <value>Total days in session.</value>
        [DataMember(Name="daysInSession", EmitDefaultValue=false)]
        public double? DaysInSession { get; set; }

        /// <summary>
        /// Term number.
        /// </summary>
        /// <value>Term number.</value>
        [DataMember(Name="termNumber", EmitDefaultValue=false)]
        public int? TermNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnSessionExtensionWritable {\n");
            sb.Append("  DaysInSession: ").Append(DaysInSession).Append("\n");
            sb.Append("  TermNumber: ").Append(TermNumber).Append("\n");
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
            return this.Equals(input as MnSessionExtensionWritable);
        }

        /// <summary>
        /// Returns true if MnSessionExtensionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnSessionExtensionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnSessionExtensionWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DaysInSession == input.DaysInSession ||
                    (this.DaysInSession != null &&
                    this.DaysInSession.Equals(input.DaysInSession))
                ) && 
                (
                    this.TermNumber == input.TermNumber ||
                    (this.TermNumber != null &&
                    this.TermNumber.Equals(input.TermNumber))
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
                if (this.DaysInSession != null)
                    hashCode = hashCode * 59 + this.DaysInSession.GetHashCode();
                if (this.TermNumber != null)
                    hashCode = hashCode * 59 + this.TermNumber.GetHashCode();
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
