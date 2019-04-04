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
    /// EdFiStudentAssessmentItem
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAssessmentItem :  IEquatable<EdFiStudentAssessmentItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAssessmentItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentItem" /> class.
        /// </summary>
        /// <param name="AssessmentItemResultDescriptor">The analyzed result of a student&#39;s response to an assessment item. For example:          Correct          Incorrect           Met standard          ... (required).</param>
        /// <param name="ResponseIndicatorDescriptor">Indicator of the response. For example:          Nonscorable response          Ineffective response          Effective response          Partial response          ....</param>
        /// <param name="AssessmentResponse">A student&#39;s response to a stimulus on a test..</param>
        /// <param name="DescriptiveFeedback">The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item..</param>
        /// <param name="RawScoreResult">A meaningful raw score of the performance of an individual on an assessment item..</param>
        /// <param name="TimeAssessed">The overall time a student actually spent during the AssessmentItem..</param>
        /// <param name="AssessmentItemReference">AssessmentItemReference (required).</param>
        public EdFiStudentAssessmentItem(string AssessmentItemResultDescriptor = default(string), string ResponseIndicatorDescriptor = default(string), string AssessmentResponse = default(string), string DescriptiveFeedback = default(string), int? RawScoreResult = default(int?), string TimeAssessed = default(string), EdFiAssessmentItemReference AssessmentItemReference = default(EdFiAssessmentItemReference))
        {
            // to ensure "AssessmentItemResultDescriptor" is required (not null)
            if (AssessmentItemResultDescriptor == null)
            {
                throw new InvalidDataException("AssessmentItemResultDescriptor is a required property for EdFiStudentAssessmentItem and cannot be null");
            }
            else
            {
                this.AssessmentItemResultDescriptor = AssessmentItemResultDescriptor;
            }
            // to ensure "AssessmentItemReference" is required (not null)
            if (AssessmentItemReference == null)
            {
                throw new InvalidDataException("AssessmentItemReference is a required property for EdFiStudentAssessmentItem and cannot be null");
            }
            else
            {
                this.AssessmentItemReference = AssessmentItemReference;
            }
            this.ResponseIndicatorDescriptor = ResponseIndicatorDescriptor;
            this.AssessmentResponse = AssessmentResponse;
            this.DescriptiveFeedback = DescriptiveFeedback;
            this.RawScoreResult = RawScoreResult;
            this.TimeAssessed = TimeAssessed;
        }
        
        /// <summary>
        /// The analyzed result of a student&#39;s response to an assessment item. For example:          Correct          Incorrect           Met standard          ...
        /// </summary>
        /// <value>The analyzed result of a student&#39;s response to an assessment item. For example:          Correct          Incorrect           Met standard          ...</value>
        [DataMember(Name="assessmentItemResultDescriptor", EmitDefaultValue=false)]
        public string AssessmentItemResultDescriptor { get; set; }

        /// <summary>
        /// Indicator of the response. For example:          Nonscorable response          Ineffective response          Effective response          Partial response          ...
        /// </summary>
        /// <value>Indicator of the response. For example:          Nonscorable response          Ineffective response          Effective response          Partial response          ...</value>
        [DataMember(Name="responseIndicatorDescriptor", EmitDefaultValue=false)]
        public string ResponseIndicatorDescriptor { get; set; }

        /// <summary>
        /// A student&#39;s response to a stimulus on a test.
        /// </summary>
        /// <value>A student&#39;s response to a stimulus on a test.</value>
        [DataMember(Name="assessmentResponse", EmitDefaultValue=false)]
        public string AssessmentResponse { get; set; }

        /// <summary>
        /// The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item.
        /// </summary>
        /// <value>The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item.</value>
        [DataMember(Name="descriptiveFeedback", EmitDefaultValue=false)]
        public string DescriptiveFeedback { get; set; }

        /// <summary>
        /// A meaningful raw score of the performance of an individual on an assessment item.
        /// </summary>
        /// <value>A meaningful raw score of the performance of an individual on an assessment item.</value>
        [DataMember(Name="rawScoreResult", EmitDefaultValue=false)]
        public int? RawScoreResult { get; set; }

        /// <summary>
        /// The overall time a student actually spent during the AssessmentItem.
        /// </summary>
        /// <value>The overall time a student actually spent during the AssessmentItem.</value>
        [DataMember(Name="timeAssessed", EmitDefaultValue=false)]
        public string TimeAssessed { get; set; }

        /// <summary>
        /// Gets or Sets AssessmentItemReference
        /// </summary>
        [DataMember(Name="assessmentItemReference", EmitDefaultValue=false)]
        public EdFiAssessmentItemReference AssessmentItemReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentItem {\n");
            sb.Append("  AssessmentItemResultDescriptor: ").Append(AssessmentItemResultDescriptor).Append("\n");
            sb.Append("  ResponseIndicatorDescriptor: ").Append(ResponseIndicatorDescriptor).Append("\n");
            sb.Append("  AssessmentResponse: ").Append(AssessmentResponse).Append("\n");
            sb.Append("  DescriptiveFeedback: ").Append(DescriptiveFeedback).Append("\n");
            sb.Append("  RawScoreResult: ").Append(RawScoreResult).Append("\n");
            sb.Append("  TimeAssessed: ").Append(TimeAssessed).Append("\n");
            sb.Append("  AssessmentItemReference: ").Append(AssessmentItemReference).Append("\n");
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
            return this.Equals(input as EdFiStudentAssessmentItem);
        }

        /// <summary>
        /// Returns true if EdFiStudentAssessmentItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAssessmentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAssessmentItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentItemResultDescriptor == input.AssessmentItemResultDescriptor ||
                    (this.AssessmentItemResultDescriptor != null &&
                    this.AssessmentItemResultDescriptor.Equals(input.AssessmentItemResultDescriptor))
                ) && 
                (
                    this.ResponseIndicatorDescriptor == input.ResponseIndicatorDescriptor ||
                    (this.ResponseIndicatorDescriptor != null &&
                    this.ResponseIndicatorDescriptor.Equals(input.ResponseIndicatorDescriptor))
                ) && 
                (
                    this.AssessmentResponse == input.AssessmentResponse ||
                    (this.AssessmentResponse != null &&
                    this.AssessmentResponse.Equals(input.AssessmentResponse))
                ) && 
                (
                    this.DescriptiveFeedback == input.DescriptiveFeedback ||
                    (this.DescriptiveFeedback != null &&
                    this.DescriptiveFeedback.Equals(input.DescriptiveFeedback))
                ) && 
                (
                    this.RawScoreResult == input.RawScoreResult ||
                    (this.RawScoreResult != null &&
                    this.RawScoreResult.Equals(input.RawScoreResult))
                ) && 
                (
                    this.TimeAssessed == input.TimeAssessed ||
                    (this.TimeAssessed != null &&
                    this.TimeAssessed.Equals(input.TimeAssessed))
                ) && 
                (
                    this.AssessmentItemReference == input.AssessmentItemReference ||
                    (this.AssessmentItemReference != null &&
                    this.AssessmentItemReference.Equals(input.AssessmentItemReference))
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
                if (this.AssessmentItemResultDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentItemResultDescriptor.GetHashCode();
                if (this.ResponseIndicatorDescriptor != null)
                    hashCode = hashCode * 59 + this.ResponseIndicatorDescriptor.GetHashCode();
                if (this.AssessmentResponse != null)
                    hashCode = hashCode * 59 + this.AssessmentResponse.GetHashCode();
                if (this.DescriptiveFeedback != null)
                    hashCode = hashCode * 59 + this.DescriptiveFeedback.GetHashCode();
                if (this.RawScoreResult != null)
                    hashCode = hashCode * 59 + this.RawScoreResult.GetHashCode();
                if (this.TimeAssessed != null)
                    hashCode = hashCode * 59 + this.TimeAssessed.GetHashCode();
                if (this.AssessmentItemReference != null)
                    hashCode = hashCode * 59 + this.AssessmentItemReference.GetHashCode();
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
            // AssessmentItemResultDescriptor (string) maxLength
            if(this.AssessmentItemResultDescriptor != null && this.AssessmentItemResultDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentItemResultDescriptor, length must be less than 306.", new [] { "AssessmentItemResultDescriptor" });
            }

            // ResponseIndicatorDescriptor (string) maxLength
            if(this.ResponseIndicatorDescriptor != null && this.ResponseIndicatorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseIndicatorDescriptor, length must be less than 306.", new [] { "ResponseIndicatorDescriptor" });
            }

            // AssessmentResponse (string) maxLength
            if(this.AssessmentResponse != null && this.AssessmentResponse.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentResponse, length must be less than 60.", new [] { "AssessmentResponse" });
            }

            // DescriptiveFeedback (string) maxLength
            if(this.DescriptiveFeedback != null && this.DescriptiveFeedback.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DescriptiveFeedback, length must be less than 1024.", new [] { "DescriptiveFeedback" });
            }

            // TimeAssessed (string) maxLength
            if(this.TimeAssessed != null && this.TimeAssessed.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeAssessed, length must be less than 30.", new [] { "TimeAssessed" });
            }

            yield break;
        }
    }

}
