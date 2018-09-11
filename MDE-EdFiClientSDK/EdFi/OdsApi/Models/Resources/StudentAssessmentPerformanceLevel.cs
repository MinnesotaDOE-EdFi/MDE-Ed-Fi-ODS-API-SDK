using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentAssessmentPerformanceLevel 
    {
        /// <summary>
        /// The ID of the Performance Level Descriptor
        /// </summary>
        public string performanceLevelDescriptor { get; set; }

        /// <summary>
        /// Optional indicator of whether the performance level was met.
        /// </summary>
        public bool? performanceLevelMet { get; set; }

        }
}

