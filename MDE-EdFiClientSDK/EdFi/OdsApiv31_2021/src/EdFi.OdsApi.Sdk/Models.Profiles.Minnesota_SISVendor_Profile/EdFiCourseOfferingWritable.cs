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
    /// EdFiCourseOfferingWritable
    /// </summary>
    [DataContract]
    public partial class EdFiCourseOfferingWritable :  IEquatable<EdFiCourseOfferingWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseOfferingWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingWritable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="LocalCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="CourseReference">CourseReference (required).</param>
        /// <param name="SchoolReference">SchoolReference (required).</param>
        /// <param name="SessionReference">SessionReference (required).</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="Ext">Ext.</param>
        public EdFiCourseOfferingWritable(string Id = default(string), string LocalCourseCode = default(string), EdFiCourseReference CourseReference = default(EdFiCourseReference), EdFiSchoolReference SchoolReference = default(EdFiSchoolReference), EdFiSessionReference SessionReference = default(EdFiSessionReference), string Etag = default(string), CourseOfferingExtensionsWritable Ext = default(CourseOfferingExtensionsWritable))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiCourseOfferingWritable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "LocalCourseCode" is required (not null)
            if (LocalCourseCode == null)
            {
                throw new InvalidDataException("LocalCourseCode is a required property for EdFiCourseOfferingWritable and cannot be null");
            }
            else
            {
                this.LocalCourseCode = LocalCourseCode;
            }
            // to ensure "CourseReference" is required (not null)
            if (CourseReference == null)
            {
                throw new InvalidDataException("CourseReference is a required property for EdFiCourseOfferingWritable and cannot be null");
            }
            else
            {
                this.CourseReference = CourseReference;
            }
            // to ensure "SchoolReference" is required (not null)
            if (SchoolReference == null)
            {
                throw new InvalidDataException("SchoolReference is a required property for EdFiCourseOfferingWritable and cannot be null");
            }
            else
            {
                this.SchoolReference = SchoolReference;
            }
            // to ensure "SessionReference" is required (not null)
            if (SessionReference == null)
            {
                throw new InvalidDataException("SessionReference is a required property for EdFiCourseOfferingWritable and cannot be null");
            }
            else
            {
                this.SessionReference = SessionReference;
            }
            this.Etag = Etag;
            this.Ext = Ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name="localCourseCode", EmitDefaultValue=false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name="courseReference", EmitDefaultValue=false)]
        public EdFiCourseReference CourseReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SessionReference
        /// </summary>
        [DataMember(Name="sessionReference", EmitDefaultValue=false)]
        public EdFiSessionReference SessionReference { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public CourseOfferingExtensionsWritable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourseOfferingWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SessionReference: ").Append(SessionReference).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiCourseOfferingWritable);
        }

        /// <summary>
        /// Returns true if EdFiCourseOfferingWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseOfferingWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseOfferingWritable input)
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
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.CourseReference == input.CourseReference ||
                    (this.CourseReference != null &&
                    this.CourseReference.Equals(input.CourseReference))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SessionReference == input.SessionReference ||
                    (this.SessionReference != null &&
                    this.SessionReference.Equals(input.SessionReference))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.LocalCourseCode != null)
                    hashCode = hashCode * 59 + this.LocalCourseCode.GetHashCode();
                if (this.CourseReference != null)
                    hashCode = hashCode * 59 + this.CourseReference.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.SessionReference != null)
                    hashCode = hashCode * 59 + this.SessionReference.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
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
            // LocalCourseCode (string) maxLength
            if(this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            yield break;
        }
    }

}
