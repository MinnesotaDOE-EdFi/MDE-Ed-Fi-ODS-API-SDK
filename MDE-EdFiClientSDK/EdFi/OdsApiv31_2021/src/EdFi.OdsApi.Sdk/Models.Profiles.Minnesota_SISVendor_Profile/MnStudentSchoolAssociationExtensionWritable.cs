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
    /// MnStudentSchoolAssociationExtensionWritable
    /// </summary>
    [DataContract]
    public partial class MnStudentSchoolAssociationExtensionWritable :  IEquatable<MnStudentSchoolAssociationExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationExtensionWritable" /> class.
        /// </summary>
        /// <param name="SpecialEducationEvaluationStatusDescriptor">An indicator of the students&#39; need for and participation in special education programs during this enrollment period..</param>
        /// <param name="StateAidCategoryDescriptor">State Aid Category..</param>
        /// <param name="HomeboundServiceIndicator">The Homebound Service Indicator is used to validate Membership Days for students who have no Attendance Days. It is an indication of whether students were medically confined to their home and received instruction in the home during the enrollment period..</param>
        /// <param name="SpecialPupilIndicator">An indicator representing a Student  who qualifies as a Special Pupil for Care and Treatment at some time during the school year..</param>
        /// <param name="ResidentLocalEducationAgencyReference">ResidentLocalEducationAgencyReference.</param>
        /// <param name="Membership">Membership.</param>
        /// <param name="Transportation">Transportation.</param>
        public MnStudentSchoolAssociationExtensionWritable(string SpecialEducationEvaluationStatusDescriptor = default(string), string StateAidCategoryDescriptor = default(string), bool? HomeboundServiceIndicator = default(bool?), bool? SpecialPupilIndicator = default(bool?), EdFiLocalEducationAgencyReference ResidentLocalEducationAgencyReference = default(EdFiLocalEducationAgencyReference), MnStudentSchoolAssociationMembershipWritable Membership = default(MnStudentSchoolAssociationMembershipWritable), MnStudentSchoolAssociationTransportationWritable Transportation = default(MnStudentSchoolAssociationTransportationWritable))
        {
            this.SpecialEducationEvaluationStatusDescriptor = SpecialEducationEvaluationStatusDescriptor;
            this.StateAidCategoryDescriptor = StateAidCategoryDescriptor;
            this.HomeboundServiceIndicator = HomeboundServiceIndicator;
            this.SpecialPupilIndicator = SpecialPupilIndicator;
            this.ResidentLocalEducationAgencyReference = ResidentLocalEducationAgencyReference;
            this.Membership = Membership;
            this.Transportation = Transportation;
        }
        
        /// <summary>
        /// An indicator of the students&#39; need for and participation in special education programs during this enrollment period.
        /// </summary>
        /// <value>An indicator of the students&#39; need for and participation in special education programs during this enrollment period.</value>
        [DataMember(Name="specialEducationEvaluationStatusDescriptor", EmitDefaultValue=false)]
        public string SpecialEducationEvaluationStatusDescriptor { get; set; }

        /// <summary>
        /// State Aid Category.
        /// </summary>
        /// <value>State Aid Category.</value>
        [DataMember(Name="stateAidCategoryDescriptor", EmitDefaultValue=false)]
        public string StateAidCategoryDescriptor { get; set; }

        /// <summary>
        /// The Homebound Service Indicator is used to validate Membership Days for students who have no Attendance Days. It is an indication of whether students were medically confined to their home and received instruction in the home during the enrollment period.
        /// </summary>
        /// <value>The Homebound Service Indicator is used to validate Membership Days for students who have no Attendance Days. It is an indication of whether students were medically confined to their home and received instruction in the home during the enrollment period.</value>
        [DataMember(Name="homeboundServiceIndicator", EmitDefaultValue=false)]
        public bool? HomeboundServiceIndicator { get; set; }

        /// <summary>
        /// An indicator representing a Student  who qualifies as a Special Pupil for Care and Treatment at some time during the school year.
        /// </summary>
        /// <value>An indicator representing a Student  who qualifies as a Special Pupil for Care and Treatment at some time during the school year.</value>
        [DataMember(Name="specialPupilIndicator", EmitDefaultValue=false)]
        public bool? SpecialPupilIndicator { get; set; }

        /// <summary>
        /// Gets or Sets ResidentLocalEducationAgencyReference
        /// </summary>
        [DataMember(Name="residentLocalEducationAgencyReference", EmitDefaultValue=false)]
        public EdFiLocalEducationAgencyReference ResidentLocalEducationAgencyReference { get; set; }

        /// <summary>
        /// Gets or Sets Membership
        /// </summary>
        [DataMember(Name="membership", EmitDefaultValue=false)]
        public MnStudentSchoolAssociationMembershipWritable Membership { get; set; }

        /// <summary>
        /// Gets or Sets Transportation
        /// </summary>
        [DataMember(Name="transportation", EmitDefaultValue=false)]
        public MnStudentSchoolAssociationTransportationWritable Transportation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentSchoolAssociationExtensionWritable {\n");
            sb.Append("  SpecialEducationEvaluationStatusDescriptor: ").Append(SpecialEducationEvaluationStatusDescriptor).Append("\n");
            sb.Append("  StateAidCategoryDescriptor: ").Append(StateAidCategoryDescriptor).Append("\n");
            sb.Append("  HomeboundServiceIndicator: ").Append(HomeboundServiceIndicator).Append("\n");
            sb.Append("  SpecialPupilIndicator: ").Append(SpecialPupilIndicator).Append("\n");
            sb.Append("  ResidentLocalEducationAgencyReference: ").Append(ResidentLocalEducationAgencyReference).Append("\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
            sb.Append("  Transportation: ").Append(Transportation).Append("\n");
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
            return this.Equals(input as MnStudentSchoolAssociationExtensionWritable);
        }

        /// <summary>
        /// Returns true if MnStudentSchoolAssociationExtensionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentSchoolAssociationExtensionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentSchoolAssociationExtensionWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecialEducationEvaluationStatusDescriptor == input.SpecialEducationEvaluationStatusDescriptor ||
                    (this.SpecialEducationEvaluationStatusDescriptor != null &&
                    this.SpecialEducationEvaluationStatusDescriptor.Equals(input.SpecialEducationEvaluationStatusDescriptor))
                ) && 
                (
                    this.StateAidCategoryDescriptor == input.StateAidCategoryDescriptor ||
                    (this.StateAidCategoryDescriptor != null &&
                    this.StateAidCategoryDescriptor.Equals(input.StateAidCategoryDescriptor))
                ) && 
                (
                    this.HomeboundServiceIndicator == input.HomeboundServiceIndicator ||
                    (this.HomeboundServiceIndicator != null &&
                    this.HomeboundServiceIndicator.Equals(input.HomeboundServiceIndicator))
                ) && 
                (
                    this.SpecialPupilIndicator == input.SpecialPupilIndicator ||
                    (this.SpecialPupilIndicator != null &&
                    this.SpecialPupilIndicator.Equals(input.SpecialPupilIndicator))
                ) && 
                (
                    this.ResidentLocalEducationAgencyReference == input.ResidentLocalEducationAgencyReference ||
                    (this.ResidentLocalEducationAgencyReference != null &&
                    this.ResidentLocalEducationAgencyReference.Equals(input.ResidentLocalEducationAgencyReference))
                ) && 
                (
                    this.Membership == input.Membership ||
                    (this.Membership != null &&
                    this.Membership.Equals(input.Membership))
                ) && 
                (
                    this.Transportation == input.Transportation ||
                    (this.Transportation != null &&
                    this.Transportation.Equals(input.Transportation))
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
                if (this.SpecialEducationEvaluationStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.SpecialEducationEvaluationStatusDescriptor.GetHashCode();
                if (this.StateAidCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.StateAidCategoryDescriptor.GetHashCode();
                if (this.HomeboundServiceIndicator != null)
                    hashCode = hashCode * 59 + this.HomeboundServiceIndicator.GetHashCode();
                if (this.SpecialPupilIndicator != null)
                    hashCode = hashCode * 59 + this.SpecialPupilIndicator.GetHashCode();
                if (this.ResidentLocalEducationAgencyReference != null)
                    hashCode = hashCode * 59 + this.ResidentLocalEducationAgencyReference.GetHashCode();
                if (this.Membership != null)
                    hashCode = hashCode * 59 + this.Membership.GetHashCode();
                if (this.Transportation != null)
                    hashCode = hashCode * 59 + this.Transportation.GetHashCode();
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
            // SpecialEducationEvaluationStatusDescriptor (string) maxLength
            if(this.SpecialEducationEvaluationStatusDescriptor != null && this.SpecialEducationEvaluationStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SpecialEducationEvaluationStatusDescriptor, length must be less than 306.", new [] { "SpecialEducationEvaluationStatusDescriptor" });
            }

            // StateAidCategoryDescriptor (string) maxLength
            if(this.StateAidCategoryDescriptor != null && this.StateAidCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateAidCategoryDescriptor, length must be less than 306.", new [] { "StateAidCategoryDescriptor" });
            }

            yield break;
        }
    }

}
