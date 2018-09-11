using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class InterventionStudyInterventionEffectiveness 
    {
        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string diagnosisDescriptor { get; set; }

        /// <summary>
        /// Key for GradeLevel
        /// </summary>
        public string gradeLevelDescriptor { get; set; }

        /// <summary>
        /// Key for PopulationServed
        /// </summary>
        public string populationServedType { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string interventionEffectivenessRatingType { get; set; }

        /// <summary>
        /// Along a percentile distribution of students, the improvement index represents the change in an average student's percentile rank that is considered to be due to the intervention.
        /// </summary>
        public int? improvementIndex { get; set; }

        }
}

