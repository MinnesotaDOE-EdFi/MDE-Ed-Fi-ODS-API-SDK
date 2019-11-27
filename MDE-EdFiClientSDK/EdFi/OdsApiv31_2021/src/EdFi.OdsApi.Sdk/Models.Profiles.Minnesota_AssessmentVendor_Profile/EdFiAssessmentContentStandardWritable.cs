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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_AssessmentVendor_Profile
{
    /// <summary>
    /// EdFiAssessmentContentStandardWritable
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentContentStandardWritable :  IEquatable<EdFiAssessmentContentStandardWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentContentStandardWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentContentStandardWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentContentStandardWritable" /> class.
        /// </summary>
        /// <param name="PublicationStatusDescriptor">The publication status of the document (i.e., Adopted, Draft, Published, Deprecated, Unknown)..</param>
        /// <param name="BeginDate">The beginning of the period during which this learning standard document is intended for use..</param>
        /// <param name="EndDate">The end of the period during which this learning standard document is intended for use..</param>
        /// <param name="PublicationDate">The date on which this content was first published..</param>
        /// <param name="PublicationYear">The year at which this content was first published..</param>
        /// <param name="Title">The name of the content standard, for example Common Core. (required).</param>
        /// <param name="Uri">An unambiguous reference to the standards using a network-resolvable URI..</param>
        /// <param name="Version">The version identifier for the content..</param>
        /// <param name="MandatingEducationOrganizationReference">MandatingEducationOrganizationReference.</param>
        /// <param name="Authors">An unordered collection of assessmentContentStandardAuthors. The person or organization chiefly responsible for the intellectual content of the standard..</param>
        public EdFiAssessmentContentStandardWritable(string PublicationStatusDescriptor = default(string), DateTime? BeginDate = default(DateTime?), DateTime? EndDate = default(DateTime?), DateTime? PublicationDate = default(DateTime?), int? PublicationYear = default(int?), string Title = default(string), string Uri = default(string), string Version = default(string), EdFiEducationOrganizationReference MandatingEducationOrganizationReference = default(EdFiEducationOrganizationReference), List<EdFiAssessmentContentStandardAuthorWritable> Authors = default(List<EdFiAssessmentContentStandardAuthorWritable>))
        {
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for EdFiAssessmentContentStandardWritable and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            this.PublicationStatusDescriptor = PublicationStatusDescriptor;
            this.BeginDate = BeginDate;
            this.EndDate = EndDate;
            this.PublicationDate = PublicationDate;
            this.PublicationYear = PublicationYear;
            this.Uri = Uri;
            this.Version = Version;
            this.MandatingEducationOrganizationReference = MandatingEducationOrganizationReference;
            this.Authors = Authors;
        }
        
        /// <summary>
        /// The publication status of the document (i.e., Adopted, Draft, Published, Deprecated, Unknown).
        /// </summary>
        /// <value>The publication status of the document (i.e., Adopted, Draft, Published, Deprecated, Unknown).</value>
        [DataMember(Name="publicationStatusDescriptor", EmitDefaultValue=false)]
        public string PublicationStatusDescriptor { get; set; }

        /// <summary>
        /// The beginning of the period during which this learning standard document is intended for use.
        /// </summary>
        /// <value>The beginning of the period during which this learning standard document is intended for use.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The end of the period during which this learning standard document is intended for use.
        /// </summary>
        /// <value>The end of the period during which this learning standard document is intended for use.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The date on which this content was first published.
        /// </summary>
        /// <value>The date on which this content was first published.</value>
        [DataMember(Name="publicationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PublicationDate { get; set; }

        /// <summary>
        /// The year at which this content was first published.
        /// </summary>
        /// <value>The year at which this content was first published.</value>
        [DataMember(Name="publicationYear", EmitDefaultValue=false)]
        public int? PublicationYear { get; set; }

        /// <summary>
        /// The name of the content standard, for example Common Core.
        /// </summary>
        /// <value>The name of the content standard, for example Common Core.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// An unambiguous reference to the standards using a network-resolvable URI.
        /// </summary>
        /// <value>An unambiguous reference to the standards using a network-resolvable URI.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The version identifier for the content.
        /// </summary>
        /// <value>The version identifier for the content.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets MandatingEducationOrganizationReference
        /// </summary>
        [DataMember(Name="mandatingEducationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference MandatingEducationOrganizationReference { get; set; }

        /// <summary>
        /// An unordered collection of assessmentContentStandardAuthors. The person or organization chiefly responsible for the intellectual content of the standard.
        /// </summary>
        /// <value>An unordered collection of assessmentContentStandardAuthors. The person or organization chiefly responsible for the intellectual content of the standard.</value>
        [DataMember(Name="authors", EmitDefaultValue=false)]
        public List<EdFiAssessmentContentStandardAuthorWritable> Authors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentContentStandardWritable {\n");
            sb.Append("  PublicationStatusDescriptor: ").Append(PublicationStatusDescriptor).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  PublicationYear: ").Append(PublicationYear).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  MandatingEducationOrganizationReference: ").Append(MandatingEducationOrganizationReference).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
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
            return this.Equals(input as EdFiAssessmentContentStandardWritable);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentContentStandardWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentContentStandardWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentContentStandardWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicationStatusDescriptor == input.PublicationStatusDescriptor ||
                    (this.PublicationStatusDescriptor != null &&
                    this.PublicationStatusDescriptor.Equals(input.PublicationStatusDescriptor))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.PublicationYear == input.PublicationYear ||
                    (this.PublicationYear != null &&
                    this.PublicationYear.Equals(input.PublicationYear))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.MandatingEducationOrganizationReference == input.MandatingEducationOrganizationReference ||
                    (this.MandatingEducationOrganizationReference != null &&
                    this.MandatingEducationOrganizationReference.Equals(input.MandatingEducationOrganizationReference))
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
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
                if (this.PublicationStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.PublicationStatusDescriptor.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.PublicationYear != null)
                    hashCode = hashCode * 59 + this.PublicationYear.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.MandatingEducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.MandatingEducationOrganizationReference.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
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
            // PublicationStatusDescriptor (string) maxLength
            if(this.PublicationStatusDescriptor != null && this.PublicationStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicationStatusDescriptor, length must be less than 306.", new [] { "PublicationStatusDescriptor" });
            }

            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 75.", new [] { "Title" });
            }

            // Uri (string) maxLength
            if(this.Uri != null && this.Uri.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uri, length must be less than 255.", new [] { "Uri" });
            }

            // Version (string) maxLength
            if(this.Version != null && this.Version.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, length must be less than 50.", new [] { "Version" });
            }

            yield break;
        }
    }

}
