using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class AssessmentPerformanceLevel 
    {
        /// <summary>
        /// Key for AssessmentReportingMethod
        /// </summary>
        public string assessmentReportingMethodType { get; set; }

        /// <summary>
        /// The performance level(s) defined for the assessment.
        /// </summary>
        public string performanceLevelDescriptor { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string resultDatatypeType { get; set; }

        /// <summary>
        /// The minimum score required to make the indicated level of performance.
        /// </summary>
        public string minimumScore { get; set; }

        /// <summary>
        /// The maximum score to make the indicated level of performance.
        /// </summary>
        public string maximumScore { get; set; }

        }
}

