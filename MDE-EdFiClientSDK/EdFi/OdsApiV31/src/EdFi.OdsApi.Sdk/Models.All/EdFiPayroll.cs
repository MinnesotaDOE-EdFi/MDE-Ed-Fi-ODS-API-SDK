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
    /// EdFiPayroll
    /// </summary>
    [DataContract]
    public partial class EdFiPayroll :  IEquatable<EdFiPayroll>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPayroll" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiPayroll() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiPayroll" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="AsOfDate">The date of the reported payroll element. (required).</param>
        /// <param name="AccountReference">AccountReference (required).</param>
        /// <param name="StaffReference">StaffReference (required).</param>
        /// <param name="AmountToDate">Current balance (amount paid to employee) for account for the fiscal year. (required).</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiPayroll(string Id = default(string), DateTime? AsOfDate = default(DateTime?), EdFiAccountReference AccountReference = default(EdFiAccountReference), EdFiStaffReference StaffReference = default(EdFiStaffReference), double? AmountToDate = default(double?), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiPayroll and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "AsOfDate" is required (not null)
            if (AsOfDate == null)
            {
                throw new InvalidDataException("AsOfDate is a required property for EdFiPayroll and cannot be null");
            }
            else
            {
                this.AsOfDate = AsOfDate;
            }
            // to ensure "AccountReference" is required (not null)
            if (AccountReference == null)
            {
                throw new InvalidDataException("AccountReference is a required property for EdFiPayroll and cannot be null");
            }
            else
            {
                this.AccountReference = AccountReference;
            }
            // to ensure "StaffReference" is required (not null)
            if (StaffReference == null)
            {
                throw new InvalidDataException("StaffReference is a required property for EdFiPayroll and cannot be null");
            }
            else
            {
                this.StaffReference = StaffReference;
            }
            // to ensure "AmountToDate" is required (not null)
            if (AmountToDate == null)
            {
                throw new InvalidDataException("AmountToDate is a required property for EdFiPayroll and cannot be null");
            }
            else
            {
                this.AmountToDate = AmountToDate;
            }
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The date of the reported payroll element.
        /// </summary>
        /// <value>The date of the reported payroll element.</value>
        [DataMember(Name="asOfDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AsOfDate { get; set; }

        /// <summary>
        /// Gets or Sets AccountReference
        /// </summary>
        [DataMember(Name="accountReference", EmitDefaultValue=false)]
        public EdFiAccountReference AccountReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// Current balance (amount paid to employee) for account for the fiscal year.
        /// </summary>
        /// <value>Current balance (amount paid to employee) for account for the fiscal year.</value>
        [DataMember(Name="amountToDate", EmitDefaultValue=false)]
        public double? AmountToDate { get; set; }

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
            sb.Append("class EdFiPayroll {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  AccountReference: ").Append(AccountReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  AmountToDate: ").Append(AmountToDate).Append("\n");
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
            return this.Equals(input as EdFiPayroll);
        }

        /// <summary>
        /// Returns true if EdFiPayroll instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiPayroll to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiPayroll input)
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
                    this.AsOfDate == input.AsOfDate ||
                    (this.AsOfDate != null &&
                    this.AsOfDate.Equals(input.AsOfDate))
                ) && 
                (
                    this.AccountReference == input.AccountReference ||
                    (this.AccountReference != null &&
                    this.AccountReference.Equals(input.AccountReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.AmountToDate == input.AmountToDate ||
                    (this.AmountToDate != null &&
                    this.AmountToDate.Equals(input.AmountToDate))
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
                if (this.AsOfDate != null)
                    hashCode = hashCode * 59 + this.AsOfDate.GetHashCode();
                if (this.AccountReference != null)
                    hashCode = hashCode * 59 + this.AccountReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.AmountToDate != null)
                    hashCode = hashCode * 59 + this.AmountToDate.GetHashCode();
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
            yield break;
        }
    }

}