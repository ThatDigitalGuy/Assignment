using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Hospital.classes
{
    class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public Dictionary<string, string> MedicalNotes { get; set; }

        static void CreatePatient(int propId, string propName, string propDOB)
        {
            if (propId < 0) { return; }
            if (propName == null || propName.Count() < 1) { return; }
            if (propDOB != null || propDOB.Count() < 1) { return; }
        }
    }
}
