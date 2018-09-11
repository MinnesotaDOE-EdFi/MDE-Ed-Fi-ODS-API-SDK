using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StaffIdentificationDocument 
    {
        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string identificationDocumentUseType { get; set; }

        /// <summary>
        /// Key for PersonalInformationVerification
        /// </summary>
        public string personalInformationVerificationType { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string issuerCountryDescriptor { get; set; }

        /// <summary>
        /// The title of the document given by the issuer.
        /// </summary>
        public string documentTitle { get; set; }

        /// <summary>
        /// The day when the document  expires, if null then never expires.
        /// </summary>
        public DateTime? documentExpirationDate { get; set; }

        /// <summary>
        /// The unique identifier on the issuer's identification system.
        /// </summary>
        public string issuerDocumentIdentificationCode { get; set; }

        /// <summary>
        /// Name of the entity or institution that issued the document.
        /// </summary>
        public string issuerName { get; set; }

        }
}

