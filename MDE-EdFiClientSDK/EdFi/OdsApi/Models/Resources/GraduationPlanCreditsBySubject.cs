using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class GraduationPlanCreditsBySubject 
    {
        /// <summary>
        /// The intended major subject area of the graduation requirement.
        /// </summary>
        public string academicSubjectDescriptor { get; set; }

        /// <summary>
        /// Key for Credit
        /// </summary>
        public string creditType { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        public double? credits { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        public double? creditConversion { get; set; }

        }
}

