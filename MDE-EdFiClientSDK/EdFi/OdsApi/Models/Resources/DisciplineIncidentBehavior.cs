using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class DisciplineIncidentBehavior 
    {
        /// <summary>
        /// The ID of the Behavior Descriptor
        /// </summary>
        public string behaviorDescriptor { get; set; }

        /// <summary>
        /// Specifies a more granular level of detail of a behavior involved in the incident.
        /// </summary>
        public string behaviorDetailedDescription { get; set; }

        }
}

