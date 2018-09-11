using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class EducationOrganizationAddress_LocalEducationAgency_Readable 
    {
        /// <summary>
        /// Key for Address
        /// </summary>
        public string addressType { get; set; }

        /// <summary>
        /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
        /// </summary>
        public string stateAbbreviationType { get; set; }

        /// <summary>
        /// The street number and street name or post office box number of an address.
        /// </summary>
        public string streetNumberName { get; set; }

        /// <summary>
        /// The name of the city in which an address is located.
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// The five or nine digit zip code or overseas postal code portion of an address.
        /// </summary>
        public string postalCode { get; set; }

        }
}

