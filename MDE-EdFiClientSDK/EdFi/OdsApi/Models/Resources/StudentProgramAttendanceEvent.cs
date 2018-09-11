using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentProgramAttendanceEvent 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A reference to the related EducationOrganization resource.
        /// </summary>
        public EducationOrganizationReference educationOrganizationReference { get; set; }

        /// <summary>
        /// A reference to the related Program resource.
        /// </summary>
        public ProgramReference programReference { get; set; }

        /// <summary>
        /// A reference to the related Student resource.
        /// </summary>
        public StudentReference studentReference { get; set; }

        /// <summary>
        /// Key for AttendanceEventCategoryType
        /// </summary>
        public string attendanceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// The reason for the absence or tardy.
        /// </summary>
        public string attendanceEventReason { get; set; }

        /// <summary>
        /// Key for EducationalEnvironment
        /// </summary>
        public string educationalEnvironmentType { get; set; }

        /// <summary>
        /// Date for this attendance event.
        /// </summary>
        public DateTime? eventDate { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

