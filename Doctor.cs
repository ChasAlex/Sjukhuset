using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjukhuset
{
    internal class Doctor:Person
    {
        private double _salary;
        

        public Doctor(double salary, string name)
        {
            _salary = salary;
            _name = name;
            
        }

        void WritePrescription(string drug, Pasient myPatient)
        {
            if (myPatient._diagnosis is "Undiagnosed") {

                Console.WriteLine("No prescription!");                           
            }
            else
            {
                
                myPatient._recept = drug;
                Console.WriteLine($"{myPatient.Name} has been prescribed with {drug}");
            }

        }





    }
}
