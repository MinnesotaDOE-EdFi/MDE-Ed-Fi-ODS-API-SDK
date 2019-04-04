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
    /// Student
    /// </summary>
    [DataContract]
    public partial class Student :  IEquatable<Student>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Student() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Student" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="BirthDate">The month, day, and year on which an individual was born. (required).</param>
        /// <param name="EducationOrganizations">An unordered collection of studentEducationOrganizationAssociations. .</param>
        /// <param name="FirstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="LastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="MiddleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="PersonalTitlePrefix">A prefix used to denote the title, degree, position, or seniority of the person..</param>
        /// <param name="Schools">An unordered collection of studentSchoolAssociations. .</param>
        /// <param name="StudentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public Student(string Id = default(string), DateTime? BirthDate = default(DateTime?), List<StudentStudentEducationOrganizationAssociation> EducationOrganizations = default(List<StudentStudentEducationOrganizationAssociation>), string FirstName = default(string), string LastSurname = default(string), string MiddleName = default(string), string PersonalTitlePrefix = default(string), List<StudentStudentSchoolAssociation> Schools = default(List<StudentStudentSchoolAssociation>), string StudentUniqueId = default(string), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Student and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "BirthDate" is required (not null)
            if (BirthDate == null)
            {
                throw new InvalidDataException("BirthDate is a required property for Student and cannot be null");
            }
            else
            {
                this.BirthDate = BirthDate;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for Student and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastSurname" is required (not null)
            if (LastSurname == null)
            {
                throw new InvalidDataException("LastSurname is a required property for Student and cannot be null");
            }
            else
            {
                this.LastSurname = LastSurname;
            }
            // to ensure "StudentUniqueId" is required (not null)
            if (StudentUniqueId == null)
            {
                throw new InvalidDataException("StudentUniqueId is a required property for Student and cannot be null");
            }
            else
            {
                this.StudentUniqueId = StudentUniqueId;
            }
            this.EducationOrganizations = EducationOrganizations;
            this.MiddleName = MiddleName;
            this.PersonalTitlePrefix = PersonalTitlePrefix;
            this.Schools = Schools;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual was born.
        /// </summary>
        /// <value>The month, day, and year on which an individual was born.</value>
        [DataMember(Name="birthDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociations. 
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociations. </value>
        [DataMember(Name="educationOrganizations", EmitDefaultValue=false)]
        public List<StudentStudentEducationOrganizationAssociation> EducationOrganizations { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name="lastSurname", EmitDefaultValue=false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// A prefix used to denote the title, degree, position, or seniority of the person.
        /// </summary>
        /// <value>A prefix used to denote the title, degree, position, or seniority of the person.</value>
        [DataMember(Name="personalTitlePrefix", EmitDefaultValue=false)]
        public string PersonalTitlePrefix { get; set; }

        /// <summary>
        /// An unordered collection of studentSchoolAssociations. 
        /// </summary>
        /// <value>An unordered collection of studentSchoolAssociations. </value>
        [DataMember(Name="schools", EmitDefaultValue=false)]
        public List<StudentStudentSchoolAssociation> Schools { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name="studentUniqueId", EmitDefaultValue=false)]
        public string StudentUniqueId { get; set; }

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
            sb.Append("class Student {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  EducationOrganizations: ").Append(EducationOrganizations).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  PersonalTitlePrefix: ").Append(PersonalTitlePrefix).Append("\n");
            sb.Append("  Schools: ").Append(Schools).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            return this.Equals(input as Student);
        }

        /// <summary>
        /// Returns true if Student instances are equal
        /// </summary>
        /// <param name="input">Instance of Student to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Student input)
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
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.EducationOrganizations == input.EducationOrganizations ||
                    this.EducationOrganizations != null &&
                    this.EducationOrganizations.SequenceEqual(input.EducationOrganizations)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.PersonalTitlePrefix == input.PersonalTitlePrefix ||
                    (this.PersonalTitlePrefix != null &&
                    this.PersonalTitlePrefix.Equals(input.PersonalTitlePrefix))
                ) && 
                (
                    this.Schools == input.Schools ||
                    this.Schools != null &&
                    this.Schools.SequenceEqual(input.Schools)
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
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
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.EducationOrganizations != null)
                    hashCode = hashCode * 59 + this.EducationOrganizations.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.PersonalTitlePrefix != null)
                    hashCode = hashCode * 59 + this.PersonalTitlePrefix.GetHashCode();
                if (this.Schools != null)
                    hashCode = hashCode * 59 + this.Schools.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
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
            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 75.", new [] { "FirstName" });
            }

            // LastSurname (string) maxLength
            if(this.LastSurname != null && this.LastSurname.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be less than 75.", new [] { "LastSurname" });
            }

            // MiddleName (string) maxLength
            if(this.MiddleName != null && this.MiddleName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiddleName, length must be less than 75.", new [] { "MiddleName" });
            }

            // PersonalTitlePrefix (string) maxLength
            if(this.PersonalTitlePrefix != null && this.PersonalTitlePrefix.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonalTitlePrefix, length must be less than 30.", new [] { "PersonalTitlePrefix" });
            }

            // StudentUniqueId (string) maxLength
            if(this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
