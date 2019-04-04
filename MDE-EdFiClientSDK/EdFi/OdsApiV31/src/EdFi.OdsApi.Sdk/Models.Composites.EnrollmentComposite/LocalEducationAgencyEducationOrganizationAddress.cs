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

namespace EdFi.OdsApi.Sdk.Models.Composites.EnrollmentComposite
{
    /// <summary>
    /// LocalEducationAgencyEducationOrganizationAddress
    /// </summary>
    [DataContract]
    public partial class LocalEducationAgencyEducationOrganizationAddress :  IEquatable<LocalEducationAgencyEducationOrganizationAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEducationAgencyEducationOrganizationAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocalEducationAgencyEducationOrganizationAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalEducationAgencyEducationOrganizationAddress" /> class.
        /// </summary>
        /// <param name="AddressTypeDescriptor">The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.) (required).</param>
        /// <param name="StreetNumberName">The street number and street name or post office box number of an address. (required).</param>
        /// <param name="City">The name of the city in which an address is located. (required).</param>
        /// <param name="StateAbbreviationDescriptor">The abbreviation for the state (within the United States) or outlying area in which an address is located. (required).</param>
        /// <param name="PostalCode">The five or nine digit zip code or overseas postal code portion of an address. (required).</param>
        /// <param name="NameOfCounty">The name of the county, parish, borough, or comparable unit (within a state) in                        &#39;which an address is located..</param>
        public LocalEducationAgencyEducationOrganizationAddress(string AddressTypeDescriptor = default(string), string StreetNumberName = default(string), string City = default(string), string StateAbbreviationDescriptor = default(string), string PostalCode = default(string), string NameOfCounty = default(string))
        {
            // to ensure "AddressTypeDescriptor" is required (not null)
            if (AddressTypeDescriptor == null)
            {
                throw new InvalidDataException("AddressTypeDescriptor is a required property for LocalEducationAgencyEducationOrganizationAddress and cannot be null");
            }
            else
            {
                this.AddressTypeDescriptor = AddressTypeDescriptor;
            }
            // to ensure "StreetNumberName" is required (not null)
            if (StreetNumberName == null)
            {
                throw new InvalidDataException("StreetNumberName is a required property for LocalEducationAgencyEducationOrganizationAddress and cannot be null");
            }
            else
            {
                this.StreetNumberName = StreetNumberName;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for LocalEducationAgencyEducationOrganizationAddress and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "StateAbbreviationDescriptor" is required (not null)
            if (StateAbbreviationDescriptor == null)
            {
                throw new InvalidDataException("StateAbbreviationDescriptor is a required property for LocalEducationAgencyEducationOrganizationAddress and cannot be null");
            }
            else
            {
                this.StateAbbreviationDescriptor = StateAbbreviationDescriptor;
            }
            // to ensure "PostalCode" is required (not null)
            if (PostalCode == null)
            {
                throw new InvalidDataException("PostalCode is a required property for LocalEducationAgencyEducationOrganizationAddress and cannot be null");
            }
            else
            {
                this.PostalCode = PostalCode;
            }
            this.NameOfCounty = NameOfCounty;
        }
        
        /// <summary>
        /// The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)
        /// </summary>
        /// <value>The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)</value>
        [DataMember(Name="addressTypeDescriptor", EmitDefaultValue=false)]
        public string AddressTypeDescriptor { get; set; }

        /// <summary>
        /// The street number and street name or post office box number of an address.
        /// </summary>
        /// <value>The street number and street name or post office box number of an address.</value>
        [DataMember(Name="streetNumberName", EmitDefaultValue=false)]
        public string StreetNumberName { get; set; }

        /// <summary>
        /// The name of the city in which an address is located.
        /// </summary>
        /// <value>The name of the city in which an address is located.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
        /// </summary>
        /// <value>The abbreviation for the state (within the United States) or outlying area in which an address is located.</value>
        [DataMember(Name="stateAbbreviationDescriptor", EmitDefaultValue=false)]
        public string StateAbbreviationDescriptor { get; set; }

        /// <summary>
        /// The five or nine digit zip code or overseas postal code portion of an address.
        /// </summary>
        /// <value>The five or nine digit zip code or overseas postal code portion of an address.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The name of the county, parish, borough, or comparable unit (within a state) in                        &#39;which an address is located.
        /// </summary>
        /// <value>The name of the county, parish, borough, or comparable unit (within a state) in                        &#39;which an address is located.</value>
        [DataMember(Name="nameOfCounty", EmitDefaultValue=false)]
        public string NameOfCounty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalEducationAgencyEducationOrganizationAddress {\n");
            sb.Append("  AddressTypeDescriptor: ").Append(AddressTypeDescriptor).Append("\n");
            sb.Append("  StreetNumberName: ").Append(StreetNumberName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateAbbreviationDescriptor: ").Append(StateAbbreviationDescriptor).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  NameOfCounty: ").Append(NameOfCounty).Append("\n");
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
            return this.Equals(input as LocalEducationAgencyEducationOrganizationAddress);
        }

        /// <summary>
        /// Returns true if LocalEducationAgencyEducationOrganizationAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalEducationAgencyEducationOrganizationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalEducationAgencyEducationOrganizationAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressTypeDescriptor == input.AddressTypeDescriptor ||
                    (this.AddressTypeDescriptor != null &&
                    this.AddressTypeDescriptor.Equals(input.AddressTypeDescriptor))
                ) && 
                (
                    this.StreetNumberName == input.StreetNumberName ||
                    (this.StreetNumberName != null &&
                    this.StreetNumberName.Equals(input.StreetNumberName))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateAbbreviationDescriptor == input.StateAbbreviationDescriptor ||
                    (this.StateAbbreviationDescriptor != null &&
                    this.StateAbbreviationDescriptor.Equals(input.StateAbbreviationDescriptor))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.NameOfCounty == input.NameOfCounty ||
                    (this.NameOfCounty != null &&
                    this.NameOfCounty.Equals(input.NameOfCounty))
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
                if (this.AddressTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.AddressTypeDescriptor.GetHashCode();
                if (this.StreetNumberName != null)
                    hashCode = hashCode * 59 + this.StreetNumberName.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateAbbreviationDescriptor != null)
                    hashCode = hashCode * 59 + this.StateAbbreviationDescriptor.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.NameOfCounty != null)
                    hashCode = hashCode * 59 + this.NameOfCounty.GetHashCode();
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
            // AddressTypeDescriptor (string) maxLength
            if(this.AddressTypeDescriptor != null && this.AddressTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressTypeDescriptor, length must be less than 306.", new [] { "AddressTypeDescriptor" });
            }

            // StreetNumberName (string) maxLength
            if(this.StreetNumberName != null && this.StreetNumberName.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetNumberName, length must be less than 150.", new [] { "StreetNumberName" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 30.", new [] { "City" });
            }

            // StateAbbreviationDescriptor (string) maxLength
            if(this.StateAbbreviationDescriptor != null && this.StateAbbreviationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateAbbreviationDescriptor, length must be less than 306.", new [] { "StateAbbreviationDescriptor" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 17)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 17.", new [] { "PostalCode" });
            }

            // NameOfCounty (string) maxLength
            if(this.NameOfCounty != null && this.NameOfCounty.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameOfCounty, length must be less than 30.", new [] { "NameOfCounty" });
            }

            yield break;
        }
    }

}
