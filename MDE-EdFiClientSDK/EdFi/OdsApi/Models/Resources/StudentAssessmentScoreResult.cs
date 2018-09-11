using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentAssessmentScoreResult 
    {
        /// <summary>
        /// The name of the analytic score.  For example:  Percentile  Quantile measure  Lexile measure  Vertical scale score  TPM score  ...  ...
        /// </summary>
        public string assessmentReportingMethodType { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string resultDatatypeType { get; set; }

        /// <summary>
        /// A meaningful raw score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        public string result { get; set; }

        }
}

