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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// MnCourseExtensionReadable
    /// </summary>
    [DataContract]
    public partial class MnCourseExtensionReadable :  IEquatable<MnCourseExtensionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseExtensionReadable" /> class.
        /// </summary>
        /// <param name="CareerClusterDescriptor">Career cluster defines the industry or occupational focus for a career pathways program, plan of study, or course..</param>
        /// <param name="EarlyEducationCourseLocationDescriptor">Classification of instruction site for Early Education. E.g., child&#39;s home or care center..</param>
        /// <param name="StandardAddressedDescriptor">Locality of entity who&#39;s learning standard is addressed by this course. E.g., State, Federal, or Local..</param>
        /// <param name="SequenceLimit">The upper limit of this course within a sequence. E.g., (1 of N).</param>
        /// <param name="AssessmentTools">An unordered collection of courseAssessmentTools. Assessment tool that has been implemented for the course. General purpose but intially implemented for Early Education..</param>
        /// <param name="CurriculumUseds">An unordered collection of courseCurriculumUseds. Curriculum as implemented for the course. General purpose but intially implemented for Early Education..</param>
        /// <param name="LevelTypes">An unordered collection of courseLevelTypes. The &#39;type level&#39; of which the course is associated. E.g, Advanced, Articulated, Basic, Dual, General, No credit, Occupational.</param>
        /// <param name="Programs">An unordered collection of coursePrograms. Program associated to the course. General purpose but intially extended for Early Education..</param>
        public MnCourseExtensionReadable(string CareerClusterDescriptor = default(string), string EarlyEducationCourseLocationDescriptor = default(string), string StandardAddressedDescriptor = default(string), int? SequenceLimit = default(int?), List<MnCourseAssessmentToolReadable> AssessmentTools = default(List<MnCourseAssessmentToolReadable>), List<MnCourseCurriculumUsedReadable> CurriculumUseds = default(List<MnCourseCurriculumUsedReadable>), List<MnCourseLevelTypeReadable> LevelTypes = default(List<MnCourseLevelTypeReadable>), List<MnCourseProgramReadable> Programs = default(List<MnCourseProgramReadable>))
        {
            this.CareerClusterDescriptor = CareerClusterDescriptor;
            this.EarlyEducationCourseLocationDescriptor = EarlyEducationCourseLocationDescriptor;
            this.StandardAddressedDescriptor = StandardAddressedDescriptor;
            this.SequenceLimit = SequenceLimit;
            this.AssessmentTools = AssessmentTools;
            this.CurriculumUseds = CurriculumUseds;
            this.LevelTypes = LevelTypes;
            this.Programs = Programs;
        }
        
        /// <summary>
        /// Career cluster defines the industry or occupational focus for a career pathways program, plan of study, or course.
        /// </summary>
        /// <value>Career cluster defines the industry or occupational focus for a career pathways program, plan of study, or course.</value>
        [DataMember(Name="careerClusterDescriptor", EmitDefaultValue=false)]
        public string CareerClusterDescriptor { get; set; }

        /// <summary>
        /// Classification of instruction site for Early Education. E.g., child&#39;s home or care center.
        /// </summary>
        /// <value>Classification of instruction site for Early Education. E.g., child&#39;s home or care center.</value>
        [DataMember(Name="earlyEducationCourseLocationDescriptor", EmitDefaultValue=false)]
        public string EarlyEducationCourseLocationDescriptor { get; set; }

        /// <summary>
        /// Locality of entity who&#39;s learning standard is addressed by this course. E.g., State, Federal, or Local.
        /// </summary>
        /// <value>Locality of entity who&#39;s learning standard is addressed by this course. E.g., State, Federal, or Local.</value>
        [DataMember(Name="standardAddressedDescriptor", EmitDefaultValue=false)]
        public string StandardAddressedDescriptor { get; set; }

        /// <summary>
        /// The upper limit of this course within a sequence. E.g., (1 of N)
        /// </summary>
        /// <value>The upper limit of this course within a sequence. E.g., (1 of N)</value>
        [DataMember(Name="sequenceLimit", EmitDefaultValue=false)]
        public int? SequenceLimit { get; set; }

        /// <summary>
        /// An unordered collection of courseAssessmentTools. Assessment tool that has been implemented for the course. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of courseAssessmentTools. Assessment tool that has been implemented for the course. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name="assessmentTools", EmitDefaultValue=false)]
        public List<MnCourseAssessmentToolReadable> AssessmentTools { get; set; }

        /// <summary>
        /// An unordered collection of courseCurriculumUseds. Curriculum as implemented for the course. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of courseCurriculumUseds. Curriculum as implemented for the course. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name="curriculumUseds", EmitDefaultValue=false)]
        public List<MnCourseCurriculumUsedReadable> CurriculumUseds { get; set; }

        /// <summary>
        /// An unordered collection of courseLevelTypes. The &#39;type level&#39; of which the course is associated. E.g, Advanced, Articulated, Basic, Dual, General, No credit, Occupational
        /// </summary>
        /// <value>An unordered collection of courseLevelTypes. The &#39;type level&#39; of which the course is associated. E.g, Advanced, Articulated, Basic, Dual, General, No credit, Occupational</value>
        [DataMember(Name="levelTypes", EmitDefaultValue=false)]
        public List<MnCourseLevelTypeReadable> LevelTypes { get; set; }

        /// <summary>
        /// An unordered collection of coursePrograms. Program associated to the course. General purpose but intially extended for Early Education.
        /// </summary>
        /// <value>An unordered collection of coursePrograms. Program associated to the course. General purpose but intially extended for Early Education.</value>
        [DataMember(Name="programs", EmitDefaultValue=false)]
        public List<MnCourseProgramReadable> Programs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnCourseExtensionReadable {\n");
            sb.Append("  CareerClusterDescriptor: ").Append(CareerClusterDescriptor).Append("\n");
            sb.Append("  EarlyEducationCourseLocationDescriptor: ").Append(EarlyEducationCourseLocationDescriptor).Append("\n");
            sb.Append("  StandardAddressedDescriptor: ").Append(StandardAddressedDescriptor).Append("\n");
            sb.Append("  SequenceLimit: ").Append(SequenceLimit).Append("\n");
            sb.Append("  AssessmentTools: ").Append(AssessmentTools).Append("\n");
            sb.Append("  CurriculumUseds: ").Append(CurriculumUseds).Append("\n");
            sb.Append("  LevelTypes: ").Append(LevelTypes).Append("\n");
            sb.Append("  Programs: ").Append(Programs).Append("\n");
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
            return this.Equals(input as MnCourseExtensionReadable);
        }

        /// <summary>
        /// Returns true if MnCourseExtensionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseExtensionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseExtensionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CareerClusterDescriptor == input.CareerClusterDescriptor ||
                    (this.CareerClusterDescriptor != null &&
                    this.CareerClusterDescriptor.Equals(input.CareerClusterDescriptor))
                ) && 
                (
                    this.EarlyEducationCourseLocationDescriptor == input.EarlyEducationCourseLocationDescriptor ||
                    (this.EarlyEducationCourseLocationDescriptor != null &&
                    this.EarlyEducationCourseLocationDescriptor.Equals(input.EarlyEducationCourseLocationDescriptor))
                ) && 
                (
                    this.StandardAddressedDescriptor == input.StandardAddressedDescriptor ||
                    (this.StandardAddressedDescriptor != null &&
                    this.StandardAddressedDescriptor.Equals(input.StandardAddressedDescriptor))
                ) && 
                (
                    this.SequenceLimit == input.SequenceLimit ||
                    (this.SequenceLimit != null &&
                    this.SequenceLimit.Equals(input.SequenceLimit))
                ) && 
                (
                    this.AssessmentTools == input.AssessmentTools ||
                    this.AssessmentTools != null &&
                    this.AssessmentTools.SequenceEqual(input.AssessmentTools)
                ) && 
                (
                    this.CurriculumUseds == input.CurriculumUseds ||
                    this.CurriculumUseds != null &&
                    this.CurriculumUseds.SequenceEqual(input.CurriculumUseds)
                ) && 
                (
                    this.LevelTypes == input.LevelTypes ||
                    this.LevelTypes != null &&
                    this.LevelTypes.SequenceEqual(input.LevelTypes)
                ) && 
                (
                    this.Programs == input.Programs ||
                    this.Programs != null &&
                    this.Programs.SequenceEqual(input.Programs)
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
                if (this.CareerClusterDescriptor != null)
                    hashCode = hashCode * 59 + this.CareerClusterDescriptor.GetHashCode();
                if (this.EarlyEducationCourseLocationDescriptor != null)
                    hashCode = hashCode * 59 + this.EarlyEducationCourseLocationDescriptor.GetHashCode();
                if (this.StandardAddressedDescriptor != null)
                    hashCode = hashCode * 59 + this.StandardAddressedDescriptor.GetHashCode();
                if (this.SequenceLimit != null)
                    hashCode = hashCode * 59 + this.SequenceLimit.GetHashCode();
                if (this.AssessmentTools != null)
                    hashCode = hashCode * 59 + this.AssessmentTools.GetHashCode();
                if (this.CurriculumUseds != null)
                    hashCode = hashCode * 59 + this.CurriculumUseds.GetHashCode();
                if (this.LevelTypes != null)
                    hashCode = hashCode * 59 + this.LevelTypes.GetHashCode();
                if (this.Programs != null)
                    hashCode = hashCode * 59 + this.Programs.GetHashCode();
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
            // CareerClusterDescriptor (string) maxLength
            if(this.CareerClusterDescriptor != null && this.CareerClusterDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CareerClusterDescriptor, length must be less than 306.", new [] { "CareerClusterDescriptor" });
            }

            // EarlyEducationCourseLocationDescriptor (string) maxLength
            if(this.EarlyEducationCourseLocationDescriptor != null && this.EarlyEducationCourseLocationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EarlyEducationCourseLocationDescriptor, length must be less than 306.", new [] { "EarlyEducationCourseLocationDescriptor" });
            }

            // StandardAddressedDescriptor (string) maxLength
            if(this.StandardAddressedDescriptor != null && this.StandardAddressedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StandardAddressedDescriptor, length must be less than 306.", new [] { "StandardAddressedDescriptor" });
            }

            yield break;
        }
    }

}
