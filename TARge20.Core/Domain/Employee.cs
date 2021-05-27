using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalIdentificationCode { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime AtWork { get; set; }
        public string Comment { get; set; }

        public BranchOffice BranchOffice { get; set; }

        public ICollection<Children> Childrens { get; set; }
        public ICollection<HealthCheck> HealthChecks { get; set; }
        public ICollection<SickLeave> SickLeaves { get; set; }
        public ICollection<AccessPermit> AccessPermits { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<JobTitle> JobTitles { get; set; }
        public ICollection<Renting> Rentings { get; set; }
        public ICollection<Working> Workings { get; set; }

        /// TEINE HINDELINE HARJUTUS
        ///
        /// 1. Teha Teie meeskonna poolt esitletud FirmaDB-st objektide struktuur.
        /// 2. Kui see on valmis, siis teha code first migration. Vajadusel võib mitu migrationit teha.
        /// 3. NB! Kasutate enda meeskonna poolt esitatud FirmaDB ERD-d, aga igaüks teeb individuaalselt.
        /// 4. Järgida hea programmeerimise tava.
        /// 5. Kogu solution laadida GitHubi ja link valmis tööst saata mulle.
        /// 6. Järgmisena teha print screen MS SQL-s database diagrams all olevast auto-genereeritud ERD-st pilt. See lisada readMe.md failina sama projekti alla GitHubis.
    }
}
