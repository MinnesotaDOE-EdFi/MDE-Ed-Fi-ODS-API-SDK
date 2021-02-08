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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_One_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentSchoolAssociationReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSchoolAssociationReadable :  IEquatable<EdFiStudentSchoolAssociationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSchoolAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAssociationReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="EntryDate">The month, day, and year on which an individual enters and begins to receive instructional services in a school. (required).</param>
        /// <param name="SchoolReference">SchoolReference (required).</param>
        /// <param name="SchoolYearTypeReference">SchoolYearTypeReference.</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="EntryGradeLevelDescriptor">The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. (required).</param>
        /// <param name="EntryTypeDescriptor">The process by which a student enters a school during a given academic session..</param>
        /// <param name="ExitWithdrawDate">The month, day, and year of the first day after the date of an individual&#39;s last attendance at a school (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school..</param>
        /// <param name="ExitWithdrawTypeDescriptor">The circumstances under which the student exited from membership in an educational institution..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="Ext">Ext.</param>
        public EdFiStudentSchoolAssociationReadable(string Id = default(string), DateTime? EntryDate = default(DateTime?), EdFiSchoolReference SchoolReference = default(EdFiSchoolReference), EdFiSchoolYearTypeReference SchoolYearTypeReference = default(EdFiSchoolYearTypeReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), string EntryGradeLevelDescriptor = default(string), string EntryTypeDescriptor = default(string), DateTime? ExitWithdrawDate = default(DateTime?), string ExitWithdrawTypeDescriptor = default(string), string Etag = default(string), StudentSchoolAssociationExtensionsReadable Ext = default(StudentSchoolAssociationExtensionsReadable))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "EntryDate" is required (not null)
            if (EntryDate == null)
            {
                throw new InvalidDataException("EntryDate is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.EntryDate = EntryDate;
            }
            // to ensure "SchoolReference" is required (not null)
            if (SchoolReference == null)
            {
                throw new InvalidDataException("SchoolReference is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.SchoolReference = SchoolReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            // to ensure "EntryGradeLevelDescriptor" is required (not null)
            if (EntryGradeLevelDescriptor == null)
            {
                throw new InvalidDataException("EntryGradeLevelDescriptor is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.EntryGradeLevelDescriptor = EntryGradeLevelDescriptor;
            }
            this.SchoolYearTypeReference = SchoolYearTypeReference;
            this.EntryTypeDescriptor = EntryTypeDescriptor;
            this.ExitWithdrawDate = ExitWithdrawDate;
            this.ExitWithdrawTypeDescriptor = ExitWithdrawTypeDescriptor;
            this.Etag = Etag;
            this.Ext = Ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual enters and begins to receive instructional services in a school.
        /// </summary>
        /// <value>The month, day, and year on which an individual enters and begins to receive instructional services in a school.</value>
        [DataMember(Name="entryDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EntryDate { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name="schoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.
        /// </summary>
        /// <value>The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.</value>
        [DataMember(Name="entryGradeLevelDescriptor", EmitDefaultValue=false)]
        public string EntryGradeLevelDescriptor { get; set; }

        /// <summary>
        /// The process by which a student enters a school during a given academic session.
        /// </summary>
        /// <value>The process by which a student enters a school during a given academic session.</value>
        [DataMember(Name="entryTypeDescriptor", EmitDefaultValue=false)]
        public string EntryTypeDescriptor { get; set; }

        /// <summary>
        /// The month, day, and year of the first day after the date of an individual&#39;s last attendance at a school (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school.
        /// </summary>
        /// <value>The month, day, and year of the first day after the date of an individual&#39;s last attendance at a school (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school.</value>
        [DataMember(Name="exitWithdrawDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExitWithdrawDate { get; set; }

        /// <summary>
        /// The circumstances under which the student exited from membership in an educational institution.
        /// </summary>
        /// <value>The circumstances under which the student exited from membership in an educational institution.</value>
        [DataMember(Name="exitWithdrawTypeDescriptor", EmitDefaultValue=false)]
        public string ExitWithdrawTypeDescriptor { get; set; }

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
        public StudentSchoolAssociationExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentSchoolAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EntryGradeLevelDescriptor: ").Append(EntryGradeLevelDescriptor).Append("\n");
            sb.Append("  EntryTypeDescriptor: ").Append(EntryTypeDescriptor).Append("\n");
            sb.Append("  ExitWithdrawDate: ").Append(ExitWithdrawDate).Append("\n");
            sb.Append("  ExitWithdrawTypeDescriptor: ").Append(ExitWithdrawTypeDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentSchoolAssociationReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentSchoolAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSchoolAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSchoolAssociationReadable input)
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
                    this.EntryDate == input.EntryDate ||
                    (this.EntryDate != null &&
                    this.EntryDate.Equals(input.EntryDate))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.EntryGradeLevelDescriptor == input.EntryGradeLevelDescriptor ||
                    (this.EntryGradeLevelDescriptor != null &&
                    this.EntryGradeLevelDescriptor.Equals(input.EntryGradeLevelDescriptor))
                ) && 
                (
                    this.EntryTypeDescriptor == input.EntryTypeDescriptor ||
                    (this.EntryTypeDescriptor != null &&
                    this.EntryTypeDescriptor.Equals(input.EntryTypeDescriptor))
                ) && 
                (
                    this.ExitWithdrawDate == input.ExitWithdrawDate ||
                    (this.ExitWithdrawDate != null &&
                    this.ExitWithdrawDate.Equals(input.ExitWithdrawDate))
                ) && 
                (
                    this.ExitWithdrawTypeDescriptor == input.ExitWithdrawTypeDescriptor ||
                    (this.ExitWithdrawTypeDescriptor != null &&
                    this.ExitWithdrawTypeDescriptor.Equals(input.ExitWithdrawTypeDescriptor))
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
                if (this.EntryDate != null)
                    hashCode = hashCode * 59 + this.EntryDate.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.EntryGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.EntryGradeLevelDescriptor.GetHashCode();
                if (this.EntryTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.EntryTypeDescriptor.GetHashCode();
                if (this.ExitWithdrawDate != null)
                    hashCode = hashCode * 59 + this.ExitWithdrawDate.GetHashCode();
                if (this.ExitWithdrawTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ExitWithdrawTypeDescriptor.GetHashCode();
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
            // EntryGradeLevelDescriptor (string) maxLength
            if(this.EntryGradeLevelDescriptor != null && this.EntryGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntryGradeLevelDescriptor, length must be less than 306.", new [] { "EntryGradeLevelDescriptor" });
            }

            // EntryTypeDescriptor (string) maxLength
            if(this.EntryTypeDescriptor != null && this.EntryTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntryTypeDescriptor, length must be less than 306.", new [] { "EntryTypeDescriptor" });
            }

            // ExitWithdrawTypeDescriptor (string) maxLength
            if(this.ExitWithdrawTypeDescriptor != null && this.ExitWithdrawTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExitWithdrawTypeDescriptor, length must be less than 306.", new [] { "ExitWithdrawTypeDescriptor" });
            }

            yield break;
        }
    }

}
