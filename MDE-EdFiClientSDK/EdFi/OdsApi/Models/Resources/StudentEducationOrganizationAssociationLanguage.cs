using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentEducationOrganizationAssociationLanguage 
    {
        /// <summary>
        /// A specification of which written or spoken communication is being used.
        /// </summary>
        public string languageDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationLanguageUses.  A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        public List<StudentEducationOrganizationAssociationLanguageUse> uses { get; set; }

        }
}

