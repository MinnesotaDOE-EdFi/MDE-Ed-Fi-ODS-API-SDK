using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Types 
{
    public class LevelOfEducationType 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Code for LevelOfEducation type.
        /// </summary>
        public string codeValue { get; set; }

        /// <summary>
        /// Description for LevelOfEducation type.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Key for LevelOfEducation
        /// </summary>
        public int? levelOfEducationTypeId { get; set; }

        /// <summary>
        /// Short description for LevelOfEducation type.
        /// </summary>
        public string shortDescription { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

