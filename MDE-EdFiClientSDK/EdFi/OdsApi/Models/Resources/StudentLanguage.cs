using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentLanguage 
    {
        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string languageDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentLanguageUses.  A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        public List<StudentLanguageUse> uses { get; set; }

        }
}

