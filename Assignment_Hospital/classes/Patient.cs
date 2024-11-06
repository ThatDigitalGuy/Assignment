using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Hospital.classes
{
    internal class Patient
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string DOB { get; set; }
        protected string FirstLineAddress { get; set; }
        protected string SecondLineAddress { get; set; }
        protected string CityAddress { get; set; }
        protected string RegionAddress { get; set; }
        protected string PostCodeAddress { get; set; }

        internal void CreatePatient(string InpName, string InpDOB)
        {
            if (string.IsNullOrWhiteSpace(InpName)) throw new ArgumentNullException("name");
            if (string.IsNullOrWhiteSpace(DOB)) throw new ArgumentNullException("name");
            if (string.IsNullOrWhiteSpace(DOB)) throw new ArgumentNullException("name");
            if (string.IsNullOrWhiteSpace(DOB)) throw new ArgumentNullException("name");
            if (string.IsNullOrWhiteSpace(DOB)) throw new ArgumentNullException("name");

            Name = this.Name;
            DOB = this.DOB;

            List<string> PatientObj = new List<string>();

            PatientObj.Add(Name);
            PatientObj.Add(DOB);

            Console.WriteLine(PatientObj);
        }
    }
}
