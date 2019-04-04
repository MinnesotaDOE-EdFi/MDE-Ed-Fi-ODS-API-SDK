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
    /// EdFiCredentialReference
    /// </summary>
    [DataContract]
    public partial class EdFiCredentialReference :  IEquatable<EdFiCredentialReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCredentialReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCredentialReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCredentialReference" /> class.
        /// </summary>
        /// <param name="CredentialIdentifier">Identifier or serial number assigned to the credential. (required).</param>
        /// <param name="StateOfIssueStateAbbreviationDescriptor">The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. (required).</param>
        /// <param name="Link">Link.</param>
        public EdFiCredentialReference(string CredentialIdentifier = default(string), string StateOfIssueStateAbbreviationDescriptor = default(string), Link Link = default(Link))
        {
            // to ensure "CredentialIdentifier" is required (not null)
            if (CredentialIdentifier == null)
            {
                throw new InvalidDataException("CredentialIdentifier is a required property for EdFiCredentialReference and cannot be null");
            }
            else
            {
                this.CredentialIdentifier = CredentialIdentifier;
            }
            // to ensure "StateOfIssueStateAbbreviationDescriptor" is required (not null)
            if (StateOfIssueStateAbbreviationDescriptor == null)
            {
                throw new InvalidDataException("StateOfIssueStateAbbreviationDescriptor is a required property for EdFiCredentialReference and cannot be null");
            }
            else
            {
                this.StateOfIssueStateAbbreviationDescriptor = StateOfIssueStateAbbreviationDescriptor;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// Identifier or serial number assigned to the credential.
        /// </summary>
        /// <value>Identifier or serial number assigned to the credential.</value>
        [DataMember(Name="credentialIdentifier", EmitDefaultValue=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued.
        /// </summary>
        /// <value>The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued.</value>
        [DataMember(Name="stateOfIssueStateAbbreviationDescriptor", EmitDefaultValue=false)]
        public string StateOfIssueStateAbbreviationDescriptor { get; set; }

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
            sb.Append("class EdFiCredentialReference {\n");
            sb.Append("  CredentialIdentifier: ").Append(CredentialIdentifier).Append("\n");
            sb.Append("  StateOfIssueStateAbbreviationDescriptor: ").Append(StateOfIssueStateAbbreviationDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCredentialReference);
        }

        /// <summary>
        /// Returns true if EdFiCredentialReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCredentialReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCredentialReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CredentialIdentifier == input.CredentialIdentifier ||
                    (this.CredentialIdentifier != null &&
                    this.CredentialIdentifier.Equals(input.CredentialIdentifier))
                ) && 
                (
                    this.StateOfIssueStateAbbreviationDescriptor == input.StateOfIssueStateAbbreviationDescriptor ||
                    (this.StateOfIssueStateAbbreviationDescriptor != null &&
                    this.StateOfIssueStateAbbreviationDescriptor.Equals(input.StateOfIssueStateAbbreviationDescriptor))
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
                if (this.CredentialIdentifier != null)
                    hashCode = hashCode * 59 + this.CredentialIdentifier.GetHashCode();
                if (this.StateOfIssueStateAbbreviationDescriptor != null)
                    hashCode = hashCode * 59 + this.StateOfIssueStateAbbreviationDescriptor.GetHashCode();
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
            // CredentialIdentifier (string) maxLength
            if(this.CredentialIdentifier != null && this.CredentialIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CredentialIdentifier, length must be less than 60.", new [] { "CredentialIdentifier" });
            }

            // StateOfIssueStateAbbreviationDescriptor (string) maxLength
            if(this.StateOfIssueStateAbbreviationDescriptor != null && this.StateOfIssueStateAbbreviationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateOfIssueStateAbbreviationDescriptor, length must be less than 306.", new [] { "StateOfIssueStateAbbreviationDescriptor" });
            }

            yield break;
        }
    }

}
