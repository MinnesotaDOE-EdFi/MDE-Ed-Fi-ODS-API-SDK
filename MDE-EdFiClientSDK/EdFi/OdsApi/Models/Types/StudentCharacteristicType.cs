using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Types 
{
    public class StudentCharacteristicType 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Code for StudentCharacteristics type.
        /// </summary>
        public string codeValue { get; set; }

        /// <summary>
        /// The description of the descriptor.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// A shortened description for the student characteristic type.
        /// </summary>
        public string shortDescription { get; set; }

        /// <summary>
        /// Key for StudentCharacteristics
        /// </summary>
        public int? studentCharacteristicTypeId { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

