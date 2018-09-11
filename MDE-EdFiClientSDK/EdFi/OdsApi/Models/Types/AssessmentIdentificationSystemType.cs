using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Types 
{
    public class AssessmentIdentificationSystemType 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Key for AssessmentIdentificationSystem
        /// </summary>
        public int? assessmentIdentificationSystemTypeId { get; set; }

        /// <summary>
        /// Code for AssessmentIdentificationSystem type.
        /// </summary>
        public string codeValue { get; set; }

        /// <summary>
        /// The description of the descriptor.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// A shortened description for the assessment identification system type.
        /// </summary>
        public string shortDescription { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

