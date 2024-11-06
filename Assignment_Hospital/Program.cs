using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Assignment_Hospital
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Patient PatientObj = new Patient();

            PatientObj.CreatePatient("John", "Smith", "18/01/24", ["1 test ave", "Royston", "Barnsley", "South Yorkshire", "S71 4XX"]);
        }

        class Patient
        {
            int IdCounter = 0;
            protected int PatientId { get; set; }
            protected string PatientFirstName { get; set; }
            protected string PatientLastName { get; set; }
            protected string PatientDOB { get; set; }
            protected string[] PatientAddress { get; set; }
            protected string[] PatientMedicalHistory { get; set; }
            protected List<string>[] PatientPreScriptions { get; set; }
            protected List<string>[] PatientMedications { get; set; }
            protected List<string>[] PatientNotes { get; set; }


            // New Patient Object
            internal void CreatePatient(string FirstName, string LastName, string DOB, string[] Address)
            {
                PatientId = IdCounter++;
                PatientFirstName = FirstName;
                PatientLastName = FirstName;
                PatientDOB = DOB;
                PatientAddress = Address;
                PatientMedicalHistory = [];
                PatientPreScriptions = [];
                PatientMedications = [];

                string test = "test";
                string filename = $"patient.txt";

                StreamWriter writer = new StreamWriter(filename);
                writer.Write("Hello");
                writer.Close();
            }
        }
    }
}
